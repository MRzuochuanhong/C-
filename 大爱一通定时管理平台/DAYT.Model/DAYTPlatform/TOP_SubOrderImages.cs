namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_SubOrderImages
    {
        public int Id { get; set; }

        public Guid SubOrderImagesId { get; set; }

        public Guid OrderId { get; set; }

        [Required]
        public string OrderCode { get; set; }

        public Guid SubOrderId { get; set; }

        [Required]
        public string SubOrderCode { get; set; }

        public Guid ImageUrlFileId { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public Guid ThumbnailFileId { get; set; }

        [Required]
        public string ThumbnailUrl { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
