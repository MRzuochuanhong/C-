using DAYT.BLL;
using DAYT.Model.DAYTPlatform;
using DAYT.Model.SqlHelp;
using DAYT.ScheduleTask.Tasks;
using DAYT.WebCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace DAYT.ScheduleTask.TaskManagement
{
    public class SendHistory : ITask
    {
        SYS_SendHistoryBLL sendBll = new SYS_SendHistoryBLL();
        public void Execute(IRepository _repository)
        {
            //DateTime dateTime = DateTime.Now.AddDays(-1);
            ////Expression<Func<TOP_Order, bool>> exp = a =>a.IsPay==true&&a.RefundState==0&&a.Status==1&&a.State<=60&&a.LastUpdateTime<= dateTime;
            //var order = _repository.GetAllQuery<TOP_Order>(a => a.IsPay == true && a.RefundState == 0 && a.Status == 1 &&( a.State == 60|| a.State==10) && a.LastUpdateTime <= dateTime).ToList();
            //foreach (var item in order)
            //{
            //    Expression<Func<TOP_Shop, bool>> exp1 = a => a.ShopId == item.ShopId;
            //    TOP_Shop tOP_Shop = _repository.GetFristDefault<TOP_Shop>(exp1);
            //    if (item.State == 60)
            //    {
            //        if (WebCommon.WebHelper.IsHandset(tOP_Shop.Tel))
            //        {
            //            string msg = sendBll.GetTemplateContentByParms("37703315-F7F9-45FC-8C05-D5A602EBBD28", item.OrderCode);//提醒生产短信通知
            //            WebCommon.SMSHelper.Submit(tOP_Shop.Tel, msg);
            //        }
            //        item.LastUpdateTime = dateTime.AddDays(1);
            //        _repository.Update(item);
            //    }
            //    if (item.State == 10)
            //    {
            //        if (WebCommon.WebHelper.IsHandset(tOP_Shop.Tel))
            //        {
            //            string msg1 = sendBll.GetTemplateContentByParms("1FD6C66F-4D9F-45DD-8326-2055982A8FAA", item.OrderCode);//提醒发货短信通知
            //            WebCommon.SMSHelper.Submit(tOP_Shop.Tel, msg1);
            //        }
            //        item.LastUpdateTime = dateTime.AddDays(1);
            //        _repository.Update(item);
            //    }
            //}
        }

    }
}