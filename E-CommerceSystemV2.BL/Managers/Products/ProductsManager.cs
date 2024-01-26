using E_CommerceSystemV2.BL.DTOs.Products;
using E_CommerceSystemV2.DAL.Data.Models;
using E_CommerceSystemV2.DAL.Repos.Products;
using Microsoft.Extensions.Logging;
using SendGrid.Helpers.Errors.Model;
using Serilog;

namespace E_CommerceSystemV2.BL.Managers.Products;

public class ProductsManager : IProductsManager
{
    private readonly IProductRepo _productsRepo;
    private readonly ILogger<ProductsManager> _logger;

    public ProductsManager(IProductRepo productsRepo, ILogger<ProductsManager> logger)
    {
        _productsRepo = productsRepo;
        _logger = logger;
    }
    public async Task<ProductPagintationDto> GetAll(int page, int countPerPage)         /*GetAll*/
    {
        var totalCount = await _productsRepo.GetCount();
        var items = (await _productsRepo.GetAll(page, countPerPage)).Select(e => new ProductReadDto
        {
            ProductId = e.ProductId,
            Name = e.Name!,
            Price = e.Price
            
        }).ToList();

        return new ProductPagintationDto
        {
            TotalCount = totalCount,
            Items = items
        };
    }

    public async Task<ProductReadDto?> GetById(Guid productId)                 /*GetById*/
    {

        var product = await _productsRepo.GetById(productId);
        if (product == null)
        {
            return null;
        }
        return new ProductReadDto
        {
            ProductId = product.ProductId,
            Name = product.Name!,
            Price = product!.Price
        };
    }

    public async Task<string> Add(ProductAddDto productAddDto)                          /*Add*/
    {

        var product = new Product
        {
            Name = productAddDto.Name,
            Price = productAddDto.Price,
            OrderId = productAddDto.OrderId

        };

        await _productsRepo.Add(product);
         _productsRepo.SaveChangesAsync();
        return ("Product is added successfully");

    }
    public async Task<string?> Update(ProductUpdateDto product , Guid id)                       /*Update*/
    {
       var existingProduct = await _productsRepo.GetById(id);

         if (existingProduct == null)
         {
           throw new NotFoundException("product is not found");
         }
        
        existingProduct.Name = product.Name; 
        existingProduct.Price = product.Price;

        await _productsRepo.Update(existingProduct);
             _productsRepo.SaveChangesAsync();
         return ("Product is Updated Successfully");

    }
    
    public async Task<bool> Delete(Guid productId)                                    /*Delete*/

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

    public async Task<IEnumerable<ProductReadDto>> SearchWithTag(Guid tagId)                /*SearchWithTag*/
    {
        var searchedProducts = await _productsRepo.SearchWithTag(tagId);

            if (searchedProducts == null)
            {
                Log.Warning($"No products found for search term: {tagId}");
                throw new NotFoundException($"No products found for search term: {tagId}");
            }

            var productReadDto = searchedProducts.Select(p => new ProductReadDto
            {
                ProductId = p.ProductId,
                Name = p.Name!,
                Price = p.Price,
            });

            return productReadDto;
       
    }
    public async Task<IEnumerable<ProductReadDto>> SearchWithManyTags(List<Guid> tagIds)     /*SearchWithManyTag*/
    {
       var searchedProducts = await _productsRepo.SearchWithManyTags(tagIds);

            if (searchedProducts == null)
            {
                Log.Warning($"No products found for search term: {tagIds}");
                throw new NotFoundException($"No products found for search term: {tagIds}");

            }
            var productReadDto = searchedProducts.Select(p => new ProductReadDto
            {
                ProductId = p.ProductId,
                Name = p.Name!,
                Price = p.Price,
            });

            return productReadDto;
    }
    public async Task<ProductUpdateDto>UpdateProductTag(Guid productId,List<Guid>tagIds)        /*UpdateProductTags*/
    {
        try
        {
            var productToUpdate = await _productsRepo.UpdateProductTag(productId, tagIds);

            if (productToUpdate == null)
            {
                _logger.LogWarning($"No products found for search term: {productId}");
                throw new ArgumentException($"No products found for search term: {productId}");
            }

            var productUpdateDto = new ProductUpdateDto
            {
                ProductId = productId,
                TagIds = tagIds
            };
            return productUpdateDto;
        }
        catch(Exception ex)
        {
            _logger.LogError(ex, " Error occurred while Updating a Product Tags.");
            throw;
        }
    }
    public async Task<IEnumerable<ProductTagsReadDto>> GetProductTags()
    {
        try
        {
            var ProductsTags = await _productsRepo.GetProductTags();

            var products = ProductsTags.Select(p => new ProductTagsReadDto
            {
                ProductId = p.ProductId,
                Name = p.Name!,
                TagIds=p.TagProducts.Select(T=>T.Tag!.TagId).ToList()
            }).ToList();

            Log.Information("Product tags => {@products}",products);
            return products;
          
        }
        catch(Exception ex)
        {
            _logger.LogError(ex, " Error occurred while Retrieving Product Tags.");
            throw;
        }
    }
}
