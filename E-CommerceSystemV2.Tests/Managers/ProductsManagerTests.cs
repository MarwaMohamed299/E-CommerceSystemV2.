using E_CommerceSystemV2.BL.DTOs.Products;
using E_CommerceSystemV2.BL.Managers.Products;
using E_CommerceSystemV2.DAL.Data.Models;
using E_CommerceSystemV2.DAL.Repos.Products;
using Microsoft.Extensions.Logging;
using NSubstitute;
using SendGrid.Helpers.Errors.Model;
using FluentAssertions;
using Shouldly;

namespace E_CommerceSystemV2.Tests.Managers;


public class ProductsManagerTests
{
    private static Guid productId = new Guid("96A86CBF-1D2C-4925-8B86-0BAB35FD5C08");
    private static Guid tagId = new Guid("925EE134-DBFB-4DA2-9344-995E988190BE");
    private static List<Guid> tagIds = new List<Guid>(){ Guid.Parse("BDF4DBB3-2547-44D9-8B1B-AAD90DF928E3"),Guid.Parse("925EE134-DBFB-4DA2-9344-995E988190BE")};





    [Fact]
    public async Task GetAll_ShouldReturnEmptyList_WhenNoDataInDb()
    {
        #region Arrange

        int page = 1;
        int pageSize = 10;

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Mock
        var repoMock = Substitute.For<IProductRepo>();
        repoMock.GetAll(page, pageSize)
            .Returns(Enumerable.Empty<Product>());
        repoMock.GetCount()
            .Returns(0);

        // initialize the manager
        var manager = new ProductsManager(repoMock, loggerMock);

        #endregion

        #region Act

        var result = await manager.GetAll(page, pageSize);

        #endregion

        #region Assert

        //Note: Use your preferred assertion library (FluentAssertion/Shouldly)
        result.ShouldNotBeNull();
        result.Items.ShouldBeEmpty();
        result.Items.ShouldNotBeNull();
        result.TotalCount.ShouldBe(0);

        #endregion
    }

    [Fact]
    public async Task GetAll_ShouldSendCountPerPageAndPageToRepository_Always()
    {
        #region Arrange

        int page = 1;
        int pageSize = 10;

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Mock
        var repoMock = Substitute.For<IProductRepo>();

        // initialize the manager
        var manager = new ProductsManager(repoMock, loggerMock);

        #endregion

        #region Act

        var result = await manager.GetAll(page, pageSize);

        #endregion

        #region Assert

        // We make sure that these params are sent to repo from the manager
        await repoMock
            .Received(1)
            .GetAll(page, pageSize);

        #endregion
    }

    [Fact]
    public async Task GetById_ShouldReturnExistingProduct_Always()
    {
        #region Arrange

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        var expectedProduct = new Product { ProductId = productId, Name = "Sample Product", Price = 19.99M };
        repoMock.GetById(productId).Returns(expectedProduct);
        #endregion

        #region Act
        var result = await manager.GetById(productId);
        #endregion

        #region Assert

        result.ShouldNotBeNull();
        result.ProductId.Should().Be(productId); 

        #endregion
    }

    [Fact]
    public async Task GetById_ShouldReturnNull_WhenNotFound()
    {
        #region Arrange

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        // Set up the repository mock to return null when GetById is called
        repoMock.GetById(productId).Returns((Product)null!);
        #endregion

        #region Act
        var result = await manager.GetById(productId);
        #endregion

        #region Insert
        await repoMock
            .Received(1)
            .GetById(productId);

        result.ShouldBe(null);
        #endregion

    }

        [Fact]
        public async Task Update_ProductExists_ShouldReturnSuccessMessage()
        {
        #region Arrange

        var existingProduct = new Product { ProductId = productId, Name = "OldProduct", Price = 19.99m };
        var updatedProduct = new ProductUpdateDto { ProductId = productId, Name = "NewProduct", Price = 29.99m };

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);


        // Making Sure that an existing product is returned
        repoMock.GetById(productId).Returns(existingProduct);

