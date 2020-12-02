namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Brand
    {
        public int Id { get; set; }

        public Guid BrandId { get; set; }

        [StringLength(50)]
        public string BrandName { get; set; }

        public string BrandLogo { get; set; }

        public string BrandIntro { get; set; }

        [StringLength(200)]
        public string BrandWebsite { get; set; }

        public int Sort { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
