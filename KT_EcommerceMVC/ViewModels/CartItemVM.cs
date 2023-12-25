namespace KT_EcommerceMVC.ViewModels
{
    public class CartItemVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Image { get; set; }

        public double UnitPrice { get; set; }

        public int Quantity { get; set; }

        public double Amount => UnitPrice * Quantity;
    }
}
