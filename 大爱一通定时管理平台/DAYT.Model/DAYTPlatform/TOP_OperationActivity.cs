namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_OperationActivity
    {
        public int Id { get; set; }

        public Guid OperationActivityId { get; set; }

        [Required]
        [StringLength(15)]
        public string Phone { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(20)]
        public string ActivityName { get; set; }

        [Required]
        [StringLength(32)]
        public string City { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
