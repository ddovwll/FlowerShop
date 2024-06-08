using Goods.BLL;
using Goods.DAL;
using Goods.DAL.Models;

namespace FlowerShop.Tests;

public class ProductTest
{
    private ProductBll ProductBll = new ProductBll(new ProductDal());
    
    [Fact]
    public async Task CreateProductAsyncTest()
    {
        var product = await ProductBll.CreateProductAsync(new Product()
        {
            Name = "qwe",
            Kind = "qwe",
            Description = "qwe",
            Price = 125,
            Count = 12
        });
        Assert.NotNull(product);
        Assert.True(product.Id!=0);
    }

    [Fact]
    public async Task GetProductsAsyncTest()
    {
        var product = await ProductBll.GetProductsAsync();
        Assert.NotNull(product);
        Assert.True(product.Count!=0);
    }

    [Fact]
    public async Task DeleteProductAsyncTest()
    {
        var product = await ProductBll.CreateProductAsync(new Product()
        {
            Name = "qwe",
            Kind = "qwe",
            Description = "qwe",
            Price = 125,
            Count = 12
        });
        Assert.NotNull(product);
        Assert.True(product.Id!=0);

        await ProductBll.DeleteProductAsync(product.Id);
    }
}