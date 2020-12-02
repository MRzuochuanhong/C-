namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProProperty
    {
        public int Id { get; set; }

        public Guid PropertyId { get; set; }

        [Required]
        [StringLength(50)]
        public string PropertyName { get; set; }

        public int SelectionMethod { get; set; }

        public int PriceMethod { get; set; }

        public int? StepNum { get; set; }

        public int? MinValue { get; set; }

        public int? MaxValue { get; set; }

        public Guid? FollowId { get; set; }

        public int? Threshold { get; set; }

        public string PropertyIntro { get; set; }

        public int? Sort { get; set; }

        public bool? EnableDefine { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
