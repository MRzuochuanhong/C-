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
    public class TOP_AccountBLL : BaseBLL
    {
        
        /// <summary>
        /// 获取通联个人信息
        /// </summary>
        /// <param name="memberId"></param>
        /// <returns></returns>
        public PersonalInfoModel GetPersonalInfo(string memberId)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("memberId", memberId);
            string result = WebHelper.HttpClientResultJson(AccountInterface + "Registered/GetPersonalInfo", dic);
            PersonalInfoModel requestResult = JsonConvert.DeserializeObject<PersonalInfoModel>(result);
            return requestResult;
        }
        
        public RequestResult UpdataSplitBill(string orderId, string inAccountOrderNo)
        {
            try
            {
                Dictionary<string, string> dic = new Dictionary<string, string>
                {
                    { "orderId", orderId },
                    { "inAccountOrderNo", inAccountOrderNo }
                };
                string result = WebHelper.HttpClientResultJson(AccountInterface + "Registered/UpdataSplitBill", dic);
                return JsonConvert.DeserializeObject<RequestResult>(result);
            }
            catch
            {
                return null;
            }
        }
    }
}
