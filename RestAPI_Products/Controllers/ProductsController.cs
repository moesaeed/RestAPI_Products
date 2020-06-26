using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RestAPI_Core.Business;
using RestAPI_Core.Contracts;
using System.Threading.Tasks;

namespace RestAPI_Products.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductBusiness _productBusiness;

        public ProductsController(IProductBusiness productBusiness)
        {
            _productBusiness = productBusiness;
        }

        // GET api/v1/products/{id}
        [HttpGet("{id}")]
        public async Task<ProductResponse> Get(long id)
        {
            return await _productBusiness.GetAsync(id);
        }

        // GET api/v1/products
        [AllowAnonymous]
        [HttpGet]
        public async Task<ProductResponse> Get()
        {
            return await _productBusiness.GetAllAsync();
        }

        // POST api/v1/products
        [ProducesResponseType(201)]
        [HttpPost]
        public async Task Post([FromBody]ProductRequest productRequest)
        {
            await _productBusiness.AddAsync(productRequest);
        }
    }
}