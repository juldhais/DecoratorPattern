using DecoratorPattern.Entities;

namespace DecoratorPattern.Services;

public class ActiveProductService : IProductService
{
    private readonly IProductService _productService;

    public ActiveProductService(IProductService productService)
    {
        _productService = productService;
    }
    
    public List<Product> GetAll()
    {
        var result = _productService.GetAll()
            .Where(x => x.IsActive)
            .ToList();
        
        return result;
    }
}