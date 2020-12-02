namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ShoppingCart
    {
        public int Id { get; set; }

        public Guid ShoppingCartId { get; set; }

        public Guid MemberId { get; set; }

        public Guid ShopId { get; set; }

        public Guid ProductId { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductCode { get; set; }

        public string ProThumbnailUrl { get; set; }

        public decimal ProductPrice { get; set; }

        public decimal UnitPrice { get; set; }

        public Guid? ClassId { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public int BuyCount { get; set; }

        public int PriceType { get; set; }

        public decimal? Length { get; set; }

        public decimal? Width { get; set; }

        public decimal? Blank { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Acreage { get; set; }

        public decimal? Weight { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? LinePrice { get; set; }

        public Guid? SKUId { get; set; }

        [StringLength(50)]
        public string SKUName { get; set; }

        public string BackProcessIds { get; set; }

        public string BackProcess { get; set; }

        public Guid? FileId { get; set; }

        public string FileUrl { get; set; }

        public string FileThumbnailUrl { get; set; }

        public string TOPPayMethods { get; set; }

        public int StockNum { get; set; }

        public bool AllowHurry { get; set; }

        public bool IsHurry { get; set; }

        public decimal UrgentFee { get; set; }

        public int State { get; set; }

        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public int? IsFlagShipShop { get; set; }

        [StringLength(50)]
        public string CityId { get; set; }

        public decimal? PriceRatio { get; set; }
    }
}
