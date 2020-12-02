namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_SubCoupon
    {
        public int Id { get; set; }

        public Guid SubCouponsId { get; set; }

        public Guid CouponsId { get; set; }

        public int Source { get; set; }

        public decimal? CouponsTypeConditionNum { get; set; }

        public decimal? CouponsTypeReduce { get; set; }

        public int? CouponsCount { get; set; }

        public int? CouponsRemainCount { get; set; }

        public int TermRule { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int EffectiveCondition { get; set; }

        public int? EffectiveDay { get; set; }

        public int DrawCondition { get; set; }

        public int? LimitCount { get; set; }

        public int UseCondition { get; set; }

        public string Remark { get; set; }

        public Guid? CreateUserId { get; set; }

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
