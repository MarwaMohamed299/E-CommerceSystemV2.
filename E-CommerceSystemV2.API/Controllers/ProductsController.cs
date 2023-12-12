﻿using E_CommerceSystemV2.BL.DTOs.Products;
using E_CommerceSystemV2.BL.Managers.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_CommerceSystemV2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsManager _productsManager;

        public ProductsController(IProductsManager productsManager)
        {
            _productsManager = productsManager ?? throw new ArgumentNullException(nameof(productsManager));
        }
        [HttpGet("{page}/{countPerPage}")]
        public async Task<ActionResult<IEnumerable<ProductPagintationDto>>> GetAll(int page , int pagePerCount)
        {
            try
            {
                var products = await _productsManager.GetAll(page,pagePerCount);
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductReadDto>> GetById(int id)
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
                    return BadRequest("Failed to update eProduct");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

        [HttpDelete ("{id}")]
        public async Task <ActionResult> Delete(int id)
        {
            try
            {
                var isFound = await _productsManager.Delete(id);
                if (!isFound )
                {
                    return NotFound();

                }
                return NoContent();
            }
            catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error: {ex.Message}");
            }
        }

    }
}
