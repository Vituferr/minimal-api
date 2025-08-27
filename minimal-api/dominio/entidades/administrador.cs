using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimalapi.dominio.entidades;

public class Administrador
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int id { get; set; } 

    [Required]
    [StringLength(255)]
    public string? email { get; set; }
    [StringLength(50)]
    [Required]
    public string? senha { get; set; }
    [StringLength(10)]
    [Required]
    public string? perfil { get; set; }

}