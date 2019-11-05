using System;
using System.ComponentModel.DataAnnotations;

namespace Segundo_Parcial.Models
{
    public class Alumno
    {
        public int Id { get; set; }
        
        [Required, MaxLength(8)]
        public string Matricula { get; set; }

        [Required, MaxLength(50)]
        public string Nombres { get; set; }
        
        [Required, MaxLength(50)]
        public string Apellidos { get; set; }

        [Required, MaxLength(100)]
        public string UnidadRegional { get; set; }

        [Required, MaxLength(200)]
        public string Carrera { get; set; }

        [Required, MaxLength(200)]
        public string Domicilio { get; set; }

        [Required]
        public DateTime FechaDeNacimiento { get; set; }

        [Required, MaxLength(200)]
        public string EscuelaDeProcedencia { get; set; }

        [Required, MaxLength(200)]
        public string CorreoElectronico { get; set; }

        [Required, MaxLength(20)]
        public string Telefono { get; set; }
    }
}