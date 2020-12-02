namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Menu
    {
        public int Id { get; set; }

        public Guid MenuId { get; set; }

        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }

        public Guid ParentId { get; set; }

        public string MenuLinkUrl { get; set; }

        public string MenuIcons { get; set; }

        public int? MenuDepth { get; set; }

        public string MenuCode { get; set; }

        public string MenuPath { get; set; }

        public bool IsLeaf { get; set; }

        public int Sort { get; set; }

        [Required]
        [StringLength(50)]
        public string Permissions { get; set; }

        public int Status { get; set; }
    }
}
