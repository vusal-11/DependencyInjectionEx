using DependencyInjection.Models;
using DependencyInjection.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DependencyInjection.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ProductService _service; 

        public IndexModel(ProductService service)
        {
            _service = service;
        }

        public void OnGet()
        {
            var products = _service.GetProducts();
            ViewData["Products"] = products;
        }


        public void OnPost(Product product)
        {

            _service.AddProduct(product);
            //var products = _service.GetProducts();
            //ViewData["Products"] = products;
            OnGet();

        }


    }
}