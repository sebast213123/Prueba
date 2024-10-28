using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Persona
    {


        [Key]

        [StringLength(100)]
        public string Apellido { get; set; }
        [Required]
        public int Edad { get; set;}

        [Range(0, 1000)]
        public float Altura { get; set;}
        [MaxLength(100)]
        public string Id { get; set;}
        [Required]
        public DateTime Fecha { get; set;}
    }
}
