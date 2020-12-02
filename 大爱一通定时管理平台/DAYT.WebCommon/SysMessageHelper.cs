using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.WebCommon
{
    /// <summary>
    /// 系统消息处理类
    /// </summary>
    public class SysMessageHelper
    {
        public static string BasicInformationface = ConfigurationManager.AppSettings["BasicInformationface"].ToString();

        /// <summary>
        /// 异步发送系统消息
        /// </summary>
        /// <param name="title">主标题</param>
        /// <param name="subTitle">副标题</param>
        /// <param name="content">正文</param>
        /// <param name="stickyPost">是否置顶（1：置顶，0：不置顶）</param>
        /// <param name="receiverId">接收人Id</param>
        /// <param name="userId">发送人Id,系统操作传值00000000-0000-0000-0000-000000000000</param>
        /// <returns></returns>
        public static void AsyncSendSysMessage(string title, string subTitle, string content, int stickyPost, Guid receiverId, Guid userId)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("title", title);
            dic.Add("subTitle", subTitle);
            dic.Add("content", content);
            dic.Add("stickyPost", stickyPost.ToString());
            dic.Add("receiverId", receiverId.ToString());
            dic.Add("userId", userId.ToString());
            WebHelper.HttpClientResultJson(BasicInformationface + "TOP_SysMessage/SendSysMessage", dic);
        }
    }
}
