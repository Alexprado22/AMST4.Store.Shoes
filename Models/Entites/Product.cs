

namespace AMST4.Store.Shoes.Models.Entites;

    public class Product
    {
        public Guid Id { get; set; }
        public string Brand { get; set; } = string.Empty;
        public Guid ColorId { get; set; }
        public Guid SizeId { get; set; }
        public double Price { get; set; }
        public string Description { get; set; } = string.Empty;
        public double Stock  { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedBy { get; set; }


    }
