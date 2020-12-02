namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TOP_PersonalInfo
    {
        public int Id { get; set; }

        public Guid PersonalId { get; set; }

        public Guid MemberId { get; set; }

        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(30)]
        public string IdentityCardNo { get; set; }

        public DateTime CreateTime { get; set; }

        public int Status { get; set; }
    }
}
