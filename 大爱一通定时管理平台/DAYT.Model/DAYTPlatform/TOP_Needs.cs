namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Needs
    {
        public int Id { get; set; }

        public Guid NeedsId { get; set; }

        public Guid MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string NeedsName { get; set; }

        [Required]
        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string OtherContact { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string NeedsTitle { get; set; }

        [StringLength(500)]
        public string NeedsContent { get; set; }

        public int? IsAudit { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
