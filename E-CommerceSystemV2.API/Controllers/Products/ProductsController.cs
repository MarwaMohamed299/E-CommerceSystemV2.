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
            try
            {
                throw new ApplicationException("This is a test exception to trigger the global error handler.");
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Exception occurred in TestGlobalErrorHandler");

                throw;
            }
        }

        [HttpGet("GetProductTags")]
        public async Task<ActionResult<ProductTagsReadDto>>GetProductTags()
        {
            try
            {
                var ProductTags = await _productsManager.GetProductTags();
                return Ok(ProductTags);
            }
            catch(Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, $"Error:{ex.Message}");

            }
        }

        [HttpPut("UpdateProductTags")]
        public async Task<ActionResult<ProductUpdateDto>> UpdateProductTags(Guid productId,List<Guid> tagIds)
        {
            try
            {
                var UpdatedProductTags = await _productsManager.UpdateProductTag(productId, tagIds);
                    return Ok(UpdatedProductTags);
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error:{ex.Message}");
            }
        }

        [HttpGet("SearchWithManyTag")]
        public async Task<ActionResult<IEnumerable<ProductReadDto>>> SearchWithManyTag([FromQuery] List<Guid> tagIds)
        {
            try
            {
                var searchedProducts = await _productsManager.SearchWithManyTags(tagIds);
                return Ok(searchedProducts);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");

            }
        }
        [HttpGet("{tagId}")]
        public async Task<ActionResult<IEnumerable<ProductReadDto>>> SearchWithTag(Guid tagId)
        {
            try
            {
                var searchedProducts = await _productsManager.SearchWithTag(tagId);
                return Ok(searchedProducts);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");

            }
        }
        [HttpGet("{page}/{countPerPage}")]
        public async Task<ActionResult<IEnumerable<ProductPagintationDto>>> GetAll(int page, int countPerPage)
        {
            try
            {
                var products = await _productsManager.GetAll(page, countPerPage);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<ProductReadDto>> GetById(Guid id)
        {
            try
            {
                var product = await _productsManager.GetById(id);

                if (product == null)
                    return NotFound();

                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<string>> Add([FromBody] ProductAddDto productDto)
        {
            try
            {
                var result = await _productsManager.Add(productDto);

                if (result != null)
                    return Ok("Product is Added Successfully ");
                else
                    return BadRequest("Failed to add Product");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update([FromBody] ProductUpdateDto productDto)
        {
            try
            {

                var result = await _productsManager.Update(productDto);

                if (result != null)
                    return Ok("Product is Updated Successfully ");
                else
                    return BadRequest("Failed to update Product");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            try
            {
                var isFound = await _productsManager.Delete(id);
                if (!isFound)
                {
                    return NotFound();

                }
                return Ok("Product is Deleted Successfully !!");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

    }
}
