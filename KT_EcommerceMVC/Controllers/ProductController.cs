using KT_EcommerceMVC.Data;
using KT_EcommerceMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KT_EcommerceMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly KtEcommerceContext _context;
        public ProductController(KtEcommerceContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? category)
        {
            var products = _context.Products.AsQueryable();
            if (category.HasValue)
            {
                products = products.Where(p=>p.CategoryId == category.Value);
            }
            var result = products.Select(p => new ProductsVM { 
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice ?? 0,
                Image = p.Image ?? "",
                Description = p.Description ?? "",
                CategoryName = p.Category.CategoryName

            });
            return View(result);
        }

        public IActionResult Search(string? query)
        {
            var products = _context.Products.AsQueryable();
            if (query != null)
            {
                products = products.Where(p => p.ProductName.Contains(query));
            }
            var result = products.Select(p => new ProductsVM
            {
                ProductId = p.ProductId,
                ProductName = p.ProductName,
                UnitPrice = p.UnitPrice ?? 0,
                Image = p.Image ?? "",
                Description = p.Description ?? "",
                CategoryName = p.Category.CategoryName

            });
            return View(result);
        }
        public IActionResult Detail(int id)
        {
            var data = _context.Products
                .Include(p=> p.Category)
                .SingleOrDefault(p => p.ProductId == id);
            if(data == null)
            {
                TempData["Message"] = $"Không tìm thấy sản phẩm có mã {id}";
                return Redirect("/404");
            }

            var result = new ProductDetailVM
            {
                ProductId = id,
                ProductName = data.ProductName,
                UnitPrice = data.UnitPrice ?? 0,
                Image = data.Image ?? "",
                UnitDescription = data.UnitDescription ?? "",
                Description = data.Description ?? "",
                CategoryName = data.Category.CategoryName ?? "",
                InventoryNumber = 10,
                Rate = 5

            };
            return View(result);
        }
    }
}
