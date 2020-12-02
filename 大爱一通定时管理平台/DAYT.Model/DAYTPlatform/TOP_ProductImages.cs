namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProductImages
    {
        public int Id { get; set; }

        public Guid ProductId { get; set; }

        public Guid ImageFileId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public Guid? ThumbnailFileId { get; set; }

        public string ThumbnailUrl { get; set; }

        [Required]
        [StringLength(50)]
        public string AppTag { get; set; }

        public int IsDefault { get; set; }

        public int Sort { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
