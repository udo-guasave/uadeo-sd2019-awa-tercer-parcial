using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Segundo_Parcial.Models
{
    public class Tutor
    {
        public int Id { get; set; }

        [Required, MaxLength(50)]
        public string Nombre { get; set; }
        
        [Required, MaxLength(50)]
        public string Apellidos { get; set; }

        [Required, MaxLength(50)]
        public string Tipo { get; set; }

        [Required]
        public int UsuarioId { get; set; }

        [NotMapped]
        public Usuario Usuario { get; set; }
    }
}