using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.Model
{
    public class SYS_SendHistory
    {
        public int Id { get; set; }
        public System.Guid SendHistoryId { get; set; }
        public string Mobile { get; set; }
        public Nullable<System.Guid> ShopId { get; set; }
        public System.Guid TemplateId { get; set; }
        public string ValidationCode { get; set; }
        public string MsgContent { get; set; }
        public Nullable<System.DateTime> FirstSendTime { get; set; }
        public Nullable<System.DateTime> EndSendTime { get; set; }
        public Nullable<int> SendCount { get; set; }
        public Nullable<int> Validation { get; set; }
        public Nullable<int> ReusltState { get; set; }
        public string ResultMsgID { get; set; }
        public string ResultMsg { get; set; }
        public Nullable<int> ResultReserve { get; set; }
        public Nullable<int> Source { get; set; }
    }
}
