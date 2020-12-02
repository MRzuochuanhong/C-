namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ProPropertyNexus
    {
        public int Id { get; set; }

        public Guid ProPropertyNexusId { get; set; }

        public Guid ProductId { get; set; }

        public Guid PropertyId { get; set; }

        [Required]
        [StringLength(50)]
        public string PropertyName { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
