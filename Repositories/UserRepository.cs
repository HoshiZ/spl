using SPL.Models;
using SPL.Repositories.IRepositories;

namespace SPL.Repositories
{
    public class UserRepository : IUserRepository
    {
        public Task<UserInfo> GetUserInfo(string UserName)
        {
            throw new NotImplementedException();
        }
    }
}
