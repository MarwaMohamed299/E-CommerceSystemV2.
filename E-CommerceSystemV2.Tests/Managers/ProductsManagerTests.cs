using E_CommerceSystemV2.BL.Managers.Products;
using E_CommerceSystemV2.DAL.Data.Models;
using E_CommerceSystemV2.DAL.Repos.Products;
using Microsoft.Extensions.Logging;
using NSubstitute;
using Shouldly;

namespace E_CommerceSystemV2.Tests.Managers;


public class ProductsManagerTests
{
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
        var productId = Guid.NewGuid();

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

        #region Insert

        await repoMock
            .Received(1)
            .GetById(productId);

        #endregion
    }

    [Fact]
    public  async Task GetById_ShouldReturnNullWhenNotFound_Always()
    {
        #region Arrange
        var productId = Guid.NewGuid();

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

            Assert.Null(result);

        #endregion

    }

}

