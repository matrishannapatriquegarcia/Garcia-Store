namespace Garcia_Midterm_Store.Models
{
    public class CartItem
    {
        public int Id { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int Quantity { get; set; }
    }
}