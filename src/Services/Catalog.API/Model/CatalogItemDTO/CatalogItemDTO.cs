using System.ComponentModel.DataAnnotations;

namespace Catalog.API.Model.CatalogItemDTO
{
    public class CatalogItemDTO
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string CatalogType { get; set; }
        public string CatalogBrand { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }
        public int OnReorder { get; set; }
    }
}
