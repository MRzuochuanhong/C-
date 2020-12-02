using DAYT.WebCommon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAYT.BLL
{
    public class BaseBLL
    {
        /// <summary>
        /// 用户中台地址
        /// </summary>
        public readonly string MemberDataInterface = ConfigHelper.GetConfigString("MemberDataInterface");

        /// <summary>
        /// 订单中台地址
        /// </summary>
        public readonly string OrderDataInterface = ConfigHelper.GetConfigString("OrderDataInterface");

        /// <summary>
        /// 平台店铺商品中台
        /// </summary>
        public readonly string ShopProductInterface = ConfigHelper.GetConfigString("ShopProductInterface");

        /// <summary>
        /// 基础信息中台
        /// </summary>
        public readonly string BasicInformationface = ConfigHelper.GetConfigString("BasicInformationface");

        /// <summary>
        /// 日志中台
        /// </summary>
        public readonly string LogDataInterface = ConfigHelper.GetConfigString("LogDataInterface");

        /// <summary>
        /// 账户中台
        /// </summary>
        public readonly string AccountInterface = ConfigHelper.GetConfigString("AccountInterface");
        /// <summary>
        /// 缓存队列Redis的key
        /// </summary>
        public enum CacheKeyName
        {
            /// <summary>
            /// 行政区域列表
            /// </summary>
            AreaList
        };
    }
}
