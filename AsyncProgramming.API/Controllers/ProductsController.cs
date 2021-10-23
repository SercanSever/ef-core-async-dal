using AsyncProgramming.Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncProgramming.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("getProducts")]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetAll();
            return Ok(products);
        }
        [HttpGet("getproductbycategoryname")]
        public async Task<IActionResult> GetProductsByCategoryName(string name)
        {
            var products = await _productService.GetByCategoryName(name);
            return Ok(products);
        }
    }
}
