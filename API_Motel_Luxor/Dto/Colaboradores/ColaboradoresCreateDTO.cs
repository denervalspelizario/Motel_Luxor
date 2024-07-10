﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Motel_Luxor.Dto.Colaboradores
{
    public class ColaboradoresCreateDTO
    {
        [Required(ErrorMessage = "O nome do colaborador é obrigatório.")]
        public string Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime Data_nascimento { get; set; }

        [Required(ErrorMessage = "O cpf do colaborador é obrigatório.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "O endereço do colaborador é obrigatório.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "O telefone do colaborador é obrigatório.")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O email do colaborador é obrigatório.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O cargo do colaborador é obrigatório.")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "O salario do colaborador é obrigatório.")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "O departamento do colaborador é obrigatório.")]
        public string Departamento { get; set; }
    }
}