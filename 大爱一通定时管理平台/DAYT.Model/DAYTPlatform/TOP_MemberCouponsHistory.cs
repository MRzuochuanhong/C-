namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MemberCouponsHistory
    {
        public int Id { get; set; }

        public Guid MemberCouponsHistoryId { get; set; }

        public Guid MemberCouponsId { get; set; }

        public Guid CouponsId { get; set; }

        [Required]
        [StringLength(100)]
        public string CouponsName { get; set; }

        public Guid MemberId { get; set; }

        public Guid OrderId { get; set; }

        [Required]
        public string OrderCode { get; set; }

        public decimal? ReduceConditionNum { get; set; }

        public decimal? ReduceNum { get; set; }

        public int CouponsUsedCount { get; set; }

        public int CouponsRemainCount { get; set; }

        public decimal? CouponsFee { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int Status { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }

        public string Extend4 { get; set; }

        public string Extend5 { get; set; }
    }
}
