﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ControleEmprestimo.Data.Models
{
    public partial class GestaobibliotecaContext : DbContext
    {
        public GestaobibliotecaContext()
        {
        }

        public GestaobibliotecaContext(DbContextOptions<GestaobibliotecaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<ListarLivroClienteEmprestimo> ListarLivroClienteEmprestimo { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }
        public virtual DbSet<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;Initial Catalog=GestaoBiblioteca;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<ListarLivroClienteEmprestimo>(entity =>
            {
                entity.ToView("Listar_LivroClienteEmprestimo");
            });

            modelBuilder.Entity<LivroClienteEmprestimo>(entity =>
            {
                entity.HasOne(d => d.LceidClienteNavigation)
                    .WithMany(p => p.LivroClienteEmprestimo)
                    .HasForeignKey(d => d.LceidCliente)
                    .HasConstraintName("FK_LivroClienteEmprestimo_Cliente");

                entity.HasOne(d => d.LceidLivroNavigation)
                    .WithMany(p => p.LivroClienteEmprestimo)
                    .HasForeignKey(d => d.LceidLivro)
                    .HasConstraintName("FK_LivroClienteEmprestimo_Livro");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}