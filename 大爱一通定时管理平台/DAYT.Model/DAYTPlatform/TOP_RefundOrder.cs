namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_RefundOrder
    {
        public int Id { get; set; }

        public Guid RefundOrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string RefundOrderCode { get; set; }

        public Guid? ParentId { get; set; }

        public Guid MemberId { get; set; }

        public Guid ShopId { get; set; }

        public Guid PayOrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string PayOrderCode { get; set; }

        public Guid OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderCode { get; set; }

        public int RefundType { get; set; }

        public string RefundReason { get; set; }

        public string RefundFileIds { get; set; }

        public decimal PayFee { get; set; }

        public int? PayMode { get; set; }

        [StringLength(50)]
        public string LogisticsCode { get; set; }

        [StringLength(50)]
        public string LogisticsNumber { get; set; }

        public string ReturnReason { get; set; }

        public string ReturnFileIds { get; set; }

        public decimal RefundFee { get; set; }

        public int RefundState { get; set; }

        public Guid? RefundShopUserId { get; set; }

        public DateTime? RefundTime { get; set; }

        public string SellerRemark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public int Status { get; set; }
    }
}
