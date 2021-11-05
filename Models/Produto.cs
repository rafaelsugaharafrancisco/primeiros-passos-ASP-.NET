using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCurso.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [
            Display(Name = "Descrição"),
            Required(ErrorMessage = "Campo obrigatório"),
            StringLength(15, MinimumLength = 1, ErrorMessage = "O campo deve ter entre 1 e 15")
        ]
        public string Descricao { get; set; }

        [
            Required(ErrorMessage = "Campo obrigatório"),
            Range(1, 50, ErrorMessage = "Deve ter a quantidade entre 1 e 50")
        ]
        public int Quantidade { get; set; }

        public int CategoriaId { get; set; }

        public Categoria Categoria { get; set; }
    }
}
