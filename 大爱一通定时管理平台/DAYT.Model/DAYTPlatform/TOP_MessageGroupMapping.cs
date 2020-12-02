namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MessageGroupMapping
    {
        public int Id { get; set; }

        public Guid? GroupId { get; set; }

        public Guid? MessageId { get; set; }

        public int? SendMode { get; set; }

        public DateTime? SendTime { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Status { get; set; }
    }
}
