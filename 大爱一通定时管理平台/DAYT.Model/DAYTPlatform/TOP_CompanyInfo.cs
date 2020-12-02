namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_CompanyInfo
    {
        public int Id { get; set; }

        public Guid CompanyId { get; set; }

        public Guid MemberId { get; set; }

        [Required]
        [StringLength(20)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string CompanyAddress { get; set; }

        public int? AuthType { get; set; }

        [StringLength(50)]
        public string UniCredit { get; set; }

        [StringLength(50)]
        public string BusinessLicense { get; set; }

        [StringLength(50)]
        public string OrganizationCode { get; set; }

        [StringLength(50)]
        public string TaxRegister { get; set; }

        [StringLength(50)]
        public string ExpLicense { get; set; }

        [StringLength(20)]
        public string Telephone { get; set; }

        [Required]
        [StringLength(20)]
        public string LegalName { get; set; }

        [Required]
        [StringLength(50)]
        public string LegalIds { get; set; }

        [Required]
        [StringLength(50)]
        public string LegalPhone { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [Required]
        [StringLength(50)]
        public string AccountNo { get; set; }

        [Required]
        [StringLength(50)]
        public string ParentBankName { get; set; }

        [StringLength(20)]
        public string BankCityNo { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        public DateTime CreateTime { get; set; }

        public int Status { get; set; }
    }
}
