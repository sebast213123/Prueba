using System.ComponentModel.DataAnnotations;

namespace Prueba.Models
{
    public class Celular
    {
        [Key]
        [Range(0, 1000)]
        public int Id { get; set; }
        [Required]
        [StringLength(500)]

        public string Modelo { get; set; }
        [Required]
        [MaxLength(2024)]
        public int Año { get; set; }
        [Required]
        [Range (0, 100000)]
        public int Precio { get; set; }
          

    }
}
