namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProClass
    {
        public int Id { get; set; }

        public Guid ClassId { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        public Guid? ParentId { get; set; }

        public Guid? RootId { get; set; }

        public int ClassDepth { get; set; }

        [Required]
        public string ClassCode { get; set; }

        [Required]
        public string ClassPath { get; set; }

        public string ClassIcons { get; set; }

        public int Sort { get; set; }

        [StringLength(500)]
        public string PayType { get; set; }

        public string SEOTitle { get; set; }

        public string SEOKeywords { get; set; }

        public string SEODescription { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public decimal? DeductionPoints { get; set; }
    }
}
