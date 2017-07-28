namespace Sseko.Data.Models
{
    public partial class ZeonManufacturerStore
    {
        public int ManufacturerId { get; set; }
        public ushort StoreId { get; set; }

        public virtual ZeonManufacturer Manufacturer { get; set; }
        public virtual CoreStore Store { get; set; }
    }
}
