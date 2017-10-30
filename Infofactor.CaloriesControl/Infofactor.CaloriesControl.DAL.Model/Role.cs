using System.Collections.Generic;
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
    [Table("Role")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar")]
        [MaxLength(500)]
        [Required]
        public string Name { get; set; }

        public ICollection<User> Users { get; set; }
    }

}
