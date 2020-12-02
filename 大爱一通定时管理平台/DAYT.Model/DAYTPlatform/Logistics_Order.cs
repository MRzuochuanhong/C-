namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Logistics_Order
    {
        public int Id { get; set; }

        [Required]
        [StringLength(64)]
        public string LogisticsID { get; set; }

        [StringLength(50)]
        public string LogisticsCode { get; set; }

        [StringLength(50)]
        public string LogisticsCompanyName { get; set; }

        [StringLength(50)]
        public string LogisticsNumber { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public int? LogisticsMode { get; set; }

        [StringLength(50)]
        public string LogisticsConsignee { get; set; }

        [StringLength(50)]
        public string LogisticsMobile { get; set; }
    }
}
