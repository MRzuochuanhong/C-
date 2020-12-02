using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.WebCommon
{
    public class LogHelper
    {
        public static string LogDataInterface = ConfigurationManager.AppSettings["LogDataInterface"].ToString();//读写
        #region 写入登录日志
        /// <summary>
        /// 写入登录日志
        /// </summary>
        /// <param name="LogType">日志类型（Login，Logout）</param>
        /// <param name="LoginSource">登录设备类型（PC浏览器、PC端Client、微信、APP）</param>
        /// <param name="UserId">用户Id</param>
        /// <param name="UserAccount">用户账号</param>
        /// <param name="UserIdentity">用户身份（Admin、ShopUser、Member）</param>
        /// <param name="Remark">备注</param>
        public static async Task AddLoginLog(string LogType, string LoginSource, Guid UserId, string UserAccount, string UserIdentity, string Remark)
        {
            string ClientIP = WebUtility.GetIPAddress();
            await Task.Run(() =>
            {
                string ClientAddress = WebUtility.GetClientIPAddressInfoByAmap(ClientIP);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("LogType", LogType);
                dic.Add("LoginSource", LoginSource);
                dic.Add("UserId", UserId.ToString());
                dic.Add("UserAccount", UserAccount);
                dic.Add("UserIdentity", UserIdentity);
                dic.Add("ClientIP", ClientIP);
                dic.Add("ClientAddress", ClientAddress);
                dic.Add("Remark", Remark);
                WebHelper.HttpClientResultJson(LogDataInterface + "LoginLog/AddAdminLoginLog", dic);
            });
        }
        #endregion

        #region 写入平台操作日志
        /// <summary>
        /// 写入平台操作日志
        /// </summary>
        /// <param name="LogType">日志类型（Insert，Update，Delete，Download，Upload）</param>
        /// <param name="UserId">用户Id</param>
        /// <param name="UserAccount">用户账号</param>
        /// <param name="TableName">操作的数据表/存储过程名称</param>
        /// <param name="KeyNumber">关键编号（可为ID、订单编号、账单编号等，批量操作时用“；”隔开）</param>
        /// <param name="Remark">备注</param>
        /// <returns></returns>
        public static async Task AddTOP_OperateLog(LogType type, Guid UserId, string UserAccount, string TableName, string KeyNumber, string Remark)
        {
            string ClientIP = WebUtility.GetIPAddress();
            await Task.Run(() =>
            {
                string ClientAddress = WebUtility.GetClientIPAddressInfoByAmap(ClientIP);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("LogType", type.ToString());
                dic.Add("UserId", UserId.ToString());
                dic.Add("UserAccount", UserAccount);
                dic.Add("ClientIP", ClientIP);
                dic.Add("ClientAddress", ClientAddress);
                dic.Add("TableName", TableName);
                dic.Add("KeyNumber", KeyNumber);
                dic.Add("Remark", Remark);
                WebHelper.HttpClientResultJson(LogDataInterface + "OperateLog/AddTOP_OperateLog", dic);
            });
        }
        #endregion

        #region 平台会员操作日志
        /// <summary>
        /// 平台会员操作日志
        /// </summary>
        /// <param name="type">日志类型</param>
        /// <param name="MemberId">用户id</param>
        /// <param name="LoginName">用户登录名</param>
        /// <param name="TableName">操作的数据表/存储过程名称</param>
        /// <param name="KeyNumber">关键编号（可为ID、订单编号、账单编号等，批量操作时用“；”隔开）</param>
        /// <param name="Remark">备注</param>
        /// <returns></returns>
        public static async Task AddTOP_MemberOperateLog(LogType type, Guid? MemberId, string LoginName, string TableName, string KeyNumber, string Remark)
        {
            string ClientIP = "";
            await Task.Run(() =>
            {
                string ClientAddress = "";
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("LogType", type.ToString());
                dic.Add("MemberId", MemberId.ToString());
                dic.Add("LoginName", LoginName);
                dic.Add("ClientIP", ClientIP);
                dic.Add("ClientAddress", ClientAddress);
                dic.Add("TableName", TableName);
                dic.Add("KeyNumber", KeyNumber);
                dic.Add("Remark", Remark);
                WebHelper.HttpClientResultJson(LogDataInterface + "MemberOperateLog/AddTOP_MemberOperateLog", dic);
            });
        }

        #endregion

        #region 店铺操作日志
        /// <summary>
        /// 店铺操作日志
        /// </summary>
        /// <param name="LogType">日志类型（Insert，Update，Delete，Download，Upload）</param>
        /// <param name="UserId">用户Id</param>
        /// <param name="UserAccount">用户账号</param>
        /// <param name="TableName">操作的数据表/存储过程名称</param>
        /// <param name="KeyNumber">关键编号（可为ID、订单编号、账单编号等，批量操作时用“；”隔开）</param>
        /// <param name="Remark">备注</param>
        /// <returns></returns>
        public static async Task AddTOP_ShopOperateLog(LogType type, Guid UserId, string UserAccount, string TableName, string KeyNumber, string Remark)
        {
            string ClientIP = WebUtility.GetIPAddress();
            await Task.Run(() =>
            {
                string ClientAddress = WebUtility.GetClientIPAddressInfoByAmap(ClientIP);
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("LogType", type.ToString());
                dic.Add("UserId", UserId.ToString());
                dic.Add("UserAccount", UserAccount);
                dic.Add("ClientIP", ClientIP);
                dic.Add("ClientAddress", ClientAddress);
                dic.Add("TableName", TableName);
                dic.Add("KeyNumber", KeyNumber);
                dic.Add("Remark", Remark);
                WebHelper.HttpClientResultJson(LogDataInterface + "ShopOperateLog/AddTOP_ShopOperateLog", dic);
            });
        }
        #endregion

        #region 写入通联接口操作日志
        /// <summary>
        /// 写入通联接口操作日志
        /// </summary>
        /// <param name="interfaceName">接口名称</param>
        /// <param name="strParam">接口详情</param>
        /// <param name="interfaceType">接口请求类型 1请求，2返回，3异步返回</param>
        /// <returns></returns>
        public static async Task AddTLInterface(string interfaceName, string strParam, int interfaceType)
        {
            await Task.Run(() =>
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("interfaceName", interfaceName);
                dic.Add("strParam", strParam);
                dic.Add("interfaceType", interfaceType.ToString());
                WebHelper.HttpClientResultJson(LogDataInterface + "TLInterface/AddTLInterface", dic);
            });
        }
        #endregion

    }

    #region 日志类型
    /// <summary>
    /// 日志类型
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// 增加
        /// </summary>
        [Description("增加")]
        Insert,

        /// <summary>
        /// 修改
        /// </summary>
        [Description("修改")]
        Update,

        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        Delete,

        /// <summary>
        /// 下载
        /// </summary>
        [Description("下载")]
        Download,

        /// <summary>
        /// 上传
        /// </summary>
        [Description("上传")]
        Upload,

        /// <summary>
        /// 批量下架
        /// </summary>
        [Description("批量下架")]
        BatchOff,

        /// <summary>
        /// 批量上架
        /// </summary>
        [Description("批量上架")]
        BatchShelves,

        /// <summary>
        /// 批量更改状态(批量删除)
        /// </summary>
        [Description("批量更改状态")]
        BatchStatus,

        /// <summary>
        /// 批量添加/修改
        /// </summary>
        [Description("批量添加/修改")]
        BatchUpdate,
    }

    #endregion
}
