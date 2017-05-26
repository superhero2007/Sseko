using System;
using System.Collections.Generic;

namespace Sseko.Data.Models
{
    public partial class CatalogProductEntityMediaGallery
    {
        public CatalogProductEntityMediaGallery()
        {
            CatalogProductEntityMediaGalleryValue = new HashSet<CatalogProductEntityMediaGalleryValue>();
        }

        public int ValueId { get; set; }
        public ushort AttributeId { get; set; }
        public int EntityId { get; set; }
        public string Value { get; set; }

        public virtual ICollection<CatalogProductEntityMediaGalleryValue> CatalogProductEntityMediaGalleryValue { get; set; }
        public virtual EavAttribute Attribute { get; set; }
        public virtual CatalogProductEntity Entity { get; set; }
    }
}
