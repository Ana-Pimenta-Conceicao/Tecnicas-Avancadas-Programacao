using System.ComponentModel.DataAnnotations;

namespace Dominus.Models
{
    public class InstrumentoModel
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Informe o nome")] 
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Informe a marca")]
        public string? Marca { get; set; }

        [Required(ErrorMessage = "Informe seu valor")]
        public string? Valor { get; set; }
    }
}
