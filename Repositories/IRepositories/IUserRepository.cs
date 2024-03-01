using SPL.Models;

namespace SPL.Repositories.IRepositories
{
    public interface IUserRepository
    {
        Task<UserInfo> GetUserInfo(string UserName);
    }
}
