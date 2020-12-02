using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.Model
{
    public class RequestResult
    {
        public int Result { get; set; }
        public string Msg { get; set; }
    }

    /// <summary>
    /// 分页数据请求返回基类
    /// </summary>
    public class PageResult : RequestResult
    {
        public int TotalCount { get; set; }
        public int PageCount { get; set; }
    }
    public class ObjectResult : RequestResult
    {
        public object Data { get; set; }
    }
    public class SendHistoryResult : RequestResult
    {
        public SYS_SendHistory Data { get; set; }
    }
}
