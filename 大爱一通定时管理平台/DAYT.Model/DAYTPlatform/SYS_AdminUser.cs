namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_AdminUser
    {
        public int Id { get; set; }

        public Guid AdminId { get; set; }

        [StringLength(50)]
        public string AdminName { get; set; }

        [StringLength(50)]
        public string AdminPassword { get; set; }

        [StringLength(50)]
        public string AdminRealName { get; set; }

        [StringLength(50)]
        public string DomainAccount { get; set; }

        public Guid? AdminRoleId { get; set; }

        public string AdminRoles { get; set; }

        public string AdminRemark { get; set; }

        public bool EnableUse { get; set; }

        public bool EnableDelete { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
