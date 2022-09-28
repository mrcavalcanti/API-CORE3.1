using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Models.Cursos
{
    public class CursoViewModelInput
    {
        [Required(ErrorMessage = "O Nome é obrigatório")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A Descrição é obrigatória")]
        public string Descricao { get; set; }
    }
}
