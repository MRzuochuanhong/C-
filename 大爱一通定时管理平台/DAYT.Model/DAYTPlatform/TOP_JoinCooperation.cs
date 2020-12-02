namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_JoinCooperation
    {
        public int Id { get; set; }

        public Guid JoinCooperationId { get; set; }

        public Guid MemberId { get; set; }

        public int JoinCooperationType { get; set; }

        [Required]
        [StringLength(100)]
        public string BusinessLicense { get; set; }

        [Required]
        [StringLength(50)]
        public string LinkMobile { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyType { get; set; }

        [Required]
        [StringLength(200)]
        public string RegisteredAddress { get; set; }

        [Required]
        [StringLength(200)]
        public string BusinessAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string LegalPerson { get; set; }

        public int RegisteredCapital { get; set; }

        [Required]
        public string BusinessLicenseUrl { get; set; }

        [StringLength(50)]
        public string InvitationCode { get; set; }

        public DateTime CreateTime { get; set; }

        public int State { get; set; }

        [StringLength(200)]
        public string AuditFailureType { get; set; }

        [StringLength(200)]
        public string AuditFailureRemark { get; set; }

        public int Status { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }
    }
}
