using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.Base.Contract;
using System.Collections.Generic;

namespace Infofactor.CaloriesControl.Repository.Repositories
{
    public interface ICaloriesRepository : IRepository<CaloriesLog>
    {
        List<CaloriesLog> GetCaloriesPerUser(int userId);
    }
}
