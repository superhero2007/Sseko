using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CoreStore
    {
        public CoreStore()
        {
            AffiliateplusAccountValue = new HashSet<AffiliateplusAccountValue>();
            AffiliateplusAction = new HashSet<AffiliateplusAction>();
            AffiliateplusBannerValue = new HashSet<AffiliateplusBannerValue>();
            AffiliateplusprogramCategory = new HashSet<AffiliateplusprogramCategory>();
            AffiliateplusprogramProduct = new HashSet<AffiliateplusprogramProduct>();
            AffiliateplusprogramValue = new HashSet<AffiliateplusprogramValue>();
            AffiliateplusReferer = new HashSet<AffiliateplusReferer>();
            AffiliateplusTransaction = new HashSet<AffiliateplusTransaction>();
            CatalogCategoryEntityDatetime = new HashSet<CatalogCategoryEntityDatetime>();
            CatalogCategoryEntityDecimal = new HashSet<CatalogCategoryEntityDecimal>();
            CatalogCategoryEntityInt = new HashSet<CatalogCategoryEntityInt>();
            CatalogCategoryEntityText = new HashSet<CatalogCategoryEntityText>();
            CatalogCategoryEntityVarchar = new HashSet<CatalogCategoryEntityVarchar>();
            CatalogCategoryFlatStore1 = new HashSet<CatalogCategoryFlatStore1>();
            CatalogCategoryFlatStore2 = new HashSet<CatalogCategoryFlatStore2>();
            CatalogCategoryFlatStore3 = new HashSet<CatalogCategoryFlatStore3>();
            CatalogCategoryProductIndex = new HashSet<CatalogCategoryProductIndex>();
            CatalogCompareItem = new HashSet<CatalogCompareItem>();
            CatalogProductEnabledIndex = new HashSet<CatalogProductEnabledIndex>();
            CatalogProductEntityDatetime = new HashSet<CatalogProductEntityDatetime>();
            CatalogProductEntityDecimal = new HashSet<CatalogProductEntityDecimal>();
            CatalogProductEntityGallery = new HashSet<CatalogProductEntityGallery>();
            CatalogProductEntityInt = new HashSet<CatalogProductEntityInt>();
            CatalogProductEntityMediaGalleryValue = new HashSet<CatalogProductEntityMediaGalleryValue>();
            CatalogProductEntityText = new HashSet<CatalogProductEntityText>();
            CatalogProductEntityVarchar = new HashSet<CatalogProductEntityVarchar>();
            CatalogProductIndexEav = new HashSet<CatalogProductIndexEav>();
            CatalogProductIndexEavDecimal = new HashSet<CatalogProductIndexEavDecimal>();
            CatalogProductOptionPrice = new HashSet<CatalogProductOptionPrice>();
            CatalogProductOptionTitle = new HashSet<CatalogProductOptionTitle>();
            CatalogProductOptionTypePrice = new HashSet<CatalogProductOptionTypePrice>();
            CatalogProductOptionTypeTitle = new HashSet<CatalogProductOptionTypeTitle>();
            CatalogProductSuperAttributeLabel = new HashSet<CatalogProductSuperAttributeLabel>();
            CatalogsearchQuery = new HashSet<CatalogsearchQuery>();
            CheckoutAgreementStore = new HashSet<CheckoutAgreementStore>();
            CmsBlockStore = new HashSet<CmsBlockStore>();
            CmsPageStore = new HashSet<CmsPageStore>();
            CoreLayoutLink = new HashSet<CoreLayoutLink>();
            CoreTranslate = new HashSet<CoreTranslate>();
            CoreUrlRewrite = new HashSet<CoreUrlRewrite>();
            CoreVariableValue = new HashSet<CoreVariableValue>();
            CouponAggregated = new HashSet<CouponAggregated>();
            CouponAggregatedOrder = new HashSet<CouponAggregatedOrder>();
            CouponAggregatedUpdated = new HashSet<CouponAggregatedUpdated>();
            CustomerEntity = new HashSet<CustomerEntity>();
            DataflowBatch = new HashSet<DataflowBatch>();
            DesignChange = new HashSet<DesignChange>();
            DownloadableLinkTitle = new HashSet<DownloadableLinkTitle>();
            DownloadableSampleTitle = new HashSet<DownloadableSampleTitle>();
            EavAttributeLabel = new HashSet<EavAttributeLabel>();
            EavAttributeOptionValue = new HashSet<EavAttributeOptionValue>();
            EavEntity = new HashSet<EavEntity>();
            EavEntityDatetime = new HashSet<EavEntityDatetime>();
            EavEntityDecimal = new HashSet<EavEntityDecimal>();
            EavEntityInt = new HashSet<EavEntityInt>();
            EavEntityStore = new HashSet<EavEntityStore>();
            EavEntityText = new HashSet<EavEntityText>();
            EavEntityVarchar = new HashSet<EavEntityVarchar>();
            EavFormFieldsetLabel = new HashSet<EavFormFieldsetLabel>();
            EavFormType = new HashSet<EavFormType>();
            MRmaRma = new HashSet<MRmaRma>();
            MRmaRmaStore = new HashSet<MRmaRmaStore>();
            MRmaTemplateStore = new HashSet<MRmaTemplateStore>();
            NewsletterQueueStoreLink = new HashSet<NewsletterQueueStoreLink>();
            NewsletterSubscriber = new HashSet<NewsletterSubscriber>();
            Poll = new HashSet<Poll>();
            PollStore = new HashSet<PollStore>();
            RatingOptionVoteAggregated = new HashSet<RatingOptionVoteAggregated>();
            RatingStore = new HashSet<RatingStore>();
            RatingTitle = new HashSet<RatingTitle>();
            ReportComparedProductIndex = new HashSet<ReportComparedProductIndex>();
            ReportEvent = new HashSet<ReportEvent>();
            ReportViewedProductAggregatedDaily = new HashSet<ReportViewedProductAggregatedDaily>();
            ReportViewedProductAggregatedMonthly = new HashSet<ReportViewedProductAggregatedMonthly>();
            ReportViewedProductAggregatedYearly = new HashSet<ReportViewedProductAggregatedYearly>();
            ReportViewedProductIndex = new HashSet<ReportViewedProductIndex>();
            ReviewDetail = new HashSet<ReviewDetail>();
            ReviewEntitySummary = new HashSet<ReviewEntitySummary>();
            ReviewStore = new HashSet<ReviewStore>();
            SalesBestsellersAggregatedDaily = new HashSet<SalesBestsellersAggregatedDaily>();
            SalesBestsellersAggregatedMonthly = new HashSet<SalesBestsellersAggregatedMonthly>();
            SalesBestsellersAggregatedYearly = new HashSet<SalesBestsellersAggregatedYearly>();
            SalesBillingAgreement = new HashSet<SalesBillingAgreement>();
            SalesFlatCreditmemo = new HashSet<SalesFlatCreditmemo>();
            SalesFlatCreditmemoGrid = new HashSet<SalesFlatCreditmemoGrid>();
            SalesFlatInvoice = new HashSet<SalesFlatInvoice>();
            SalesFlatInvoiceGrid = new HashSet<SalesFlatInvoiceGrid>();
            SalesFlatOrder = new HashSet<SalesFlatOrder>();
            SalesFlatOrderGrid = new HashSet<SalesFlatOrderGrid>();
            SalesFlatOrderItem = new HashSet<SalesFlatOrderItem>();
            SalesFlatQuote = new HashSet<SalesFlatQuote>();
            SalesFlatQuoteItem = new HashSet<SalesFlatQuoteItem>();
            SalesFlatShipment = new HashSet<SalesFlatShipment>();
            SalesFlatShipmentGrid = new HashSet<SalesFlatShipmentGrid>();
            SalesInvoicedAggregated = new HashSet<SalesInvoicedAggregated>();
            SalesInvoicedAggregatedOrder = new HashSet<SalesInvoicedAggregatedOrder>();
            SalesOrderAggregatedCreated = new HashSet<SalesOrderAggregatedCreated>();
            SalesOrderAggregatedUpdated = new HashSet<SalesOrderAggregatedUpdated>();
            SalesOrderStatusLabel = new HashSet<SalesOrderStatusLabel>();
            SalesRecurringProfile = new HashSet<SalesRecurringProfile>();
            SalesRefundedAggregated = new HashSet<SalesRefundedAggregated>();
            SalesRefundedAggregatedOrder = new HashSet<SalesRefundedAggregatedOrder>();
            SalesruleLabel = new HashSet<SalesruleLabel>();
            SalesShippingAggregated = new HashSet<SalesShippingAggregated>();
            SalesShippingAggregatedOrder = new HashSet<SalesShippingAggregatedOrder>();
            Sitemap = new HashSet<Sitemap>();
            Tag = new HashSet<Tag>();
            TagProperties = new HashSet<TagProperties>();
            TagRelation = new HashSet<TagRelation>();
            TagSummary = new HashSet<TagSummary>();
            TaxCalculationRateTitle = new HashSet<TaxCalculationRateTitle>();
            TaxOrderAggregatedCreated = new HashSet<TaxOrderAggregatedCreated>();
            TaxOrderAggregatedUpdated = new HashSet<TaxOrderAggregatedUpdated>();
            WishlistItem = new HashSet<WishlistItem>();
            XmlconnectApplication = new HashSet<XmlconnectApplication>();
            ZeonManufacturerStore = new HashSet<ZeonManufacturerStore>();
        }

        public ushort StoreId { get; set; }
        public string Code { get; set; }
        public ushort GroupId { get; set; }
        public ushort IsActive { get; set; }
        public string Name { get; set; }
        public ushort SortOrder { get; set; }
        public ushort WebsiteId { get; set; }

        public virtual ICollection<AffiliateplusAccountValue> AffiliateplusAccountValue { get; set; }
        public virtual ICollection<AffiliateplusAction> AffiliateplusAction { get; set; }
        public virtual ICollection<AffiliateplusBannerValue> AffiliateplusBannerValue { get; set; }
        public virtual ICollection<AffiliateplusprogramCategory> AffiliateplusprogramCategory { get; set; }
        public virtual ICollection<AffiliateplusprogramProduct> AffiliateplusprogramProduct { get; set; }
        public virtual ICollection<AffiliateplusprogramValue> AffiliateplusprogramValue { get; set; }
        public virtual ICollection<AffiliateplusReferer> AffiliateplusReferer { get; set; }
        public virtual ICollection<AffiliateplusTransaction> AffiliateplusTransaction { get; set; }
        public virtual ICollection<CatalogCategoryEntityDatetime> CatalogCategoryEntityDatetime { get; set; }
        public virtual ICollection<CatalogCategoryEntityDecimal> CatalogCategoryEntityDecimal { get; set; }
        public virtual ICollection<CatalogCategoryEntityInt> CatalogCategoryEntityInt { get; set; }
        public virtual ICollection<CatalogCategoryEntityText> CatalogCategoryEntityText { get; set; }
        public virtual ICollection<CatalogCategoryEntityVarchar> CatalogCategoryEntityVarchar { get; set; }
        public virtual ICollection<CatalogCategoryFlatStore1> CatalogCategoryFlatStore1 { get; set; }
        public virtual ICollection<CatalogCategoryFlatStore2> CatalogCategoryFlatStore2 { get; set; }
        public virtual ICollection<CatalogCategoryFlatStore3> CatalogCategoryFlatStore3 { get; set; }
        public virtual ICollection<CatalogCategoryProductIndex> CatalogCategoryProductIndex { get; set; }
        public virtual ICollection<CatalogCompareItem> CatalogCompareItem { get; set; }
        public virtual ICollection<CatalogProductEnabledIndex> CatalogProductEnabledIndex { get; set; }
        public virtual ICollection<CatalogProductEntityDatetime> CatalogProductEntityDatetime { get; set; }
        public virtual ICollection<CatalogProductEntityDecimal> CatalogProductEntityDecimal { get; set; }
        public virtual ICollection<CatalogProductEntityGallery> CatalogProductEntityGallery { get; set; }
        public virtual ICollection<CatalogProductEntityInt> CatalogProductEntityInt { get; set; }
        public virtual ICollection<CatalogProductEntityMediaGalleryValue> CatalogProductEntityMediaGalleryValue { get; set; }
        public virtual ICollection<CatalogProductEntityText> CatalogProductEntityText { get; set; }
        public virtual ICollection<CatalogProductEntityVarchar> CatalogProductEntityVarchar { get; set; }
        public virtual ICollection<CatalogProductIndexEav> CatalogProductIndexEav { get; set; }
        public virtual ICollection<CatalogProductIndexEavDecimal> CatalogProductIndexEavDecimal { get; set; }
        public virtual ICollection<CatalogProductOptionPrice> CatalogProductOptionPrice { get; set; }
        public virtual ICollection<CatalogProductOptionTitle> CatalogProductOptionTitle { get; set; }
        public virtual ICollection<CatalogProductOptionTypePrice> CatalogProductOptionTypePrice { get; set; }
        public virtual ICollection<CatalogProductOptionTypeTitle> CatalogProductOptionTypeTitle { get; set; }
        public virtual ICollection<CatalogProductSuperAttributeLabel> CatalogProductSuperAttributeLabel { get; set; }
        public virtual ICollection<CatalogsearchQuery> CatalogsearchQuery { get; set; }
        public virtual ICollection<CheckoutAgreementStore> CheckoutAgreementStore { get; set; }
        public virtual ICollection<CmsBlockStore> CmsBlockStore { get; set; }
        public virtual ICollection<CmsPageStore> CmsPageStore { get; set; }
        public virtual ICollection<CoreLayoutLink> CoreLayoutLink { get; set; }
        public virtual ICollection<CoreTranslate> CoreTranslate { get; set; }
        public virtual ICollection<CoreUrlRewrite> CoreUrlRewrite { get; set; }
        public virtual ICollection<CoreVariableValue> CoreVariableValue { get; set; }
        public virtual ICollection<CouponAggregated> CouponAggregated { get; set; }
        public virtual ICollection<CouponAggregatedOrder> CouponAggregatedOrder { get; set; }
        public virtual ICollection<CouponAggregatedUpdated> CouponAggregatedUpdated { get; set; }
        public virtual ICollection<CustomerEntity> CustomerEntity { get; set; }
        public virtual ICollection<DataflowBatch> DataflowBatch { get; set; }
        public virtual ICollection<DesignChange> DesignChange { get; set; }
        public virtual ICollection<DownloadableLinkTitle> DownloadableLinkTitle { get; set; }
        public virtual ICollection<DownloadableSampleTitle> DownloadableSampleTitle { get; set; }
        public virtual ICollection<EavAttributeLabel> EavAttributeLabel { get; set; }
        public virtual ICollection<EavAttributeOptionValue> EavAttributeOptionValue { get; set; }
        public virtual ICollection<EavEntity> EavEntity { get; set; }
        public virtual ICollection<EavEntityDatetime> EavEntityDatetime { get; set; }
        public virtual ICollection<EavEntityDecimal> EavEntityDecimal { get; set; }
        public virtual ICollection<EavEntityInt> EavEntityInt { get; set; }
        public virtual ICollection<EavEntityStore> EavEntityStore { get; set; }
        public virtual ICollection<EavEntityText> EavEntityText { get; set; }
        public virtual ICollection<EavEntityVarchar> EavEntityVarchar { get; set; }
        public virtual ICollection<EavFormFieldsetLabel> EavFormFieldsetLabel { get; set; }
        public virtual ICollection<EavFormType> EavFormType { get; set; }
        public virtual ICollection<MRmaRma> MRmaRma { get; set; }
        public virtual ICollection<MRmaRmaStore> MRmaRmaStore { get; set; }
        public virtual ICollection<MRmaTemplateStore> MRmaTemplateStore { get; set; }
        public virtual ICollection<NewsletterQueueStoreLink> NewsletterQueueStoreLink { get; set; }
        public virtual ICollection<NewsletterSubscriber> NewsletterSubscriber { get; set; }
        public virtual ICollection<Poll> Poll { get; set; }
        public virtual ICollection<PollStore> PollStore { get; set; }
        public virtual ICollection<RatingOptionVoteAggregated> RatingOptionVoteAggregated { get; set; }
        public virtual ICollection<RatingStore> RatingStore { get; set; }
        public virtual ICollection<RatingTitle> RatingTitle { get; set; }
        public virtual ICollection<ReportComparedProductIndex> ReportComparedProductIndex { get; set; }
        public virtual ICollection<ReportEvent> ReportEvent { get; set; }
        public virtual ICollection<ReportViewedProductAggregatedDaily> ReportViewedProductAggregatedDaily { get; set; }
        public virtual ICollection<ReportViewedProductAggregatedMonthly> ReportViewedProductAggregatedMonthly { get; set; }
        public virtual ICollection<ReportViewedProductAggregatedYearly> ReportViewedProductAggregatedYearly { get; set; }
        public virtual ICollection<ReportViewedProductIndex> ReportViewedProductIndex { get; set; }
        public virtual ICollection<ReviewDetail> ReviewDetail { get; set; }
        public virtual ICollection<ReviewEntitySummary> ReviewEntitySummary { get; set; }
        public virtual ICollection<ReviewStore> ReviewStore { get; set; }
        public virtual ICollection<SalesBestsellersAggregatedDaily> SalesBestsellersAggregatedDaily { get; set; }
        public virtual ICollection<SalesBestsellersAggregatedMonthly> SalesBestsellersAggregatedMonthly { get; set; }
        public virtual ICollection<SalesBestsellersAggregatedYearly> SalesBestsellersAggregatedYearly { get; set; }
        public virtual ICollection<SalesBillingAgreement> SalesBillingAgreement { get; set; }
        public virtual ICollection<SalesFlatCreditmemo> SalesFlatCreditmemo { get; set; }
        public virtual ICollection<SalesFlatCreditmemoGrid> SalesFlatCreditmemoGrid { get; set; }
        public virtual ICollection<SalesFlatInvoice> SalesFlatInvoice { get; set; }
        public virtual ICollection<SalesFlatInvoiceGrid> SalesFlatInvoiceGrid { get; set; }
        public virtual ICollection<SalesFlatOrder> SalesFlatOrder { get; set; }
        public virtual ICollection<SalesFlatOrderGrid> SalesFlatOrderGrid { get; set; }
        public virtual ICollection<SalesFlatOrderItem> SalesFlatOrderItem { get; set; }
        public virtual ICollection<SalesFlatQuote> SalesFlatQuote { get; set; }
        public virtual ICollection<SalesFlatQuoteItem> SalesFlatQuoteItem { get; set; }
        public virtual ICollection<SalesFlatShipment> SalesFlatShipment { get; set; }
        public virtual ICollection<SalesFlatShipmentGrid> SalesFlatShipmentGrid { get; set; }
        public virtual ICollection<SalesInvoicedAggregated> SalesInvoicedAggregated { get; set; }
        public virtual ICollection<SalesInvoicedAggregatedOrder> SalesInvoicedAggregatedOrder { get; set; }
        public virtual ICollection<SalesOrderAggregatedCreated> SalesOrderAggregatedCreated { get; set; }
        public virtual ICollection<SalesOrderAggregatedUpdated> SalesOrderAggregatedUpdated { get; set; }
        public virtual ICollection<SalesOrderStatusLabel> SalesOrderStatusLabel { get; set; }
        public virtual ICollection<SalesRecurringProfile> SalesRecurringProfile { get; set; }
        public virtual ICollection<SalesRefundedAggregated> SalesRefundedAggregated { get; set; }
        public virtual ICollection<SalesRefundedAggregatedOrder> SalesRefundedAggregatedOrder { get; set; }
        public virtual ICollection<SalesruleLabel> SalesruleLabel { get; set; }
        public virtual ICollection<SalesShippingAggregated> SalesShippingAggregated { get; set; }
        public virtual ICollection<SalesShippingAggregatedOrder> SalesShippingAggregatedOrder { get; set; }
        public virtual ICollection<Sitemap> Sitemap { get; set; }
        public virtual ICollection<Tag> Tag { get; set; }
        public virtual ICollection<TagProperties> TagProperties { get; set; }
        public virtual ICollection<TagRelation> TagRelation { get; set; }
        public virtual ICollection<TagSummary> TagSummary { get; set; }
        public virtual ICollection<TaxCalculationRateTitle> TaxCalculationRateTitle { get; set; }
        public virtual ICollection<TaxOrderAggregatedCreated> TaxOrderAggregatedCreated { get; set; }
        public virtual ICollection<TaxOrderAggregatedUpdated> TaxOrderAggregatedUpdated { get; set; }
        public virtual ICollection<WishlistItem> WishlistItem { get; set; }
        public virtual ICollection<XmlconnectApplication> XmlconnectApplication { get; set; }
        public virtual ICollection<ZeonManufacturerStore> ZeonManufacturerStore { get; set; }
        public virtual CoreStoreGroup Group { get; set; }
        public virtual CoreWebsite Website { get; set; }
    }
}
