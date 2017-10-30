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
    [Table("User")]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Column("Name", TypeName = "varchar")]
        [MaxLength(500)]
        [Required]
        public string Name { get; set; }

        [Column("UserName", TypeName = "varchar")]
        [MaxLength(200)]
        [Required]
        [Index("IX_UserName", 1, IsUnique = true)]
        public string UserName { get; set; }

        [Required]
        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }

    }
}
