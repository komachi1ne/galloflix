using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace GalloFlix.Models;
[Table("AppUser")]
    public class AppUser
 {
    [Key]
    public string AppUserId { get; set; }
    [ForeignKey("AppUserId")]
    public IdentityUser UserAccount { get; set; }

    [Required]
    [StringLength(60)]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Birthday { get; set; }

    [StringLenght(300)]
    public string Photo { get; set; }
}
