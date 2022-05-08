using DecoratorPattern.Services;
using Microsoft.AspNetCore.Mvc;

namespace DecoratorPattern.Controllers;

[Route("api/product")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService _productService;

    public ProductController(IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet]
    public ActionResult GetAll()
    {
        var response = _productService.GetAll();
        return Ok(response);
    }
}