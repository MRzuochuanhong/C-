namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_OrderForOA
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid OrderId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string OrderCode { get; set; }

        [Key]
        [Column(Order = 3)]
        public Guid PayOrderId { get; set; }

        [Key]
        [Column(Order = 4)]
        public string PayOrderCode { get; set; }

        [Key]
        [Column(Order = 5)]
        public Guid MemberId { get; set; }

        [Key]
        [Column(Order = 6)]
        public Guid ShopId { get; set; }

        public string ShopName { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime CreateTime { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal ProTotalPrice { get; set; }

        public decimal? DiscountFee { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal OrderTotalFee { get; set; }

        public decimal? UrgentFee { get; set; }

        public decimal? DeliveryFee { get; set; }

        [StringLength(50)]
        public string LogisticsId { get; set; }

        public decimal? CouponFee { get; set; }

        public decimal? ChangeFee { get; set; }

        public Guid? ChangePersonId { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal PayFee { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool IsPay { get; set; }

        public int? PayMode { get; set; }

        public DateTime? PayDate { get; set; }

        public DateTime? ConfirmTime { get; set; }

        [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int State { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool IsCancel { get; set; }

        public DateTime? CancelTime { get; set; }

        public int? RefundState { get; set; }

        public string Remark { get; set; }

        public decimal? TotalWeight { get; set; }

        public bool? IsUrgent { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(50)]
        public string Consignee { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(50)]
        public string Province { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(50)]
        public string City { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [Key]
        [Column(Order = 18)]
        public string Address { get; set; }

        public int? InvoiceObject { get; set; }

        public int? InvoiceMode { get; set; }

        public int? InvoiceType { get; set; }

        [StringLength(50)]
        public string InvoiceTitle { get; set; }

        public string InvoiceUrl { get; set; }

        [Key]
        [Column(Order = 19)]
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

        [Key]
        [Column(Order = 20)]
        public bool IsSettlement { get; set; }

        public DateTime? SettlementTime { get; set; }

        [StringLength(50)]
        public string SourceName { get; set; }

        public string SourceValue { get; set; }

        [Key]
        [Column(Order = 21)]
        public Guid LastUpdateUserId { get; set; }

        [Key]
        [Column(Order = 22)]
        public DateTime LastUpdateTime { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Status { get; set; }
    }
}
