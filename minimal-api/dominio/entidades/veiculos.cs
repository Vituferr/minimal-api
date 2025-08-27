using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimalapi.dominio.entidades;


public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; }

    [Required]
    [StringLength(255)]
    public string? nome { get; set; }

    [StringLength(50)]
    [Required]
    public string? marca { get; set; }

    [StringLength(10)]
    [Required]
    public string? ano { get; set; }

}