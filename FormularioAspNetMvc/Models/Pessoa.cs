using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace FormularioAspNetMvc.Models
{
    public class Pessoa
    {
        [Key]
        [Required(ErrorMessage = "Preencha o CPF.")]
        [Remote("ValidarCPF", "Pessoas", ErrorMessage = "Esse CPF já foi cadastrado.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Preencha o nome completo.")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "E-mail Inválido!")]
        [MaxLength(100, ErrorMessage = "O nome deve ter até {1} caracteres.")]
        public string Email { get; set; }
    }
}