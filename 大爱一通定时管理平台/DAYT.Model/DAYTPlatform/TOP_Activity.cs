namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Activity
    {
        public int Id { get; set; }

        public Guid ActivityId { get; set; }

        [Required]
        [StringLength(20)]
        public string ActivityName { get; set; }

        [Required]
        [StringLength(255)]
        public string ActivityUrl { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public DateTime CreateTime { get; set; }

        public int Status { get; set; }
    }
}
