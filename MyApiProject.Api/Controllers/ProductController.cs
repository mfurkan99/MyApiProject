using MediatR;
using Microsoft.AspNetCore.Mvc;
using MyApiProject.Core.Features.Products.Queries;
using MyApiProject.Coree.Features.Brands.Command.CreateBrand;
using MyApiProject.Coree.Features.Brands.Queries;
using MyApiProject.Coree.Features.Products.Command.CreateProduct;
using MyApiProject.Coree.Features.Products.Command.DeleteProduct;
using MyApiProject.Coree.Features.Products.Command.UpdateProduct;

namespace MyApiProject.Api.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : Controller
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductsQueryRequest());
            return Ok(response);
        }

        [HttpPost]

        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpPost]

        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpPost]

        public async Task<IActionResult> DeleteProduct(DeleteProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpPost]

        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBrands()
        {
            var response = await mediator.Send(new GetAllBrandsQueryRequest());
            return Ok(response);
        }

    }
}
