using DependencyInjection.Data;
using DependencyInjection.Models;

namespace DependencyInjection.Services;

public class ProductService
{

    private readonly IProductRepository _repository;

    public ProductService(IProductRepository repository)
    {
        _repository = repository;        
    }

    public Product AddProduct(Product product)
    {
        return _repository.AddProduct(product);
    }

    public IEnumerable<Product> GetProducts()
    {

        return _repository.GetProducts();

    }


}
