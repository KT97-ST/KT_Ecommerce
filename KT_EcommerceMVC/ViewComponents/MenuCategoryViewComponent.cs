using KT_EcommerceMVC.Data;
using KT_EcommerceMVC.wwwroot.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace KT_EcommerceMVC.ViewComponents
{
    public class MenuCategoryViewComponent: ViewComponent
    {
        private readonly KtEcommerceContext db;

        public MenuCategoryViewComponent(KtEcommerceContext context) => db = context;

        public IViewComponentResult Invoke()
        {
            var data = db.Categories.Select(c=> new MenuCategoryVM
            {
                CategoryId = c.CategoryId,
                CategoryName = c.CategoryName,
                Quantity   = c.Products.Count
            }).OrderBy(p=> p.CategoryName);

            return View(data); // Default.cshtml
        }
    }
}
