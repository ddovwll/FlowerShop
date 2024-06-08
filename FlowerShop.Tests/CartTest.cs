using Cart.BLL;
using Cart.DAL;
using Cart.DAL.Models;

namespace FlowerShop.Tests;

public class CartTest
{
    private CartBll CartBll = new CartBll(new CartDal());

    [Fact]
    public async Task UpdateCartAsyncTest()
    {
        var cart = await CartBll.UpdateCartAsync(new CartModel()
        {
            Count = 12,
            ProductId = 1,
            UserId = 1
        }, 1);
        Assert.NotNull(cart);
        Assert.True(cart.Id!=0);
    }
    
    [Fact]
    public async Task GetCartByUserIdAsyncTest()
    {
        var cart = await CartBll.GetCartByUserIdAsync(1);
        Assert.NotNull(cart);
        Assert.True(cart.Count!=0);
    }
}