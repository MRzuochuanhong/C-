namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Dictionary
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string DictName { get; set; }

        [Required]
        public string DictValue { get; set; }

        public string Description { get; set; }

        public int ParentId { get; set; }

        public int? Sort { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
