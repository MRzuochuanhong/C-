namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_ShopCSInfo
    {
        public int Id { get; set; }

        public Guid? ShopId { get; set; }

        public string WorkTime { get; set; }

        [StringLength(50)]
        public string QQ { get; set; }

        public string IM { get; set; }

        public string Remark { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int? Status { get; set; }
    }
}
