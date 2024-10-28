using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        [ForeignKey(nameof(Id))]
        [Required]
        public DateTime Fecha { get; set;}
    }
}
