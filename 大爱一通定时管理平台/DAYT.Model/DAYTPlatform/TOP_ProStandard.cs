namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProStandard
    {
        public int Id { get; set; }

        public Guid StandardId { get; set; }

        public Guid ProductId { get; set; }

        [StringLength(50)]
        public string StandardName { get; set; }

        public string StandardIntro { get; set; }

        public decimal? Price { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
