namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_TradeFrozen
    {
        public int Id { get; set; }

        public Guid FrozenId { get; set; }

        public Guid MemberId { get; set; }

        public Guid PayOrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string PayOrderCode { get; set; }

        public int AccountType { get; set; }

        public decimal FrozenAmount { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int State { get; set; }

        public int Status { get; set; }
    }
}
