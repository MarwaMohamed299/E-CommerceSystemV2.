using E_CommerceSystemV2.BL.DTOs.Products;
using E_CommerceSystemV2.DAL.Data.Models;
using E_CommerceSystemV2.DAL.Repos.Products;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;

namespace E_CommerceSystemV2.BL.Managers.Products
{
    public class ProductsManager : IProductsManager
    {
        private readonly IProductRepo _productsRepo;
        private readonly ILogger<Product> _logger;

        public ProductsManager(IProductRepo productsRepo, ILogger<Product> logger)
        {
            _productsRepo = productsRepo;
            _logger = logger;
        }
        public async Task<ProductPagintationDto> GetAll(int page, int countPerPage)         /*GetAll*/
        {
            try
            {
                var totalCount = await _productsRepo.GetCount();
                var items = (await _productsRepo.GetAll(page, countPerPage)).Select(e => new ProductReadDto
                {
                    ProductId = e.ProductId,
                    Name = e.Name,
                    Price = e.Price
                }).ToList();

                return new ProductPagintationDto
                {
                    TotalCount = totalCount,
                    Items = items
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while getting all Products.");
                throw;
            }
        }
        public async Task<ProductReadDto?> GetById(Guid productId)                 /*GetById*/
        {
            try
            {
                var product = await _productsRepo.GetById(productId);
                if (product == null)
                {
                    return null;
                }
                return new ProductReadDto
                {
                    ProductId = product.ProductId,
                    Name = product.Name,
                    Price = product.Price
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while getting employee with ID {productId}.");
                throw;
            }
        }
        public async Task<string> Add(ProductAddDto productAddDto)                          /*Add*/
        {
            try
            {
                var product = new Product
                {
                    Name = productAddDto.Name,
                    Price = productAddDto.Price,

                };

                await _productsRepo.Add(product);
                _productsRepo.SaveChangesAsync();
                return ("Product is added successfully ");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while adding a Product.");
                throw new InvalidOperationException("Product not found");
            }
        }

        public async Task<string?> Update(ProductUpdateDto product)                       /*Update*/
        {
            try
            {
                var existingProduct = await _productsRepo.GetById(product.ProductId);

                if (existingProduct == null)
                {
                    _logger.LogWarning($"Product with ID {product.ProductId} not found.");
                    return null;
                }

                product.Name = product.Name;
                product.Price = product.Price;

                await _productsRepo.Update(existingProduct);
                _productsRepo.SaveChangesAsync();
                return ("Product is Updated Successfully");

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Error occurred while updating Product with ID {product.ProductId}.");
                throw;
            }
        }

        public async Task<bool> Delete(Guid productId)                      /*Delete*/

        {
            try
            {
                Product? product = await _productsRepo.GetById(productId);
                if (product == null)
                {
                    return false;
                }
                await _productsRepo.Delete(product);

                _productsRepo.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a Product.");
                throw new InvalidOperationException("Product not found");
            }
        }

        public async Task<IEnumerable<ProductReadDto>> SearchWithTag(Guid tagId)                /*Search*/
        {
            try
            {
                if (tagId == default)
                {
                    _logger.LogWarning($" Search string is not valid.");
                    throw new ArgumentException("Search string is not valid.");
                }

                var searchedProducts = await _productsRepo.SearchWithTag(tagId);

                if (searchedProducts == null)
                {
                    _logger.LogWarning($"No products found for search term: {tagId}");
                    throw new ArgumentException($"No products found for search term: {tagId}");


                }
                var productReadDto = searchedProducts.Select(p => new ProductReadDto
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Price = p.Price,
                });

                return productReadDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while Searching a Product.");
                throw;

            }
        }

        public async Task<IEnumerable<ProductReadDto>> SearchWithManyTags(List<Guid> tagIds)
        {
            try
            {
                var searchedProducts = await _productsRepo.SearchWithManyTags(tagIds);

                if (searchedProducts == null)
                {
                    _logger.LogWarning($"No products found for search term: {tagIds}");
                    throw new ArgumentException($"No products found for search term: {tagIds}");

                }
                var productReadDto = searchedProducts.Select(p => new ProductReadDto
                {
                    ProductId = p.ProductId,
                    Name = p.Name,
                    Price = p.Price,
                });

                return productReadDto;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while Searching a Product.");
                throw;

            }
        }
    }
}
