using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimalapi.dominio.entidades;

public class administrador()
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; } = default!;

    [Required]
    [StringLength(255)]
    public string email { get; set; } = default!;
    [StringLength(50)]
    public string senha { get; set; } = default!;
    [StringLength(10)]
    public string perfil { get; set; } = default!;

}