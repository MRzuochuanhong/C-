namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_SplitBill
    {
        public long Id { get; set; }

        public Guid BillId { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? MemberId { get; set; }

        public Guid? OrderId { get; set; }

        public Guid? PayOrderId { get; set; }

        [StringLength(50)]
        public string PayOrderCode { get; set; }

        public Guid? PayOrderApplyId { get; set; }

        public decimal PayFee { get; set; }

        public decimal? HandFee { get; set; }

        public decimal? ServiceFee { get; set; }

        public decimal? CollectFee { get; set; }

        public short InAccountType { get; set; }

        public short FromAccountType { get; set; }

        public short IsInAccount { get; set; }

        public DateTime? InAccountTime { get; set; }

        [StringLength(256)]
        public string InAccountOrderNo { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public short Status { get; set; }
    }
}
