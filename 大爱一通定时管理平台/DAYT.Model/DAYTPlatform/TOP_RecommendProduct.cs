namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_RecommendProduct
    {
        public int Id { get; set; }

        public Guid RecommendId { get; set; }

        public Guid ProductId { get; set; }

        public Guid RootClassId { get; set; }

        public Guid ShopId { get; set; }

        public int? Sort { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
