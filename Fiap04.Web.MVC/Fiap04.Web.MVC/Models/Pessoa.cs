using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap04.Web.MVC.Models
{
    [Table("TPessoa")]
    public class Pessoa
    {
        [Column("Id")]
        public int PessoaId { get; set; }
        [Required,MaxLength(40)]
        public string Nome { get; set; }
        [Display(Name ="Data de nascimento")]
        public DateTime DataNascimento { get; set; }
        public int Dependentes { get; set; }
    }
}