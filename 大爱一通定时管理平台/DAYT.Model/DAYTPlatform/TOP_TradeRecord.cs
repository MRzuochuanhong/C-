namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_TradeRecord
    {
        public int Id { get; set; }

        public Guid TradeId { get; set; }

        public decimal TradeAmount { get; set; }

        public int TradeType { get; set; }

        public Guid MemberId { get; set; }

        public int PayModel { get; set; }

        public int OperationType { get; set; }

        public decimal? BalanceAfterPay { get; set; }

        public Guid? PayOrderId { get; set; }

        [StringLength(50)]
        public string PayOrderCode { get; set; }

        public string BankFlowCode { get; set; }

        [StringLength(200)]
        public string BuyerAccount { get; set; }

        public int IsComplete { get; set; }

        [Required]
        public string Remark { get; set; }

        public DateTime CreateTime { get; set; }

        public int? LastUpdateUserType { get; set; }

        public Guid? LastUpdateUserId { get; set; }

        public string LastUpdateAccount { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public int Status { get; set; }
    }
}
