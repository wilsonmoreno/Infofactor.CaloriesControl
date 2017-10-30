using Infofactor.CaloriesControl.Repository.Repositories;
using System.Threading.Tasks;

namespace Infofactor.CaloriesControl.Repository.UnitofWork
{
    public interface IUnitOfWork
    {
        UserRepository UserRepository { get; }
        RoleRepository RoleRepository { get; }
        CaloriesRepository CaloriesRepository { get; }
        FoodItemsRepository FoodItemsRepository { get; }
        Task SaveChangesAsync();
        void SaveChanges();
        void Rollback();
    }
}
