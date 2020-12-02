namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ShopProductClass
    {
        public int Id { get; set; }

        public Guid ShopId { get; set; }

        public Guid ProductClassId { get; set; }

        public decimal Capacity { get; set; }

        public bool IsValid { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public decimal? DeductionPoints { get; set; }
    }
}
