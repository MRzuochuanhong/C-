using DAYT.BLL;
using DAYT.Model;
using DAYT.Model.DAYTPlatform;
using DAYT.Model.SqlHelp;
using DAYT.ScheduleTask.Tasks;
using DAYT.WebCommon;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace DAYT.ScheduleTask.TaskManagement
{
    public class AutomaticReceipt:ITask
    {
        TOP_OrderBLL bll = new TOP_OrderBLL();
        TOP_AccountBLL accountOrderBLL = new TOP_AccountBLL();
        private static object Lock = new object();
        public void Execute(IRepository _repository)
        {
            lock (Lock) {
                try
                {
                    DateTime dateTime = DateTime.Now.AddDays(-7);
                    Expression<Func<TOP_Order, bool>> exp = a => a.Status == 1 && a.RefundState == 0 && a.State == 80 && a.LastUpdateTime < dateTime;
                    var order = _repository.GetAllQuery(exp).OrderBy(a => a.LastUpdateTime).Take(10).ToList();
                    foreach (var item in order)
                    {
                        if (!string.IsNullOrEmpty(item.Mobile))
                        {
                            UpdateOrder(item.OrderId, item.MemberId, item.Mobile);
                        }
                    }
                }
                catch (Exception e)
                {
                    Guid guid = Guid.NewGuid();
                    LogHelper.AddTOP_MemberOperateLog(LogType.Update, guid, "", "TOP_Order", "", string.Format($"收货错误问题:{e.Message}", "", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                }
            }
        }
        public void UpdateOrder(Guid orderId,Guid MemberId,string Mobile)
        {
            try
            { 
                var billInfo = bll.GetSplitBillPage(orderId.ToString());
                if(billInfo.Result==1000)
                {
                    if (billInfo?.Data == null || billInfo.Data.Count == 0)
                    {
                        RequestResult resultc = bll.ConfirmationReceiving(orderId.ToString(), MemberId.ToString());
                        if (resultc.Result == 1000)
                        {
                            LogHelper.AddTOP_MemberOperateLog(LogType.Update, MemberId, Mobile, "TOP_Order", orderId.ToString(), string.Format("会员 {0} 在 {1} 对该笔订单进行了【自动收货】操作。", Mobile, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                        }
                        else
                        {
                            LogHelper.AddTOP_MemberOperateLog(LogType.Update, MemberId, Mobile, "TOP_Order", orderId.ToString(), string.Format("会员 {0} 在 {1} 对该笔订单进行了【自动收货失败】操作。", Mobile, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
                        }
                    }
                    else
                    {
                        //是否存在通联 支付的账单
                        var tlPayBill = billInfo.Data.Where(p => p.InAccountType == 1);
                        string inAccountOrderNo = Guid.NewGuid().ToString();
                        var result = accountOrderBLL.UpdataSplitBill(orderId.ToString(), inAccountOrderNo); //修改inAccountOrderNo
                        if (result.Result == 1000)
                        {
                            if (tlPayBill.Count() > 0)
                            {
                                var billModel = tlPayBill.FirstOrDefault();
                                RequestResult PayAccount = new RequestResult();
                                if (string.IsNullOrEmpty(billModel.InAccountNo) || string.IsNullOrEmpty(billModel.FromAccountNo))
                                {
                                    //旧数据处理
                                    PayAccount = bll.SignalAgentPay(billModel.PayOrderApplyId.ToString(), inAccountOrderNo, billModel.ShopId.ToString(), (long)(tlPayBill.Sum(x => x.PayFee) * 100), (long)(tlPayBill.Sum(x => x.HandFee) * 100));
                                    LogHelper.AddTOP_MemberOperateLog(LogType.Update, MemberId, Mobile, "TOP_Order", orderId.ToString(), string.Format($"会员 {Mobile} 在 {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} 对该笔订单进行了【自动收货】操作!:{PayAccount.Msg}"));

                                }
                                else
                                {
                                    PayAccount = bll.SignalAgentPayV2(billModel.PayOrderApplyId.ToString(), inAccountOrderNo, billModel.InAccountNo.ToString(), (long)(tlPayBill.Sum(x => x.PayFee) * 100), (long)(tlPayBill.Sum(x => x.HandFee) * 100), (long)(tlPayBill.Sum(x => x.ServiceFee) * 100));
                                    LogHelper.AddTOP_MemberOperateLog(LogType.Update, MemberId, Mobile, "TOP_Order", orderId.ToString(), string.Format($"会员 {Mobile} 在 {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} 对该笔订单进行了【确认收货】操作:{PayAccount.Msg}"));
                                }
                            }
                            else
                            {
                                RequestResult PayAccount = bll.SignalAgentPayAccount(inAccountOrderNo, "");//平台业务逻辑//通联代付
                                LogHelper.AddTOP_MemberOperateLog(LogType.Update, MemberId, Mobile, "TOP_Order", orderId.ToString(), string.Format($"会员 {Mobile} 在 {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} 对该笔订单进行了【确认收货】操作!{PayAccount.Msg}"));
                            }
                        }
                    }
                }                
            }
            catch(Exception e)
            {
                LogHelper.AddTOP_MemberOperateLog(LogType.Update, MemberId, Mobile, "TOP_Order", orderId.ToString(), string.Format($"收货错误问题：{e.Message}", Mobile, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
            }            
            
        }
    }
}