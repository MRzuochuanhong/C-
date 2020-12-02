namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_AreaMapping
    {
        public int Id { get; set; }

        public Guid? RegionId { get; set; }

        [StringLength(50)]
        public string AreaId { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public int? Status { get; set; }
    }
}
