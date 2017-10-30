using Infofactor.CaloriesControl.DAL;
using Infofactor.CaloriesControl.DAL.Model;
using Infofactor.CaloriesControl.Repository.Base;

namespace Infofactor.CaloriesControl.Repository.Repositories
{
    public class FoodItemsRepository : Repository<FoodItem>, IFoodItemsRepository
    {
        public FoodItemsRepository(ModelContext _db) : base(_db) { }
    }
}
