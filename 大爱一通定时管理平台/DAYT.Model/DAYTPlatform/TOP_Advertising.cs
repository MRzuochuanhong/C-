namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Advertising
    {
        public int Id { get; set; }

        public Guid AdvertisingId { get; set; }

        public int AdvertisingType { get; set; }

        public int AdvertisingDepth { get; set; }

        [Required]
        [StringLength(100)]
        public string AdvertisingTitle { get; set; }

        public string ImageUrl { get; set; }

        public string AdvertisingUrl { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
