namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MemberInvoice
    {
        public int Id { get; set; }

        public Guid MemberInvoiceId { get; set; }

        public Guid MemberId { get; set; }

        public int InvoiceType { get; set; }

        [Required]
        [StringLength(200)]
        public string InvoiceHead { get; set; }

        [StringLength(100)]
        public string Identification { get; set; }

        [StringLength(50)]
        public string ProvinceId { get; set; }

        [StringLength(50)]
        public string Province { get; set; }

        [StringLength(50)]
        public string CityId { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string DistrictId { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string StreetId { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        [StringLength(50)]
        public string CardNumber { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        public Guid? PreviousId { get; set; }

        public int? IsReview { get; set; }

        public DateTime CreateTime { get; set; }

        public Guid LastUpdateUserId { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
