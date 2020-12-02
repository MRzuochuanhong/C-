namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Article
    {
        public int Id { get; set; }

        public Guid ArticleId { get; set; }

        public Guid MenuId { get; set; }

        [Required]
        [StringLength(50)]
        public string ArticleTitle { get; set; }

        [StringLength(200)]
        public string ArticleSubTitle { get; set; }

        public string ArticleContent { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        public bool IsTop { get; set; }

        public string ArticleUrl { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbnailUrl { get; set; }

        public bool PassAudit { get; set; }

        public int Sort { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
