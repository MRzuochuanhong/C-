using DAYT.BLL;
using DAYT.WebCommon;
using DAYT.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.BLL
{
    public class TOP_OrderBLL : BaseBLL
    {
        #region 确认收货
        public RequestResult ConfirmationReceiving(string orderId, string memberId)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("orderId", orderId);
            dictionary.Add("memberId", memberId);
            string result = WebHelper.GetRequest(OrderDataInterface + "TOP_Order/ConfirmationReceiving", dictionary);
            RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);
            return requestResult;
        }
        #endregion

        /// <summary>
        /// 获得订单的分账信息
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public SplitBillPageResult GetSplitBillPage(string orderId)
        {
            try
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("shopId", "");
                dictionary.Add("orderId", orderId);
                dictionary.Add("payOrderCode", "");
                dictionary.Add("inAccountType", "0");
                dictionary.Add("pageIndex", "1");
                dictionary.Add("pageSize", "10");

                string result = WebHelper.GetRequest(OrderDataInterface + "TOP_SplitBill/GetTOPSplitBillByPage", dictionary);
                return JsonConvert.DeserializeObject<SplitBillPageResult>(result, new JsonSerializerSettings { DateTimeZoneHandling = DateTimeZoneHandling.Local });
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 通联代付
        /// </summary>
        /// <param name="memberId">用户ID</param>
        /// <param name="orderId">订单ID</param>
        /// <returns></returns>
        public RequestResult SignalAgentPay(string payOrderApplyId, string inAccountOrderNo, string bizUserId, long amount,long fee)
        {
            try
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("payOrderApplyId", payOrderApplyId);
                dictionary.Add("inAccountOrderNo", inAccountOrderNo);
                dictionary.Add("bizUserId", bizUserId);
                dictionary.Add("amount", amount.ToString());
                dictionary.Add("fee", fee.ToString());
                string result = WebHelper.GetRequest(AccountInterface + "Order/SignalAgentPay", dictionary);
                RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);
                return requestResult;
            }
            catch
            {
                return null;
            }
        }
        /// <summary>
        /// 平台代付业务逻辑
        /// </summary>
        /// <param name="orderNo">云商通订单号</param>
        /// <param name="orderId">订单ID</param>
        /// <returns></returns>
        public RequestResult SignalAgentPayAccount(string inAccountOrderNo, string orderNo)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("orderNo", orderNo);
            dictionary.Add("inAccountOrderNo", inAccountOrderNo);
            string result = WebHelper.GetRequest(AccountInterface + "Order/SignalAgentPayAccount", dictionary);
            RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);
            return requestResult;
        }
        /// <summary>
        /// 通联代付
        /// </summary>
        /// <param name="memberId">用户ID</param>
        /// <param name="orderId">订单ID</param>
        /// <returns></returns>
        public RequestResult SignalAgentPayV2(string payOrderApplyId, string inAccountOrderNo, string bizUserId, long amount, long fee, long serviceFee)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("payOrderApplyId", payOrderApplyId);
            dictionary.Add("inAccountOrderNo", inAccountOrderNo);
            dictionary.Add("bizUserId", bizUserId);
            dictionary.Add("amount", amount.ToString());
            dictionary.Add("fee", fee.ToString());
            dictionary.Add("serviceFee", serviceFee.ToString());
            string result = WebHelper.GetRequest(AccountInterface + "Order/SignalAgentPayV2", dictionary);
            RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);
            return requestResult;
        }


    }
}
