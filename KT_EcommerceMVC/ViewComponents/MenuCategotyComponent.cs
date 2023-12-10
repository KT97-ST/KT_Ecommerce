using KT_EcommerceMVC.Data;
using Microsoft.AspNetCore.Mvc;

namespace KT_EcommerceMVC.ViewComponents
{
    public class MenuCategotyComponent: ViewComponent
    {
        private readonly KtEcommerceContext db;

        public MenuCategotyComponent(KtEcommerceContext context) => db = context;

        //public IViewComponentResult Invoke()
        //{
        //    //var data = db.Categories.Select(c => new
        //    //{
        //    //    c.CategoryCode, c.CategoryName, Quantity = c.Products.Count
        //    //});
        //}
    }
}
