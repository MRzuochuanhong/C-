namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Shop
    {
        public int Id { get; set; }

        public Guid ShopId { get; set; }

        [Required]
        [StringLength(50)]
        public string ShopName { get; set; }

        public string ShopDomain { get; set; }

        public string ShopLogo { get; set; }

        public int Sort { get; set; }

        public int? DSR { get; set; }

        [Required]
        [StringLength(50)]
        public string ProvinceId { get; set; }

        [Required]
        [StringLength(50)]
        public string Province { get; set; }

        [Required]
        [StringLength(50)]
        public string CityId { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string DistrictId { get; set; }

        [Required]
        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string StreetId { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        public string Address { get; set; }

        [Required]
        [StringLength(50)]
        public string Longitude { get; set; }

        [Required]
        [StringLength(50)]
        public string Latitude { get; set; }

        [StringLength(50)]
        public string Tel { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

        [StringLength(50)]
        public string Bank { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        [StringLength(50)]
        public string LegalPerson { get; set; }

        [StringLength(20)]
        public string CreditCode { get; set; }

        [StringLength(500)]
        public string BusinessLicenseUrl { get; set; }

        public int? RegisteredCapital { get; set; }

        public int IsDirectly { get; set; }

        public int SalesVolumeSum { get; set; }

        public int IsEnabled { get; set; }

        public string Extend1 { get; set; }

        public string Extend2 { get; set; }

        public string Extend3 { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        public int? SettlementPeriod { get; set; }

        public bool IsVirtual { get; set; }
    }
}
