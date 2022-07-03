using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Intrumentacao2.Models
{
    public class Instrumentos
    {

        [Key]
        [Required]
        public int Id { get; set; }

        
        [Required(ErrorMessage = "O campo Tag é obrigatório")]
        [MaxLength(60)]
        public string Tag { get; set; }

        [Required(ErrorMessage = "O campo Descricao é obrigatório")]
        [MaxLength(130)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Principio é obrigatório")]
        [MaxLength(60)]
        public string Principio { get; set; }

        [Required(ErrorMessage = "O campo Range é obrigatório")]
        public float Range { get; set; }

        [Required(ErrorMessage = "O campo Fabricante é obrigatório")]
        [MaxLength(80)]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório")]
        [MaxLength(130)]
        public string Modelo { get; set; }

        [MaxLength(60)]
        public string Protocolo { get; set; }

        public bool Quadratica { get; set; }

        

    }
}
