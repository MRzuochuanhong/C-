namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_DistributionBill
    {
        public int Id { get; set; }

        public Guid DistributionBillId { get; set; }

        public Guid MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        public int DistributionType { get; set; }

        public decimal DistributionMoney { get; set; }

        [Required]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }
    }
}
