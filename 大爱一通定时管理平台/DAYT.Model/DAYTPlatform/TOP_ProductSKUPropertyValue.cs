namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProductSKUPropertyValue
    {
        public int Id { get; set; }

        public Guid ProductSKUPropertyValueId { get; set; }

        public Guid ProductId { get; set; }

        public Guid ProductSKUPropertyId { get; set; }

        public Guid SKUPropertyId { get; set; }

        [Required]
        [StringLength(50)]
        public string ProductSKUPropertyValueName { get; set; }

        [StringLength(200)]
        public string Intro { get; set; }

        public int Sort { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
