namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_Product
    {
        public int Id { get; set; }

        public Guid? ShopId { get; set; }

        public Guid ProductId { get; set; }

        public Guid ClassId { get; set; }

        [Required]
        public string ProductName { get; set; }

        public string ProductSubName { get; set; }

        public bool OnSell { get; set; }

        public int SellType { get; set; }

        public decimal? SellPrice { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public string ImageUrlMt { get; set; }

        public string ThumbnailUrlMt { get; set; }

        public string ProductIntro { get; set; }

        public string ProductIntroMt { get; set; }

        public string DeliveryInstruction { get; set; }

        public string Announcements { get; set; }

        public int Hits { get; set; }

        public int SalesVolume { get; set; }

        public int StockAmount { get; set; }

        public int? WarnsStockAmount { get; set; }

        public decimal? TaxRate { get; set; }

        public int ProcessingCycle { get; set; }

        public bool AllowHurry { get; set; }

        public bool NeedUpload { get; set; }

        public string FileUploadType { get; set; }

        public int Sort { get; set; }

        public int? DSR { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
