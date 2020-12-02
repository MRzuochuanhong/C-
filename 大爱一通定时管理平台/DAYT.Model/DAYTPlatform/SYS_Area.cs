namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Area
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string AreaId { get; set; }

        [StringLength(50)]
        public string AreaName { get; set; }

        [StringLength(50)]
        public string ParentId { get; set; }

        [StringLength(50)]
        public string ShortName { get; set; }

        public int? LevelType { get; set; }

        [StringLength(50)]
        public string CityCode { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        public string MergerName { get; set; }

        [StringLength(50)]
        public string Longitude { get; set; }

        [StringLength(50)]
        public string Latitude { get; set; }

        public string Pinyin { get; set; }

        public DateTime? CreateTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public int? Status { get; set; }
    }
}
