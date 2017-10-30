using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infofactor.CaloriesControl.Models
{
    public class FoodItem
    {
        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public int CaloriesPerPortion { get; set; }
    }
}