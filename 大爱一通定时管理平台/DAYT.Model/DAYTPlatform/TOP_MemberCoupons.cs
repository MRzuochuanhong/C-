namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MemberCoupons
    {
        public int Id { get; set; }

        public Guid MemberCouponsId { get; set; }

        public Guid MemberId { get; set; }

        public Guid SubCouponId { get; set; }

        public Guid CouponId { get; set; }

        [Required]
        [StringLength(100)]
        public string CouponsName { get; set; }

        public int CouponsClass { get; set; }

        public int CouponsProductClass { get; set; }

        public int CouponsType { get; set; }

        public decimal ReduceConditionNum { get; set; }

        public decimal ReduceCashNum { get; set; }

        public int CouponsCount { get; set; }

        public int AvailableCount { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int DrawCondition { get; set; }

        public int UseCondition { get; set; }

        public string Remark { get; set; }

        public int State { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }
    }
}
