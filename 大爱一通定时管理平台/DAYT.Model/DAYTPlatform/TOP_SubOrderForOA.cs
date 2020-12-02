namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_SubOrderForOA
    {
        public int Id { get; set; }

        public Guid SubOrderId { get; set; }

        [Required]
        public string SubOrderCode { get; set; }

        public Guid OrderId { get; set; }

        [Required]
        public string OrderCode { get; set; }

        public Guid ClassId { get; set; }

        public Guid RootClassId { get; set; }

        public Guid ShopId { get; set; }

        [Required]
        public string ShopName { get; set; }

        public Guid ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductCode { get; set; }

        public string ProductThumbnail { get; set; }

        public Guid? StandardId { get; set; }

        [StringLength(50)]
        public string StandardName { get; set; }

        public decimal Length { get; set; }

        public decimal Width { get; set; }

        public decimal Blank { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Acreage { get; set; }

        public decimal? Weight { get; set; }

        public int PriceType { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal UnitPrice { get; set; }

        public int Count { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? LinePrice { get; set; }

        public decimal? DiscountRate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? DiscountFee { get; set; }

        public decimal? LinePayFee { get; set; }

        public string BackProcessIds { get; set; }

        public string BackProcess { get; set; }

        public bool IsUrgent { get; set; }

        public string Remark { get; set; }

        public bool NeedUpload { get; set; }

        public int ProductionsState { get; set; }

        [StringLength(50)]
        public string LogisticsCode { get; set; }

        [StringLength(50)]
        public string LogisticsNumber { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public decimal DeductionPoints { get; set; }
    }
}
