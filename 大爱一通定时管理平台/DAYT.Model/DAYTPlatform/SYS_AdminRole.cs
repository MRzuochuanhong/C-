namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_AdminRole
    {
        public int Id { get; set; }

        public Guid RoleId { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        public string RolePermissions { get; set; }

        public string RoleRemark { get; set; }

        public int Status { get; set; }
    }
}
