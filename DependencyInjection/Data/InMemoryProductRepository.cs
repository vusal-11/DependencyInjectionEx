using DependencyInjection.Models;

namespace DependencyInjection.Data;

public class InMemoryProductRepository : IProductRepository
{


    private readonly IDictionary<Guid,Product> _products
        = new Dictionary<Guid,Product>();

    public InMemoryProductRepository()
    {

        AddProduct(new Product
        {
            Name = "Coca Cola",
            Description = "Сделанно из жуков кошинель"
        }
        );
        AddProduct(new Product
        {
            Name = "Shaurma",
            Description = "Наша шаурма вчера не гавкала и не мяукала.А задавала много вопросов"
        }
       );
        AddProduct(new Product
        {
            Name = "Tea",
            Description = "Tea Tess. Delicious!"
        }
      );

    }

    public Product AddProduct(Product product)
    {
        product.Id = Guid.NewGuid();
        _products.Add(product.Id, product);
        return product;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _products.Values;

    }

}
