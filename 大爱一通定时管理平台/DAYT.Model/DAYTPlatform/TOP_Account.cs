namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_Account
    {
        public int Id { get; set; }

        public Guid MemberId { get; set; }

        public Guid UserId { get; set; }

        public short UserType { get; set; }

        public short IsVerify { get; set; }

        public bool IsSignContract { get; set; }

        public bool IsCard { get; set; }

        public bool IsSafeCard { get; set; }

        public bool IsLock { get; set; }

        public bool IsSetPayPwd { get; set; }

        public bool IsPhoneChecked { get; set; }

        public short AccountType { get; set; }

        public decimal CashierBalance { get; set; }

        public decimal MarginBalance { get; set; }

        public decimal RebateBalance { get; set; }

        public int PayFailAmount { get; set; }

        public DateTime? VerifyTime { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime? LastUpdateTime { get; set; }

        public bool Status { get; set; }
    }
}
