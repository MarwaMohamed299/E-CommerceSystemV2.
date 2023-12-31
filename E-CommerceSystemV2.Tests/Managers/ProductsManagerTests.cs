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
}

