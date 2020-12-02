namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_AuthAccount
    {
        public int Id { get; set; }

        public Guid? LoginAccountId { get; set; }

        [StringLength(50)]
        public string OpenId { get; set; }

        [StringLength(50)]
        public string PlatformId { get; set; }

        [StringLength(50)]
        public string PlatformCode { get; set; }

        public int? Subscribe { get; set; }

        [StringLength(5000)]
        public string NickName { get; set; }

        public string UserInfo { get; set; }

        public Guid? MemberId { get; set; }

        public int? BindState { get; set; }

        [StringLength(50)]
        public string Source { get; set; }

        public DateTime? CreateTime { get; set; }

        public Guid? LastUpdateUser { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int? Status { get; set; }
    }
}
