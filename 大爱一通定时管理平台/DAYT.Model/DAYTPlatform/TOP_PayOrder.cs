namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_PayOrder
    {
        public int Id { get; set; }

        public Guid PayOrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string PayOrderCode { get; set; }

        public Guid ParentId { get; set; }

        public int OrderType { get; set; }

        public Guid MemberId { get; set; }

        public string OrderIds { get; set; }

        public int? ProductNum { get; set; }

        public decimal TotalPrice { get; set; }

        public decimal PayFee { get; set; }

        public DateTime CreateTime { get; set; }

        public bool IsPay { get; set; }

        public int? PayMode { get; set; }

        public DateTime? PayDate { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
