namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Coupon
    {
        public int Id { get; set; }

        public Guid CouponsId { get; set; }

        [Required]
        [StringLength(100)]
        public string CouponsName { get; set; }

        public int CouponsClass { get; set; }

        public int CouponsProductClass { get; set; }

        public int CouponsType { get; set; }

        public string Remark { get; set; }

        public Guid? CreateUserId { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int Status { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }
    }
}
