namespace Sseko.Data.Models
{
    public partial class CatalogEavAttribute
    {
        public ushort AttributeId { get; set; }
        public string ApplyTo { get; set; }
        public string FrontendInputRenderer { get; set; }
        public ushort IsComparable { get; set; }
        public ushort IsConfigurable { get; set; }
        public ushort IsFilterable { get; set; }
        public ushort IsFilterableInSearch { get; set; }
        public ushort IsGlobal { get; set; }
        public ushort IsHtmlAllowedOnFront { get; set; }
        public ushort IsSearchable { get; set; }
        public ushort IsUsedForPriceRules { get; set; }
        public ushort IsUsedForPromoRules { get; set; }
        public ushort IsVisible { get; set; }
        public ushort IsVisibleInAdvancedSearch { get; set; }
        public ushort IsVisibleOnFront { get; set; }
        public ushort IsWysiwygEnabled { get; set; }
        public int Position { get; set; }
        public ushort UsedForSortBy { get; set; }
        public ushort UsedInProductListing { get; set; }

        public virtual EavAttribute Attribute { get; set; }
    }
}
