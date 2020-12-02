namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Distribution
    {
        public int Id { get; set; }

        public Guid DistributionId { get; set; }

        public Guid MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        public int DepositLevel { get; set; }

        public decimal DepositMoney { get; set; }

        public Guid? ParentMemberId { get; set; }

        [StringLength(50)]
        public string ParentLoginName { get; set; }

        public int PayType { get; set; }

        public int IsPay { get; set; }

        public string BankFlowCode { get; set; }

        [StringLength(200)]
        public string BuyerAccount { get; set; }

        public int State { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public int? Sources { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }
    }
}
