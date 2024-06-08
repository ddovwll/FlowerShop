using BonusSystem.BLL;
using BonusSystem.DAL;

namespace FlowerShop.Tests;

public class BonusTest
{
    private BonusBll BonusBll = new BonusBll(new BonusDal());

    [Fact]
    public async Task CreateAsyncTest()
    {
        var bonus = await BonusBll.CreateAsync(10);
        Assert.NotNull(bonus);
        Assert.True(bonus.Bonuses == 0 && bonus.UserId == 10);
    }

    [Fact]
    public async Task UpdateBonusesTest()
    {
        var bonus = await BonusBll.UpdateBonuses(10, 1234);
        Assert.NotNull(bonus);
        Assert.True(bonus.Bonuses == 1234 && bonus.UserId == 10);
    }
    
    [Fact]
    public async Task GetBonusAsyncTest()
    {
        var bonus = await BonusBll.GetBonusAsync(10);
        Assert.NotNull(bonus);
        Assert.True(bonus.Bonuses == 1234 && bonus.UserId == 10);
    }
}