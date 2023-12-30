using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Pages.Admin.Products
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext context;

        public List<Product> Products { get; set; } = new List<Product>();
            public IndexModel(ApplicationDbContext context)
            {
                this.context = context;
            }

            /*public ApplicationDbContext Context { get; }*/
        public void OnGet() { 
        
            Products = context.Products.OrderByDescending(p => p.Id).ToList();
        }
    }
}
