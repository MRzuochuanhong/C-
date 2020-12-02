namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MessageSend
    {
        public int Id { get; set; }

        public Guid? SendId { get; set; }

        public Guid? MessageId { get; set; }

        public Guid? MemberId { get; set; }

        public DateTime? ReadTime { get; set; }

        public int? Status { get; set; }
    }
}
