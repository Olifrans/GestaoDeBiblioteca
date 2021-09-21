﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace ControleEmprestimo.Data.Models
{
    public partial class LivroClienteEmprestimo
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? LceidLivro { get; set; }
        public int? LceidCliente { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LcedataEmprestimo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? LcedataEntrega { get; set; }
        public bool? LceEntregue { get; set; }

        [ForeignKey(nameof(LceidCliente))]
        [InverseProperty(nameof(Cliente.LivroClienteEmprestimo))]
        public virtual Cliente LceidClienteNavigation { get; set; }
        [ForeignKey(nameof(LceidLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimo))]
        public virtual Livro LceidLivroNavigation { get; set; }
    }
}