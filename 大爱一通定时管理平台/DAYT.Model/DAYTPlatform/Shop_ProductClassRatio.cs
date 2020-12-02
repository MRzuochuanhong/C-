namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_ProductClassRatio
    {
        public int Id { get; set; }

        public Guid? ClassRatioId { get; set; }

        [StringLength(50)]
        public string CityId { get; set; }

        public Guid? ShopId { get; set; }

        public Guid? ClassId { get; set; }

        public decimal? PriceRatio { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int? Status { get; set; }
    }
}
