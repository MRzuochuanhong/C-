using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.Model
{
    public class PersonalInfoModel : PageResult
    {
        public TOP_PersonalInfo Data { get; set; }
    }
    public class TOP_PersonalInfo
    {
        /// <summary>
        /// 通联个人用户ID
        /// </summary>
        public Guid PersonalId { get; set; }
        /// <summary>
        /// 会员ID
        /// </summary>
        public Guid MemberId { get; set; }
        /// <summary>
        /// 真实姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string Phone { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string IdentityCardNo { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 状态（1-正常，0-删除）
        /// </summary>
        public int Status { get; set; }
    }
}
