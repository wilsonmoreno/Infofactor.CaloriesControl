using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.Base.Contract;

namespace Infofactor.CaloriesControl.Repository.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        //Custom or additional functions
        User GetUserByName(string userName);
    }
}
