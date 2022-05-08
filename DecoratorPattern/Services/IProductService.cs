using DecoratorPattern.Entities;

namespace DecoratorPattern.Services;

public interface IProductService
{
    List<Product> GetAll();
}