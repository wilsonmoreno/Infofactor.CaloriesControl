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
    [Table("FoodItem")]
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar")]
        [MaxLength(500)]
        [Required]
        public string Name { get; set; }

        [Column("CaloriesPerPortion", TypeName = "int")]
        [Required]
        public int CaloriesPerPortion { get; set; }
    }
}
