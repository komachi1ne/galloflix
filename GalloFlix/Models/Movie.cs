using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GalloFlix.Models;

[Table("Movie")]
public class Movie
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }
    [Display(Name = "Título Original")]
    [Required(ErrorMessage = "Informe o título original")]
    [StringLength(100, ErrorMessage = "O título original deve possuir até 100 caracteres")]
    public string OriginalTitle { get; set; }

    [Display(Name = "Título")]
    [Required(ErrorMessage = "Informe o título")]
    [StringLength(100, ErrorMessage = "O título deve possuir até 100 caracteres")]
    public string Title { get; set; }

    [Display(Name = "Sinopse")]
    [StringLength(8000, ErrorMessage = "A sinopse deve possuir até 8000 caracteres")]
    public string Synopsis { get; set; }

    [Column(TypeName = "Year")]
    [Display(Name = "Ano de Estreia")]
    [Required(ErrorMessage = "Informe o ano de estreia")]
    public Int16 MovieYear { get; set; }
}