        #endregion
        #region Act

        var result = await manager.Update(updatedProduct,productId);

        #endregion

        #region Assert

        existingProduct.Name.ShouldBe(updatedProduct.Name);
        existingProduct.Price.ShouldBe(updatedProduct.Price);
        await repoMock.Received(1).Update(existingProduct);
         repoMock.Received(1).SaveChangesAsync();

        #endregion
    }

    [Fact]
    public async Task Update_ProductDoesNotExist_ShouldThrowNotFoundException()
    {
        #region Arrange

        var productId = new Guid("F2C1DAC1-C987-4D16-815F-1142EB264212");

        var updatedProduct = new ProductUpdateDto { ProductId = productId, Name = "NewProduct", Price = 29.99m };

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        repoMock.GetById(productId).Returns((Product)null!);

        #endregion

        #region Act
        var result = await manager.GetById(productId);
        #endregion

        #region Assert
        await Should.ThrowAsync<NotFoundException>(manager.Update(updatedProduct,productId));
        #endregion
    }

    [Fact]
    public async Task SearchWithTag_ShouldReturnException_WhenNoProductsFound()
    {
        #region Arrange

        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        // Mock the repository's SearchWithTag method to return null, simulating no products found
        repoMock.SearchWithTag(tagId).Returns((List<Product>)null!);

        #endregion

        #region Act
        var result = await manager.GetById(tagId);
        #endregion

        #region Assert
        await Should.ThrowAsync<NotFoundException>(manager.SearchWithTag(tagId));

        #endregion

    }

    [Fact]
    public async Task SearchWithTag_ProductsFound_ReturnsProductReadDtos()
    {
        #region Arrange
        var tagId = new Guid("925EE134-DBFB-4DA2-9344-995E988190BE");

        var mockedProducts = new List<Product>
        {
            new Product { ProductId = Guid.NewGuid(), Name = "shoes", Price = 19.99m },
            new Product { ProductId = Guid.NewGuid(), Name = "mobiles", Price = 29.99m },
        };
        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        repoMock.SearchWithTag(tagId).Returns(mockedProducts);

        #endregion

        #region Act
        var result = await manager.SearchWithTag(tagId);
        #endregion

        #region Assert
        result.ShouldNotBeEmpty();
        result.ShouldNotBeNull();
        #endregion
    }

    [Fact]
    public async Task SearchWithManyTags_ShouldReturnNotFoundException_WhenProductsNotFound()
    {

        #region Arrange
        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();

        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        // Mock the repository's SearchWithTag method to return null, simulating no products found
        repoMock.SearchWithManyTags(tagIds).Returns((List<Product>)null!);

        #endregion

        #region Act
        var result = await manager.GetById(tagId);
        #endregion

        #region Assert
        await Should.ThrowAsync<NotFoundException>(manager.SearchWithManyTags(tagIds));

        #endregion

    }

    [Fact]
    public async Task SearchWithManyTags_ShouldReturnsProductsReadDto_Always()
    {
        var mockedProducts = new List<Product>
        {
            new Product { ProductId = Guid.NewGuid(), Name = "shoes", Price = 19.99m },
            new Product { ProductId = Guid.NewGuid(), Name = "mobiles", Price = 29.99m },
        };
        #region Arrange
        // Mock ILogger
        var loggerMock = Substitute.For<ILogger<ProductsManager>>();
        // Repository Logger
        var repoMock = Substitute.For<IProductRepo>();

        // Initialize the Manager
        var manager = new ProductsManager(repoMock, loggerMock);

        repoMock.SearchWithManyTags(tagIds).Returns(mockedProducts);

        #endregion

        #region Act

        var result = await manager.SearchWithManyTags(tagIds);

        #endregion

        #region Assert

        result.ShouldNotBe(null);
        result.ShouldNotBeEmpty();
        #endregion


    }
}
//#region Arrange
//#endregion
//#region Act
//#endregion
//#region Assert
//#endregion
