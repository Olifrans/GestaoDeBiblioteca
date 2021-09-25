﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ControleEmprestimo.Data.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("cliCPF")]
        [StringLength(50)]
        [Display(Name = "CPF")]
        public string CliCpf { get; set; }

        [Required]
        [Column("cliNome")]
        [StringLength(100)]
        [Display(Name = "Nome")]
        public string CliNome { get; set; }

        [Required]
        [Column("cliCidade")]
        [StringLength(150)]
        [Display(Name = "Cidade")]
        public string CliCidade { get; set; }

        [Required]
        [Column("cliBairro")]
        [StringLength(150)]
        [Display(Name = "Bairro")]
        public string CliBairro { get; set; }

        [Required]
        [Column("cliEndereco")]
        [StringLength(250)]
        [Display(Name = "Endereço")]
        public string CliEndereco { get; set; }

        [Required]
        [Column("cliNumero")]
        [StringLength(50)]
        [Display(Name = "Número")]
        public string CliNumero { get; set; }

        [Column("cliTelefoneCelular")]
        [StringLength(50)]
        [Display(Name = "Telefone Celular")]
        public string CliTelefoneCelular { get; set; }

        [Column("cliTelefoneFixo")]
        [StringLength(50)]
        [Display(Name = "Telefone Fixo")]
        public string CliTelefoneFixo { get; set; }

        [InverseProperty("LceidClienteNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}