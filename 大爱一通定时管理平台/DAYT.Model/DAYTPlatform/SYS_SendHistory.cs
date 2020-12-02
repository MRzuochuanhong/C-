namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SendHistory
    {
        public int Id { get; set; }

        public Guid SendHistoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        public Guid? ShopId { get; set; }

        public Guid TemplateId { get; set; }

        [StringLength(50)]
        public string ValidationCode { get; set; }

        [StringLength(5000)]
        public string MsgContent { get; set; }

        public DateTime? FirstSendTime { get; set; }

        public DateTime? EndSendTime { get; set; }

        public int? SendCount { get; set; }

        public int? Validation { get; set; }

        public int? ReusltState { get; set; }

        [StringLength(50)]
        public string ResultMsgID { get; set; }

        [StringLength(500)]
        public string ResultMsg { get; set; }

        public int? ResultReserve { get; set; }

        public int? Source { get; set; }
    }
}
