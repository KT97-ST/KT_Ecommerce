namespace KT_EcommerceMVC.ViewModels
{
    public class ProductsVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Image { get; set; }
    
        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }


    }

    public class ProductDetailVM
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string Image { get; set; }

        public double UnitPrice { get; set; }
        public string Description { get; set; }
        public string UnitDescription { get; set; }
        public string CategoryName { get; set; }
        public int InventoryNumber { get; set; }

        public int Rate { get; set; }   

      
    }
}
