using DAYT.Model;
using DAYT.WebCommon;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.BLL
{
    public class SYS_SendHistoryBLL : BaseBLL
    {
        #region  获取模板内容,并将验证码赋值给模板内容
        /// <summary>
        /// 获取模板内容
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="validationCode"></param>
        /// <returns></returns>
        public string GetTemplateContent(string templateId, string validationCode)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("templateId", templateId);
            dictionary.Add("parms", validationCode);

            string result = WebHelper.HttpClientResultJson(MemberDataInterface + "SYS_SendHistory/GetTemplateContent", dictionary);

            ObjectResult requestResult = JsonConvert.DeserializeObject<ObjectResult>(result);

            if (requestResult.Result == 1000)
            {
                return requestResult.Data.ToString();
            }

            return null;
        }

        #endregion

        #region 获取模板内容,并将验证码赋值给模板内容
        /// <summary>
        /// 传递多参数获取短信模板
        /// </summary>
        /// <param name="templateId"></param>
        /// <param name="strs">多参数短信信息，多参数以“;”分隔</param>
        /// <returns></returns>
        public string GetTemplateContentByParms(string templateId, string strs)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("templateId", templateId);
            dictionary.Add("parms", strs);

            string result = WebHelper.HttpClientResultJson(MemberDataInterface + "SYS_SendHistory/GetTemplateContentByParms", dictionary);

            ObjectResult requestResult = JsonConvert.DeserializeObject<ObjectResult>(result);

            if (requestResult.Result == 1000)
            {
                return requestResult.Data.ToString();
            }

            return null;
        }
        #endregion



        #region 获取30分钟内未验证的注册短信数据集合
        /// <summary>
        /// 获取30分钟内未验证的注册短信数据集合
        /// </summary>
        /// <param name="mobile"></param>
        /// <param name="templateId"></param>
        /// <returns></returns>
        public SYS_SendHistory GetSYS_SendHistory_Register(string mobile, string templateId)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("mobile", mobile);
            dictionary.Add("templateId", templateId);

            string result = WebHelper.HttpClientResultJson(MemberDataInterface + "SYS_SendHistory/GetSYS_SendHistory_Register", dictionary);

            SendHistoryResult requestResult = JsonConvert.DeserializeObject<SendHistoryResult>(result);

            if (requestResult.Result == 1000)
            {
                return requestResult.Data;
            }
            return null;
        }

        #endregion

        #region 验证码进行验证
        /// <summary>
        /// 验证码进行验证
        /// </summary>
        /// <param name="mobile">手机号</param>
        /// <param name="templateId">模板</param>
        /// <param name="validationCode">要验证的验证码</param>
        /// <returns></returns>
        public bool CheckValidationCode(string mobile, string templateId, string validationCode)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("mobile", mobile);
            dictionary.Add("templateId", templateId);
            dictionary.Add("validationCode", validationCode);

            string result = WebHelper.HttpClientResultJson(MemberDataInterface + "SYS_SendHistory/CheckValidationCode", dictionary);

            RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);

            if (requestResult.Result == 1000)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region 添加发送的短信数据
        /// <summary>
        /// 添加发送的短信数据
        /// </summary>
        /// <param name="mobile">手机号</param>
        /// <param name="shopId">店铺ID</param>
        /// <param name="templateId">模板ID</param>
        /// <param name="msgContent">短信信息</param>
        /// <param name="validationCode">验证码</param>
        /// <param name="validation">是否验证：1：已验证，0：未验证</param>
        /// <param name="reusltState">返回状态</param>
        /// <param name="resultMsgID">返回信息ID</param>
        /// <param name="resultMsg">返回信息</param>
        /// <param name="resultReserve"></param>
        /// <param name="source"></param>
        /// <returns></returns>
        public bool AddSYS_SendHistory(string mobile, string shopId, string templateId, string msgContent, string validationCode, string validation, string reusltState, string resultMsgID, string resultMsg, string resultReserve, int source)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("mobile", mobile);
            dictionary.Add("shopId", shopId);
            dictionary.Add("templateId", templateId);
            dictionary.Add("msgContent", msgContent);
            dictionary.Add("validationCode", validationCode);
            dictionary.Add("validation", validation);
            dictionary.Add("reusltState", reusltState);
            dictionary.Add("resultMsgID", resultMsgID);
            dictionary.Add("resultMsg", resultMsg);
            dictionary.Add("resultReserve", resultReserve);
            dictionary.Add("source", source.ToString());

            string result = WebHelper.HttpClientResultJson(MemberDataInterface + "SYS_SendHistory/AddSYS_SendHistory", dictionary);

            RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);

            if (requestResult.Result == 1000)
            {
                return true;
            }
            return false;

        }

        #endregion

        #region 更新短信
        /// <summary>
        /// 根据短信
        /// </summary>
        /// <param name="sendHistoryId">短信ID</param>
        /// <param name="reusltState">返回状态</param>
        /// <param name="resultMsgID">返回信息ID</param>
        /// <param name="resultMsg">返回信息</param>
        /// <param name="resultReserve"></param>
        /// <returns></returns>
        public bool UpdateSYS_SendHistory(string sendHistoryId, string reusltState, string resultMsgID, string resultMsg, string resultReserve)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("reusltState", reusltState);
            dictionary.Add("resultMsgID", resultMsgID);
            dictionary.Add("resultMsg", resultMsg);
            dictionary.Add("resultReserve", resultReserve);
            dictionary.Add("sendHistoryId", sendHistoryId);

            string result = WebHelper.HttpClientResultJson(MemberDataInterface + "SYS_SendHistory/UpdateSYS_SendHistory", dictionary);

            RequestResult requestResult = JsonConvert.DeserializeObject<RequestResult>(result);

            if (requestResult.Result == 1000)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region 新增发送短信记录
        public static void SendSMS(string templateId, string parms, string shopId, string mobile)
        {
            string MemberInterface = ConfigHelper.GetConfigString("MemberDataInterface");
            string BasicInterface = ConfigHelper.GetConfigString("BasicInformationface");
            string SmsContent = "";
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("templateId", templateId);
            dictionary.Add("parms", parms);
            string result = WebHelper.HttpClientResultJson(MemberInterface + "SYS_SendHistory/GetTemplateContentByParms", dictionary);
            ObjectResult objResult = JsonConvert.DeserializeObject<ObjectResult>(result);
            if (objResult.Result == 1000)
            {
                SmsContent = objResult.Data.ToString();
            }
            Dictionary<string, string> Insertdic = new Dictionary<string, string>();
            Insertdic.Add("shopId", shopId);
            Insertdic.Add("Mobile", mobile);
            Insertdic.Add("templateId", templateId);
            Insertdic.Add("SmsContent", SmsContent);
            string insertresult = WebHelper.HttpClientResultJson(BasicInterface + "SendSMS/CreateSMSRecord", Insertdic);
        }
        #endregion
    }
}
