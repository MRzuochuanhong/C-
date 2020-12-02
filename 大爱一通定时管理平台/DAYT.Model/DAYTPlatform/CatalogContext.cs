namespace DAYT.Model.DAYTPlatform
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class JobContext : DbContext
    {
        public JobContext()
            : base("name=JobContext")
        {
        }

        public virtual DbSet<Logistics_Company> Logistics_Company { get; set; }
        public virtual DbSet<Logistics_Order> Logistics_Order { get; set; }
        public virtual DbSet<Shop_Product> Shop_Product { get; set; }
        public virtual DbSet<Shop_ProductClassRatio> Shop_ProductClassRatio { get; set; }
        public virtual DbSet<Shop_ProductPriceRatio> Shop_ProductPriceRatio { get; set; }
        public virtual DbSet<Shop_ProductSKUPrice> Shop_ProductSKUPrice { get; set; }
        public virtual DbSet<Shop_ProductSKUPropertyValue> Shop_ProductSKUPropertyValue { get; set; }
        public virtual DbSet<Shop_ProPropertyValueNexus> Shop_ProPropertyValueNexus { get; set; }
        public virtual DbSet<SYS_AdminPermissions> SYS_AdminPermissions { get; set; }
        public virtual DbSet<SYS_AdminRole> SYS_AdminRole { get; set; }
        public virtual DbSet<SYS_AdminUser> SYS_AdminUser { get; set; }
        public virtual DbSet<SYS_Area> SYS_Area { get; set; }
        public virtual DbSet<SYS_AreaMapping> SYS_AreaMapping { get; set; }
        public virtual DbSet<SYS_AreaRegion> SYS_AreaRegion { get; set; }
        public virtual DbSet<SYS_Brand> SYS_Brand { get; set; }
        public virtual DbSet<SYS_Dictionary> SYS_Dictionary { get; set; }
        public virtual DbSet<SYS_Menu> SYS_Menu { get; set; }
        public virtual DbSet<SYS_ScheduleTask> SYS_ScheduleTask { get; set; }
        public virtual DbSet<SYS_SendHistory> SYS_SendHistory { get; set; }
        public virtual DbSet<SYS_Template> SYS_Template { get; set; }
        public virtual DbSet<SYS_Units> SYS_Units { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TOP_Account> TOP_Account { get; set; }
        public virtual DbSet<TOP_Activity> TOP_Activity { get; set; }
        public virtual DbSet<TOP_Advertising> TOP_Advertising { get; set; }
        public virtual DbSet<TOP_Article> TOP_Article { get; set; }
        public virtual DbSet<TOP_AuthAccount> TOP_AuthAccount { get; set; }
        public virtual DbSet<TOP_BankCard> TOP_BankCard { get; set; }
        public virtual DbSet<TOP_Banner> TOP_Banner { get; set; }
        public virtual DbSet<TOP_BoutiqueShop> TOP_BoutiqueShop { get; set; }
        public virtual DbSet<TOP_Collect> TOP_Collect { get; set; }
        public virtual DbSet<TOP_CompanyInfo> TOP_CompanyInfo { get; set; }
        public virtual DbSet<TOP_Coupon> TOP_Coupon { get; set; }
        public virtual DbSet<TOP_DeliverAddress> TOP_DeliverAddress { get; set; }
        public virtual DbSet<TOP_Distribution> TOP_Distribution { get; set; }
        public virtual DbSet<TOP_DistributionBill> TOP_DistributionBill { get; set; }
        public virtual DbSet<TOP_Footmark> TOP_Footmark { get; set; }
        public virtual DbSet<TOP_HotSaleCommodity> TOP_HotSaleCommodity { get; set; }
        public virtual DbSet<TOP_HotSaleProduct> TOP_HotSaleProduct { get; set; }
        public virtual DbSet<TOP_JoinCooperation> TOP_JoinCooperation { get; set; }
        public virtual DbSet<TOP_Member> TOP_Member { get; set; }
        public virtual DbSet<TOP_MemberCoupons> TOP_MemberCoupons { get; set; }
        public virtual DbSet<TOP_MemberCouponsHistory> TOP_MemberCouponsHistory { get; set; }
        public virtual DbSet<TOP_MemberGroup> TOP_MemberGroup { get; set; }
        public virtual DbSet<TOP_MemberGroupMapping> TOP_MemberGroupMapping { get; set; }
        public virtual DbSet<TOP_MemberGuidehHistory> TOP_MemberGuidehHistory { get; set; }
        public virtual DbSet<TOP_MemberInvoice> TOP_MemberInvoice { get; set; }
        public virtual DbSet<TOP_Menu> TOP_Menu { get; set; }
        public virtual DbSet<TOP_Message> TOP_Message { get; set; }
        public virtual DbSet<TOP_MessageGroupMapping> TOP_MessageGroupMapping { get; set; }
        public virtual DbSet<TOP_MessageSend> TOP_MessageSend { get; set; }
        public virtual DbSet<TOP_Needs> TOP_Needs { get; set; }
        public virtual DbSet<TOP_NeedsFile> TOP_NeedsFile { get; set; }
        public virtual DbSet<TOP_OldUser> TOP_OldUser { get; set; }
        public virtual DbSet<TOP_OperationActivity> TOP_OperationActivity { get; set; }
        public virtual DbSet<TOP_Order> TOP_Order { get; set; }
        public virtual DbSet<TOP_PayOrder> TOP_PayOrder { get; set; }
        public virtual DbSet<TOP_PersonalInfo> TOP_PersonalInfo { get; set; }
        public virtual DbSet<TOP_ProClass> TOP_ProClass { get; set; }
        public virtual DbSet<TOP_Product> TOP_Product { get; set; }
        public virtual DbSet<TOP_ProductImages> TOP_ProductImages { get; set; }
        public virtual DbSet<TOP_ProductSKUProperty> TOP_ProductSKUProperty { get; set; }
        public virtual DbSet<TOP_ProductSKUPropertyValue> TOP_ProductSKUPropertyValue { get; set; }
        public virtual DbSet<TOP_ProProperty> TOP_ProProperty { get; set; }
        public virtual DbSet<TOP_ProPropertyNexus> TOP_ProPropertyNexus { get; set; }
        public virtual DbSet<TOP_ProPropertyValue> TOP_ProPropertyValue { get; set; }
        public virtual DbSet<TOP_ProPropertyValueNexus> TOP_ProPropertyValueNexus { get; set; }
        public virtual DbSet<TOP_ProStandard> TOP_ProStandard { get; set; }
        public virtual DbSet<TOP_RecommendProduct> TOP_RecommendProduct { get; set; }
        public virtual DbSet<TOP_RefundOrder> TOP_RefundOrder { get; set; }
        public virtual DbSet<TOP_Shop> TOP_Shop { get; set; }
        public virtual DbSet<TOP_ShopCSInfo> TOP_ShopCSInfo { get; set; }
        public virtual DbSet<TOP_ShoppingCart> TOP_ShoppingCart { get; set; }
        public virtual DbSet<TOP_ShopProductClass> TOP_ShopProductClass { get; set; }
        public virtual DbSet<TOP_ShopUser> TOP_ShopUser { get; set; }
        public virtual DbSet<TOP_SKUProperty> TOP_SKUProperty { get; set; }
        public virtual DbSet<TOP_SplitBill> TOP_SplitBill { get; set; }
        public virtual DbSet<TOP_SubCoupon> TOP_SubCoupon { get; set; }
        public virtual DbSet<TOP_SubOrder> TOP_SubOrder { get; set; }
        public virtual DbSet<TOP_SubOrderForOA> TOP_SubOrderForOA { get; set; }
        public virtual DbSet<TOP_SubOrderImages> TOP_SubOrderImages { get; set; }
        public virtual DbSet<TOP_SysMessage> TOP_SysMessage { get; set; }
        public virtual DbSet<TOP_TLPayOrderApply> TOP_TLPayOrderApply { get; set; }
        public virtual DbSet<TOP_TradeFrozen> TOP_TradeFrozen { get; set; }
        public virtual DbSet<TOP_TradeRecord> TOP_TradeRecord { get; set; }
        public virtual DbSet<TOP_OrderForOA> TOP_OrderForOA { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Shop_ProductClassRatio>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Shop_ProductPriceRatio>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<Shop_ProductSKUPrice>()
                .Property(e => e.ProductSKUPropertyValueIds)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.AreaId)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.ParentId)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.CityCode)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.MergerName)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.Longitude)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.Latitude)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Area>()
                .Property(e => e.Pinyin)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AreaMapping>()
                .Property(e => e.AreaId)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_AreaRegion>()
                .Property(e => e.RegionName)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SendHistory>()
                .Property(e => e.MsgContent)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SendHistory>()
                .Property(e => e.ResultMsgID)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SendHistory>()
                .Property(e => e.ResultMsg)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_Activity>()
                .Property(e => e.ActivityUrl)
                .IsFixedLength();

            modelBuilder.Entity<TOP_AuthAccount>()
                .Property(e => e.OpenId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_AuthAccount>()
                .Property(e => e.PlatformId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_AuthAccount>()
                .Property(e => e.PlatformCode)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_AuthAccount>()
                .Property(e => e.NickName)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_AuthAccount>()
                .Property(e => e.UserInfo)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_AuthAccount>()
                .Property(e => e.Source)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_BankCard>()
                .Property(e => e.CardNo)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_BankCard>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_BankCard>()
                .Property(e => e.Validate)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_BankCard>()
                .Property(e => e.CVV2)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_CompanyInfo>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_CompanyInfo>()
                .Property(e => e.LegalIds)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_CompanyInfo>()
                .Property(e => e.LegalPhone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_CompanyInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_CompanyInfo>()
                .Property(e => e.BankCityNo)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_DeliverAddress>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_DeliverAddress>()
                .Property(e => e.Telephone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberGroup>()
                .Property(e => e.GroupName)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberGroup>()
                .Property(e => e.Remark)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberInvoice>()
                .Property(e => e.Identification)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberInvoice>()
                .Property(e => e.ProvinceId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberInvoice>()
                .Property(e => e.CityId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberInvoice>()
                .Property(e => e.DistrictId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_MemberInvoice>()
                .Property(e => e.StreetId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_Message>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_Message>()
                .Property(e => e.SubTitle)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_Message>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_OldUser>()
                .Property(e => e.UserType)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_OldUser>()
                .Property(e => e.QQ)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_OldUser>()
                .Property(e => e.SourceInfo)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_OperationActivity>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_OperationActivity>()
                .Property(e => e.City)
                .IsFixedLength();

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.ProTotalPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.DiscountFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.OrderTotalFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.UrgentFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.DeliveryFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.CouponFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.ChangeFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.PayFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_Order>()
                .Property(e => e.TotalWeight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TOP_PersonalInfo>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_PersonalInfo>()
                .Property(e => e.IdentityCardNo)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_Product>()
                .Property(e => e.Weight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TOP_ShoppingCart>()
                .Property(e => e.ProductPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_ShoppingCart>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_ShoppingCart>()
                .Property(e => e.Acreage)
                .HasPrecision(37, 4);

            modelBuilder.Entity<TOP_ShoppingCart>()
                .Property(e => e.Weight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TOP_ShoppingCart>()
                .Property(e => e.LinePrice)
                .HasPrecision(29, 4);

            modelBuilder.Entity<TOP_ShoppingCart>()
                .Property(e => e.UrgentFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_ShopProductClass>()
                .Property(e => e.Capacity)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TOP_SplitBill>()
                .Property(e => e.InAccountOrderNo)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.Acreage)
                .HasPrecision(38, 4);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.Weight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.ProductPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.LinePrice)
                .HasPrecision(29, 4);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.DiscountRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.DiscountFee)
                .HasPrecision(38, 6);

            modelBuilder.Entity<TOP_SubOrder>()
                .Property(e => e.LinePayFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.Acreage)
                .HasPrecision(38, 4);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.Weight)
                .HasPrecision(18, 3);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.ProductPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.UnitPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.LinePrice)
                .HasPrecision(29, 4);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.DiscountRate)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.DiscountFee)
                .HasPrecision(38, 6);

            modelBuilder.Entity<TOP_SubOrderForOA>()
                .Property(e => e.LinePayFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_SysMessage>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_SysMessage>()
                .Property(e => e.SubTitle)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_SysMessage>()
                .Property(e => e.Content)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_TLPayOrderApply>()
                .Property(e => e.TLOrderId)
                .IsUnicode(false);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.ProTotalPrice)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.DiscountFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.OrderTotalFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.UrgentFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.DeliveryFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.CouponFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.ChangeFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.PayFee)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TOP_OrderForOA>()
                .Property(e => e.TotalWeight)
                .HasPrecision(18, 3);
        }
    }
}
