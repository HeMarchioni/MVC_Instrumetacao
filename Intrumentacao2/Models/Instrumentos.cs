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
        [MaxLength(60, ErrorMessage = "Numero maximo de 60 caracteres")]
        public string Tag { get; set; }

        [Required(ErrorMessage = "O campo Descricao é obrigatório")]
        [MaxLength(130, ErrorMessage = "Numero maximo de 130 caracteres")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O campo Principio é obrigatório")]
        [MaxLength(60, ErrorMessage = "Numero maximo de 60 caracteres")]
        public string Principio { get; set; }

        [Required(ErrorMessage = "O campo Range é obrigatório")]
        [MaxLength(60, ErrorMessage = "Numero maximo de 60 caracteres")]
        public String Range { get; set; }

        [Required(ErrorMessage = "O campo Fabricante é obrigatório")]
        [MaxLength(80, ErrorMessage = "Numero maximo de 80 caracteres")]
        public string Fabricante { get; set; }

        [Required(ErrorMessage = "O campo Modelo é obrigatório")]
        [MaxLength(130, ErrorMessage = "Numero maximo de 130 caracteres")]
        public string Modelo { get; set; }

        [MaxLength(60, ErrorMessage = "Numero maximo de 60 caracteres")]
        public string Protocolo { get; set; }

        public bool Quadratica { get; set; }

        

    }
}
