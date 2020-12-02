namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Footmark
    {
        public int Id { get; set; }

        public Guid? FootmarkId { get; set; }

        public int? Type { get; set; }

        public Guid? RelateId { get; set; }

        public Guid? MemberId { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int? Status { get; set; }
    }
}
