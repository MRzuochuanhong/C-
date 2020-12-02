namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Order
    {
        public int Id { get; set; }

        public Guid OrderId { get; set; }

        [Required]
        public string OrderCode { get; set; }

        public Guid PayOrderId { get; set; }

        [Required]
        public string PayOrderCode { get; set; }

        public Guid MemberId { get; set; }

        public Guid ShopId { get; set; }

        public string ShopName { get; set; }

        public DateTime CreateTime { get; set; }

        public decimal ProTotalPrice { get; set; }

        public decimal? DiscountFee { get; set; }

        public decimal OrderTotalFee { get; set; }

        public decimal? UrgentFee { get; set; }

        public decimal? DeliveryFee { get; set; }

        [StringLength(50)]
        public string LogisticsId { get; set; }

        public decimal? CouponFee { get; set; }

        public decimal? ChangeFee { get; set; }

        public Guid? ChangePersonId { get; set; }

        public decimal PayFee { get; set; }

        public bool IsPay { get; set; }

        public int? PayMode { get; set; }

        public DateTime? PayDate { get; set; }

        public DateTime? ConfirmTime { get; set; }

        public int State { get; set; }

        public bool IsCancel { get; set; }

        public DateTime? CancelTime { get; set; }

        public int? RefundState { get; set; }

        public string Remark { get; set; }

        public decimal? TotalWeight { get; set; }

        public bool? IsUrgent { get; set; }

        [Required]
        [StringLength(50)]
        public string Consignee { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [Required]
        public string Address { get; set; }

        public int? InvoiceObject { get; set; }

        public int? InvoiceMode { get; set; }

        public int? InvoiceType { get; set; }

        [StringLength(50)]
        public string InvoiceTitle { get; set; }

        public string InvoiceUrl { get; set; }

        public bool IsInvoice { get; set; }

        public DateTime? InvoiceDate { get; set; }

        [StringLength(50)]
        public string CreditCode { get; set; }

        public string InvoiceAddress { get; set; }

        public string InvoiceTel { get; set; }

        public string Bank { get; set; }

        public string BankAccout { get; set; }

        public DateTime? ProduceTime { get; set; }

        public DateTime? ConfirmReceiveTime { get; set; }

        public DateTime? MemberReceiveTime { get; set; }

        public bool IsSettlement { get; set; }

        public DateTime? SettlementTime { get; set; }

        [StringLength(50)]
        public string SourceName { get; set; }

        public string SourceValue { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
