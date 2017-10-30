using Infofactor.CaloriesControl.DAL;
using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.Base;
using System.Linq;

namespace Infofactor.CaloriesControl.Repository.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {

        private ModelContext db;
        public UserRepository(ModelContext _db) : base(_db)
        {
            this.db = _db;
        }

        public User GetUserByName(string userName)
        {
            return db.Users.FirstOrDefault(e => e.UserName.Equals(userName));
        }
    }
}
