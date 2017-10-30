using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Infofactor.CaloriesControl.Models
{
    public class CaloriesLog
    {
        public int Id { get; set; }

        
        public int UserId { get; set; }


        public User User { get; set; }

        
        public int MealId { get; set; }

        public FoodItem Meal { get; set; }

        
        public DateTime Date { get; set; }

        
        public int NoPortion { get; set; }
    }
}