namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_TLPayOrderApply
    {
        public long Id { get; set; }

        public Guid ApplyId { get; set; }

        public Guid PayOrderId { get; set; }

        [Required]
        [StringLength(256)]
        public string TLOrderId { get; set; }

        public short ApplyType { get; set; }

        public short State { get; set; }

        public DateTime CreateTime { get; set; }

        public short Status { get; set; }
    }
}
