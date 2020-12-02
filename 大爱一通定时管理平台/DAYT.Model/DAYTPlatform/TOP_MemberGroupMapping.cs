namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MemberGroupMapping
    {
        public int Id { get; set; }

        public Guid? GroupId { get; set; }

        public Guid? MemberId { get; set; }

        public DateTime? CreateTime { get; set; }

        public int? Status { get; set; }
    }
}
