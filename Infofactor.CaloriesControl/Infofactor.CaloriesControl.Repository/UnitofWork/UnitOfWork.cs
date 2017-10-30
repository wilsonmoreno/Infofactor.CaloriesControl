using Infofactor.CaloriesControl.DAL;
using Infofactor.CaloriesControl.Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infofactor.CaloriesControl.Repository.UnitofWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        public UnitOfWork()
        {
            this.context = new ModelContext();
        }
        private readonly ModelContext context;

        private UserRepository userRepository;
        public UserRepository UserRepository
        {
            get
            {
                if (this.userRepository == null)
                {
                    this.userRepository = new UserRepository(this.context);
                }
                return this.userRepository;
            }
        }

        private RoleRepository roleRepository;
        public RoleRepository RoleRepository
        {
            get
            {
                if (this.roleRepository == null)
                {
                    this.roleRepository = new RoleRepository(this.context);
                }
                return this.roleRepository;
            }
        }


        private CaloriesRepository caloriesRepository;
        public CaloriesRepository CaloriesRepository
        {
            get
            {
                if (this.caloriesRepository == null)
                {
                    this.caloriesRepository = new CaloriesRepository(this.context);
                }
                return this.caloriesRepository;
            }
        }

        private FoodItemsRepository foodItemsRepository;
        public FoodItemsRepository FoodItemsRepository
        {
            get
            {
                if (this.foodItemsRepository == null)
                {
                    this.foodItemsRepository = new FoodItemsRepository(this.context);
                }
                return this.foodItemsRepository;
            }
        }

        public async Task SaveChangesAsync()
        {
            await this.context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }

        public void Rollback()
        {
            this.context
               .ChangeTracker
                .Entries()
                .ToList()
                .ForEach(x => x.Reload());
        }

        public void Dispose()
        {
            if (this.context != null)
            {
                this.context.Dispose();
            }
        }
    }
}
