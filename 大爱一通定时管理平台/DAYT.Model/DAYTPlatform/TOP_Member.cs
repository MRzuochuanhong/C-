namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Member
    {
        public int Id { get; set; }

        public Guid MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(500)]
        public string CompanyName { get; set; }

        public int Sex { get; set; }

        [StringLength(20)]
        public string IdCardNo { get; set; }

        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string PayPassword { get; set; }

        public decimal? Balance { get; set; }

        public decimal? SpecialBalance { get; set; }

        public int Integral { get; set; }

        public int IntegralBalance { get; set; }

        public decimal? CreditQuota { get; set; }

        public decimal? CreditBalance { get; set; }

        public int? CreditPeriod { get; set; }

        public int? CreditLevel { get; set; }

        public DateTime? NextBillDate { get; set; }

        public int? MemberLevel { get; set; }

        public int? PlatformLevel { get; set; }

        public double? MemberScore { get; set; }

        [StringLength(500)]
        public string Email { get; set; }

        [StringLength(20)]
        public string QQ { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Mobile { get; set; }

        public string Address { get; set; }

        public string PhotoUrl { get; set; }

        [StringLength(50)]
        public string Contact { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        [StringLength(50)]
        public string LegalPerson { get; set; }

        [StringLength(20)]
        public string CreditCode { get; set; }

        public string BusinessLicenseUrl { get; set; }

        public int? RegisteredCapital { get; set; }

        [StringLength(10)]
        public string ProvinceId { get; set; }

        [StringLength(10)]
        public string CityId { get; set; }

        [StringLength(10)]
        public string DistrictId { get; set; }

        [StringLength(10)]
        public string StreetId { get; set; }

        [StringLength(50)]
        public string Privince { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string InvitationCode { get; set; }

        public Guid? InviterId { get; set; }

        public int? Sort { get; set; }

        public int? LoginCount { get; set; }

        [StringLength(50)]
        public string LastLoginIP { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public bool EnableUsed { get; set; }

        public int? SourceId { get; set; }

        [StringLength(50)]
        public string SourceInfo { get; set; }

        public int Status { get; set; }
    }
}
