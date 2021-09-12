﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

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
        [Column("cpf")]
        [StringLength(50)]
        public string Cpf { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(100)]
        public string Nome { get; set; }
        [Required]
        [Column("cidade")]
        [StringLength(150)]
        public string Cidade { get; set; }
        [Required]
        [Column("bairro")]
        [StringLength(150)]
        public string Bairro { get; set; }

        [InverseProperty("IdClienteNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}