using System.Text;
using Newtonsoft.Json;
using Identity.BLL;
using Identity.DAL;

namespace FlowerShop.Tests;

public class UserTest
{
    class UserModel
    {
        public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Salt { get; set; } = null!;
        public Role Role { get; set; }
    }
    enum Role
    {
        Admin,
        User
    }
    UserBll userBll = new UserBll(new UserDal());
    [Fact]
    public async Task CreateUserAsyncTest()
    {
        var model = await userBll.CreateUserAsync(new Identity.DAL.Models.UserModel()
        {
            Email = "qwe@qwe.com",
            Password = "qwe123"
        });

        Assert.NotNull(model);
        Assert.True(model.Id!=0);
    }
    
    [Fact]
    public async Task GetUserByIdAsyncTest()
    {
        var model = await userBll.GetUserByEmailAsync("qwe@qwe.com");

        Assert.NotNull(model);
        Assert.True(model.Id!=0);
        Assert.True(model.Email=="qwe@qwe.com");
    }
    
    [Fact]
    public async Task AuthenticateTest()
    {
        Assert.True(await userBll.Authenticate("qwe@qwe.com", "qwe123"));
    }
}