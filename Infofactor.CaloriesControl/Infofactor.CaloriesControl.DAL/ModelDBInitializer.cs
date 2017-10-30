using Infofactor.CaloriesControl.DAL.Model;
using System.Collections.Generic;
using System.Data.Entity;

namespace Infofactor.CaloriesControl.DAL
{
    public class ModelDBInitializer : CreateDatabaseIfNotExists<ModelContext>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(ModelContext context)
        {
            IList<Role> defaultRoles = new List<Role>
            {
                new Role() { Name = "Client" },
                new Role() { Name = "Manager" }
            };

            foreach (var role in defaultRoles)
                context.Roles.Add(role);

            base.Seed(context);
        }
    }
}
