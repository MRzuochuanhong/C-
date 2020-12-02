namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_BankCard
    {
        public int Id { get; set; }

        public Guid CardId { get; set; }

        public Guid MemberId { get; set; }

        [Required]
        [StringLength(50)]
        public string CardNo { get; set; }

        [Required]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        public bool? IsSafeCard { get; set; }

        [StringLength(30)]
        public string Validate { get; set; }

        [StringLength(20)]
        public string CVV2 { get; set; }

        public int CardType { get; set; }

        [StringLength(20)]
        public string BankCode { get; set; }

        [StringLength(20)]
        public string BankName { get; set; }

        public DateTime CreateTime { get; set; }

        public bool Status { get; set; }
    }
}
