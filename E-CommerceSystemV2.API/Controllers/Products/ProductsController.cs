using E_CommerceSystemV2.API.Exceptions;
using E_CommerceSystemV2.BL.DTOs.Products;
using E_CommerceSystemV2.BL.Managers.Products;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace E_CommerceSystemV2.API.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsManager _productsManager;

        public ProductsController(IProductsManager productsManager)
        {
            _productsManager = productsManager;
        }
        [HttpGet("TestGlobalErrorHandler")]
        public ActionResult TestGlobalErrorHandler()
        {
         throw new InternalServerError("This is a test exception to trigger the global error handler for internal server error.");
        }

        [HttpGet("GetProductTags")]
        public async Task<ActionResult<ProductTagsReadDto>>GetProductTags()
        {
             var ProductTags = await _productsManager.GetProductTags();
                return Ok(ProductTags);

        }

        [HttpPut("UpdateProductTags")]
        public async Task<ActionResult<ProductUpdateDto>> UpdateProductTags(Guid productId,List<Guid> tagIds)
        {
          var UpdatedProductTags = await _productsManager.UpdateProductTag(productId, tagIds);
                    return Ok(UpdatedProductTags);
        }
          

        [HttpGet("SearchWithManyTag")]
        public async Task<ActionResult<IEnumerable<ProductReadDto>>> SearchWithManyTag([FromQuery] List<Guid> tagIds)
        {
          var searchedProducts = await _productsManager.SearchWithManyTags(tagIds);
              return Ok(searchedProducts);
          
        }

        [HttpGet("{tagId}")]
        public async Task<ActionResult<IEnumerable<ProductReadDto>>> SearchWithTag(Guid tagId)
        {
          var searchedProducts = await _productsManager.SearchWithTag(tagId);
                return Ok(searchedProducts);
           
        }

        [HttpGet("{page}/{countPerPage}")]
        public async Task<ActionResult<IEnumerable<ProductPagintationDto>>> GetAll(int page, int countPerPage)
        {
            var products = await _productsManager.GetAll(page, countPerPage);
                return Ok(products);
           
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ProductReadDto>> GetById(Guid id)
        {
           var product = await _productsManager.GetById(id);

                if (product == null)
                    return NotFound();
                else
                return Ok(product);
        }

        [HttpPost]
        public async Task<ActionResult<string>> Add([FromBody] ProductAddDto productDto)
        {
           var result = await _productsManager.Add(productDto);

                if (result != null)
                    return Ok("Product is Added Successfully ");
                else
                    return BadRequest("Failed to add Product");
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody] ProductUpdateDto productDto)
        {
            var result = await _productsManager.Update(productDto);

             if (result != null)
                return Ok("Product is Updated Successfully ");
             else
                return BadRequest("Failed to update Product");
          
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            var isFound = await _productsManager.Delete(id);
                if (!isFound)
                {
                    return NotFound();

                }
                return Ok("Product is Deleted Successfully !!");
           
        }

    }
}
