namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Message
    {
        public int Id { get; set; }

        public Guid? MessageId { get; set; }

        [StringLength(500)]
        public string Title { get; set; }

        [StringLength(500)]
        public string SubTitle { get; set; }

        public string Content { get; set; }

        public int? StickyPost { get; set; }

        public int? IsPublish { get; set; }

        public int? Sort { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? CreateUserId { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int? Status { get; set; }
    }
}
