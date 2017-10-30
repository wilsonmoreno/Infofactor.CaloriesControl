using Infofactor.CaloriesControl.DAL;
using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.Base;
using System.Collections.Generic;
using System.Linq;

namespace Infofactor.CaloriesControl.Repository.Repositories
{
    public class CaloriesRepository : Repository<CaloriesLog>, ICaloriesRepository
    {
        private ModelContext db;
        public CaloriesRepository(ModelContext _db) : base(_db)
        {
            this.db = _db;
        }

        public List<CaloriesLog> GetCaloriesPerUser(int userId)
        {
            return this.db.CaloriesLog.Where(e => e.UserId == userId).ToList();
        }
    }
}
