namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_ProductSKUPrice
    {
        public int Id { get; set; }

        public Guid? ProductSKUPriceId { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? ProductId { get; set; }

        public string ProductSKUPropertyValueIds { get; set; }

        public decimal? Weight { get; set; }

        public decimal? CostPrice { get; set; }

        public int? StockAmount { get; set; }

        public int? WarnsStockAmount { get; set; }

        public int? Enable { get; set; }

        public int? Sort { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int? Status { get; set; }
    }
}
