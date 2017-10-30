using Infofactor.CaloriesControl.DAL;
using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.Base;

namespace Infofactor.CaloriesControl.Repository.Repositories
{
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(ModelContext _db) : base(_db) { }
    }
}
