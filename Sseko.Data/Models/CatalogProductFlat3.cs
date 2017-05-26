using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductFlat3
    {
        public int EntityId { get; set; }
        public ushort AttributeSetId { get; set; }
        public decimal? Cost { get; set; }
        public DateTime? CreatedAt { get; set; }
        public short? EnableGooglecheckout { get; set; }
        public short? GiftMessageAvailable { get; set; }
        public short HasOptions { get; set; }
        public string ImageLabel { get; set; }
        public short? IsRecurring { get; set; }
        public int? LinksExist { get; set; }
        public int? LinksPurchasedSeparately { get; set; }
        public decimal? Msrp { get; set; }
        public string MsrpDisplayActualPriceType { get; set; }
        public short? MsrpEnabled { get; set; }
        public string Name { get; set; }
        public DateTime? NewsFromDate { get; set; }
        public DateTime? NewsToDate { get; set; }
        public decimal? Price { get; set; }
        public int? PriceType { get; set; }
        public int? PriceView { get; set; }
        public string RecurringProfile { get; set; }
        public ushort RequiredOptions { get; set; }
        public int? ShipmentType { get; set; }
        public string ShortDescription { get; set; }
        public string Sku { get; set; }
        public int? SkuType { get; set; }
        public string SmallImage { get; set; }
        public string SmallImageLabel { get; set; }
        public string SpPrice { get; set; }
        public DateTime? SpecialFromDate { get; set; }
        public decimal? SpecialPrice { get; set; }
        public DateTime? SpecialToDate { get; set; }
        public int? TaxClassId { get; set; }
        public string Thumbnail { get; set; }
        public string ThumbnailLabel { get; set; }
        public string TypeId { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string UrlKey { get; set; }
        public string UrlPath { get; set; }
        public ushort? Visibility { get; set; }
        public decimal? Weight { get; set; }
        public int? WeightType { get; set; }

        public virtual CatalogProductEntity Entity { get; set; }
    }
}
