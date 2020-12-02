using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.Model
{
    public class SplitBillPageResult : PageResult
    {
        public List<TOP_SplitBill> Data { get; set; }
    }
    /// <summary>
    /// 平台分账账单
    /// </summary>
    public class TOP_SplitBill
    {
        public int Id { get; set; }

        public Nullable<Guid> ShopId { get; set; }

        public Nullable<Guid> MemberId { get; set; }

        public Nullable<Guid> OrderId { get; set; }

        public Nullable<Guid> PayOrderId { get; set; }

        public Nullable<Guid> PayOrderApplyId { get; set; }

        public string PayOrderCode { get; set; }

        public decimal PayFee { get; set; }

        public decimal HandFee { get; set; }

        public decimal ServiceFee { get; set; }

        public decimal CollectFee { get; set; }

        public int InAccountType { get; set; }

        public int FromAccountType { get; set; }

        public int IsInAccount { get; set; }

        public DateTime? InAccountTime { get; set; }

        public DateTime CreateTime { get; set; }

        public DateTime LastUpdateTime { get; set; }

        public int Status { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string InAccountNo { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public string FromAccountNo { get; set; }
    }
}
