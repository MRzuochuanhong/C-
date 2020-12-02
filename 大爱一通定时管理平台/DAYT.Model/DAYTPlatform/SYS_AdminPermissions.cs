namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_AdminPermissions
    {
        [Key]
        public int PermissionsId { get; set; }

        [Required]
        [StringLength(50)]
        public string PermissionsName { get; set; }

        [StringLength(50)]
        public string PermissionsValue { get; set; }

        public int ParentId { get; set; }

        public int Status { get; set; }
    }
}
