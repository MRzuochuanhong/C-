namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop_ProPropertyValueNexus
    {
        public int Id { get; set; }

        public Guid? ShopId { get; set; }

        public Guid ProPropertyValueNexusId { get; set; }

        public Guid ProductId { get; set; }

        public Guid PropertyId { get; set; }

        public Guid ProPropertyValueId { get; set; }

        public Guid ProPropertyNexusId { get; set; }

        public decimal? CostPrice { get; set; }

        public int? Enable { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
