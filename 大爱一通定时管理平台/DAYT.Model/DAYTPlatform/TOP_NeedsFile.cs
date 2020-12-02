namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_NeedsFile
    {
        public int Id { get; set; }

        public Guid NeedsFileId { get; set; }

        public Guid NeedsId { get; set; }

        public Guid FileId { get; set; }

        [Required]
        public string FileUrl { get; set; }

        [StringLength(200)]
        public string FileTitle { get; set; }

        [StringLength(50)]
        public string FileType { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
