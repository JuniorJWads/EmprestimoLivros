﻿using System.ComponentModel.DataAnnotations;
using System.Data;

namespace EmprestimoLivros.Models
{
    public class EmprestimosModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Digite o nome do Recebedor!")]
        public string Recebedor { get; set; }

        [Required(ErrorMessage = "Digite o nome do Fornecedor!")]
        public string Fornecedor { get; set; }
       
        [Required(ErrorMessage = "Digite o nome do Livro emprestado!")]
        public string LivroEmprestado { get; set; }
        
        public DateTime DataUltimaAtualizacao { get; set; } = DateTime.Now;
    }
}
