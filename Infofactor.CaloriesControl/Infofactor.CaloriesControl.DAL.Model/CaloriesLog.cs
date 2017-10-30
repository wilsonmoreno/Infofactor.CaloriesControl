using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

/// <summary>
/// 
/// </summary>
namespace Infofactor.CaloriesControl.DAL.Model
{
    /// <summary>
    /// 
    /// </summary>
    [Table("CaloriesLog")]
    public class CaloriesLog
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int MealId { get; set; }

        [ForeignKey("MealId")]
        public FoodItem Meal { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public int NoPortion { get; set; }
    }
}
