using Microsoft.AspNetCore.Mvc;
using RepositoryAndUnitOfWork.Model;
using ReponsitoryAndUnitOfWork.Service;

namespace ReponsitoryAndUnitOfWork.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var product = _productService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public IActionResult CreateProduct(Product product)
        {
            _productService.CreateProduct(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, new { message = "Product created successfully.", product });
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            if (id != product.Id)
                return BadRequest(new { message = "Product ID mismatch." });

            _productService.UpdateProduct(product);
            return Ok(new { message = "Product updated successfully.", product });
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return Ok(new { message = "Product deleted successfully." });
        }
    }
}
