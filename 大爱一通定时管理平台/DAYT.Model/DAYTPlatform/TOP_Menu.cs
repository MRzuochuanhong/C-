namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Menu
    {
        public int Id { get; set; }

        public Guid MenuId { get; set; }

        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }

        public string MenuIcon { get; set; }

        public int MenuDepth { get; set; }

        public int? MenuType { get; set; }

        public Guid? ParentId { get; set; }

        public bool? ShowInTop { get; set; }

        public bool? ShowInFoot { get; set; }

        public bool? ShowInMain { get; set; }

        public int? LinkType { get; set; }

        public string LinkToUrl { get; set; }

        public bool EnableUsed { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
