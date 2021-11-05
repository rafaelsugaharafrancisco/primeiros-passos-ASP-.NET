using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCurso.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        [
            Display(Name = "Descrição"), 
            Required(ErrorMessage = "Campo obrigatório"),
            StringLength(15, MinimumLength = 5, ErrorMessage = "O campo deve ter entre 5 e 15")
        ]
        public string Descricao { get; set; }

        public List<Produto> Produtos { get; set; }
    }
}
