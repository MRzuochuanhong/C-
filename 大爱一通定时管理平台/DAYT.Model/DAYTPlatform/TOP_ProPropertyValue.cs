namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProPropertyValue
    {
        public int Id { get; set; }

        public Guid ProPropertyValueId { get; set; }

        public Guid PropertyId { get; set; }

        [Required]
        [StringLength(50)]
        public string PropertyName { get; set; }

        [Required]
        public string PropertyValue { get; set; }

        public bool IsDefault { get; set; }

        public string Intro { get; set; }

        public int? Sort { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
