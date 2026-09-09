using WebApplication1.Services.IServices;

namespace WebApplication1.Services;

public class UserService : IUserService
{
    public string UserName()
    {
        return "Ace";
    }
}

