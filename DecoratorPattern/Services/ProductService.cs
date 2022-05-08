using DecoratorPattern.Entities;

namespace DecoratorPattern.Services;

public class ProductService : IProductService
{
    public List<Product> GetAll()
    {
        return new List<Product>
        {
            new() { Id = 1, Code = "P01", IsActive = true },
            new() { Id = 2, Code = "P02", IsActive = true },
            new() { Id = 3, Code = "P03", IsActive = true },
            new() { Id = 4, Code = "P05", IsActive = false },
            new() { Id = 5, Code = "P05", IsActive = false },
        };
    }
}