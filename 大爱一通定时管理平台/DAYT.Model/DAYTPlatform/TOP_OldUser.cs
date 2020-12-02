namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_OldUser
    {
        public int Id { get; set; }

        public int OldId { get; set; }

        [Required]
        [StringLength(50)]
        public string LoginName { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        public int Sex { get; set; }

        [StringLength(20)]
        public string IDCardNo { get; set; }

        public DateTime Birthday { get; set; }

        [StringLength(50)]
        public string PayPassword { get; set; }

        [StringLength(20)]
        public string UserType { get; set; }

        public int UserTypeID { get; set; }

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
        public string ProvinceID { get; set; }

        [StringLength(10)]
        public string CityID { get; set; }

        [StringLength(10)]
        public string DistrictID { get; set; }

        [StringLength(50)]
        public string Privince { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        public int? Source { get; set; }

        [StringLength(100)]
        public string SourceInfo { get; set; }

        public DateTime CreateTime { get; set; }

        public int Status { get; set; }
    }
}
