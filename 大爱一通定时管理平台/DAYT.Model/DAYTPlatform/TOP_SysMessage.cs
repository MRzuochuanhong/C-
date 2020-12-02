namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_SysMessage
    {
        public int Id { get; set; }

        public Guid? MessageId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string SubTitle { get; set; }

        public string Content { get; set; }

        public int? StickyPost { get; set; }

        public DateTime? SendTime { get; set; }

        public int? SendState { get; set; }

        public Guid? ReceiverId { get; set; }

        public int? NeedRead { get; set; }

        public DateTime? ReadTime { get; set; }

        public Guid? CreateUserId { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Status { get; set; }
    }
}
