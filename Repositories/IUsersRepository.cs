using RegisterUser.Models;

namespace RegisterUser.Repositories
{
    public interface IUsersRepository
    {
        void Add(User user);
    }
}
