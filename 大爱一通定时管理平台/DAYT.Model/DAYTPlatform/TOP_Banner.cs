namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Banner
    {
        public int Id { get; set; }

        public Guid BannerId { get; set; }

        [StringLength(200)]
        public string BannerTitel { get; set; }

        [StringLength(500)]
        public string BannerSubTitle { get; set; }

        public string BannerImageUrl { get; set; }

        [StringLength(500)]
        public string LinkUrl { get; set; }

        public int BannerType { get; set; }

        public int BannerArea { get; set; }

        public int Sort { get; set; }

        public Guid? ShopId { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public int? IsDelete { get; set; }
    }
}
