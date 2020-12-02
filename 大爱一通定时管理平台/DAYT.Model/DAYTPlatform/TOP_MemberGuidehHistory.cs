namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_MemberGuidehHistory
    {
        public int Id { get; set; }

        public Guid GuideId { get; set; }

        public Guid UserId { get; set; }

        public int GuideType { get; set; }

        public DateTime CreateTime { get; set; }
    }
}
