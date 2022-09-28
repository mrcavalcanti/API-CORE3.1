using System.ComponentModel.DataAnnotations;

namespace curso.api.Models.Cursos
{
    public class CursoViewModelOutput
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Descrição é obrigatória")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "O Login é obrigatório")]
        public string Login { get; set; }
    }
}
