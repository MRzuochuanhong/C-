namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Units
    {
        public int Id { get; set; }

        public Guid UnitId { get; set; }

        [Required]
        [StringLength(50)]
        public string UnitName { get; set; }

        public int Status { get; set; }
    }
}
