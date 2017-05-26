using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CustomerEntity
    {
        public CustomerEntity()
        {
            CatalogCompareItem = new HashSet<CatalogCompareItem>();
            CustomerAddressEntity = new HashSet<CustomerAddressEntity>();
            CustomerEntityDatetime = new HashSet<CustomerEntityDatetime>();
            CustomerEntityDecimal = new HashSet<CustomerEntityDecimal>();
            CustomerEntityInt = new HashSet<CustomerEntityInt>();
            CustomerEntityText = new HashSet<CustomerEntityText>();
            CustomerEntityVarchar = new HashSet<CustomerEntityVarchar>();
            DownloadableLinkPurchased = new HashSet<DownloadableLinkPurchased>();
            GiftvoucherCredit = new HashSet<GiftvoucherCredit>();
            GiftvoucherCreditHistory = new HashSet<GiftvoucherCreditHistory>();
            GiftvoucherCustomerVoucher = new HashSet<GiftvoucherCustomerVoucher>();
            MRmaComment = new HashSet<MRmaComment>();
            MRmaOfflineOrder = new HashSet<MRmaOfflineOrder>();
            MRmaRma = new HashSet<MRmaRma>();
            OauthToken = new HashSet<OauthToken>();
            ProductAlertPrice = new HashSet<ProductAlertPrice>();
            ProductAlertStock = new HashSet<ProductAlertStock>();
            ReportComparedProductIndex = new HashSet<ReportComparedProductIndex>();
            ReportViewedProductIndex = new HashSet<ReportViewedProductIndex>();
            ReviewDetail = new HashSet<ReviewDetail>();
            SalesBillingAgreement = new HashSet<SalesBillingAgreement>();
            SalesFlatOrder = new HashSet<SalesFlatOrder>();
            SalesFlatOrderGrid = new HashSet<SalesFlatOrderGrid>();
            SalesRecurringProfile = new HashSet<SalesRecurringProfile>();
            SalesruleCouponUsage = new HashSet<SalesruleCouponUsage>();
            SalesruleCustomer = new HashSet<SalesruleCustomer>();
            Tag = new HashSet<Tag>();
            TagRelation = new HashSet<TagRelation>();
        }

        public int EntityId { get; set; }
        public ushort AttributeSetId { get; set; }
        public DateTime CreatedAt { get; set; }
        public ushort DisableAutoGroupChange { get; set; }
        public string Email { get; set; }
        public ushort EntityTypeId { get; set; }
        public ushort GroupId { get; set; }
        public string IncrementId { get; set; }
        public ushort IsActive { get; set; }
        public ushort? StoreId { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ushort? WebsiteId { get; set; }

        public virtual AffiliateplusAccount AffiliateplusAccount { get; set; }
        public virtual ICollection<CatalogCompareItem> CatalogCompareItem { get; set; }
        public virtual ICollection<CustomerAddressEntity> CustomerAddressEntity { get; set; }
        public virtual ICollection<CustomerEntityDatetime> CustomerEntityDatetime { get; set; }
        public virtual ICollection<CustomerEntityDecimal> CustomerEntityDecimal { get; set; }
        public virtual ICollection<CustomerEntityInt> CustomerEntityInt { get; set; }
        public virtual ICollection<CustomerEntityText> CustomerEntityText { get; set; }
        public virtual ICollection<CustomerEntityVarchar> CustomerEntityVarchar { get; set; }
        public virtual ICollection<DownloadableLinkPurchased> DownloadableLinkPurchased { get; set; }
        public virtual ICollection<GiftvoucherCredit> GiftvoucherCredit { get; set; }
        public virtual ICollection<GiftvoucherCreditHistory> GiftvoucherCreditHistory { get; set; }
        public virtual ICollection<GiftvoucherCustomerVoucher> GiftvoucherCustomerVoucher { get; set; }
        public virtual ICollection<MRmaComment> MRmaComment { get; set; }
        public virtual ICollection<MRmaOfflineOrder> MRmaOfflineOrder { get; set; }
        public virtual ICollection<MRmaRma> MRmaRma { get; set; }
        public virtual ICollection<OauthToken> OauthToken { get; set; }
        public virtual PaypalauthCustomer PaypalauthCustomer { get; set; }
        public virtual PersistentSession PersistentSession { get; set; }
        public virtual ICollection<ProductAlertPrice> ProductAlertPrice { get; set; }
        public virtual ICollection<ProductAlertStock> ProductAlertStock { get; set; }
        public virtual ICollection<ReportComparedProductIndex> ReportComparedProductIndex { get; set; }
        public virtual ICollection<ReportViewedProductIndex> ReportViewedProductIndex { get; set; }
        public virtual ICollection<ReviewDetail> ReviewDetail { get; set; }
        public virtual ICollection<SalesBillingAgreement> SalesBillingAgreement { get; set; }
        public virtual ICollection<SalesFlatOrder> SalesFlatOrder { get; set; }
        public virtual ICollection<SalesFlatOrderGrid> SalesFlatOrderGrid { get; set; }
        public virtual ICollection<SalesRecurringProfile> SalesRecurringProfile { get; set; }
        public virtual ICollection<SalesruleCouponUsage> SalesruleCouponUsage { get; set; }
        public virtual ICollection<SalesruleCustomer> SalesruleCustomer { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
        public virtual ICollection<TagRelation> TagRelation { get; set; }
        public virtual Wishlist Wishlist { get; set; }
        public virtual CoreStore Store { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
