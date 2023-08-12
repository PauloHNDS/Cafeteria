using Cafeteria.Business;
using Microsoft.EntityFrameworkCore;

namespace Cafeteria.Repository.Context
{
    public class Contexto : DbContext
    {
        public DbSet<Contato> Contatos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Estrutura> Estruturas { get; set; }

        public DbSet<Variacao> Variacaos { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Alimento> Alimentos { get; set; }

        public Contexto(DbContextOptions<Contexto> opcao) : base(opcao) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Contato

            modelBuilder.Entity<Contato>(t =>
            {
                t.ToTable("CONTATO");

                t.HasKey(x => x.Id);

                t.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

                t.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Email)
                .IsRequired(false)
                .HasDefaultValue(string.Empty)
                .HasColumnName("EMAIL")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Celular)
                .IsRequired(true)
                .HasColumnName("CELULAR")
                .HasColumnType("varchar(11)");

            });

            #endregion

            #region Usuario

            modelBuilder.Entity<Usuario>(t =>
            {
                t.ToTable("USUARIO");

                t.HasKey(x => x.Id);

                t.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

                t.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Login)
                .IsRequired(true)
                .HasColumnName("LOGIN")
                .HasColumnType("varchar(20)");

                t.Property(x => x.Senha)
                .IsRequired(true)
                .HasColumnName("SENHA")
                .HasColumnType("varchar(10)");

            });

            #endregion

            #region Estrutura

            modelBuilder.Entity<Estrutura>(t =>
            {
                t.ToTable("ESTRUTURA");

                t.HasKey(x => x.Id);

                t.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

                t.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Descricao)
                .IsRequired(false)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Imagem)
                .IsRequired(false)
                .HasColumnName("IMAGEM")
                .HasColumnType("varchar(100)");

            });
            #endregion

            #region Varicao

            modelBuilder.Entity<Variacao>(t =>
            {
                t.ToTable("VARIACAO");

                t.HasKey(x => x.Id);

                t.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

                t.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Imagem)
                .IsRequired(false)
                .HasColumnName("IMAGEM")
                .HasColumnType("varchar(100)");

                t.HasOne(x => x.Alimento)
                .WithMany(x => x.Variacaos)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();


            });

            #endregion

            #region Alimento

            modelBuilder.Entity<Alimento>(t =>
            {
                t.ToTable("VARIACAO");

                t.HasKey(x => x.Id);

                t.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

                t.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");


                t.Property(x => x.Descricao)
                .IsRequired(false)
                .HasColumnName("DESCRICAO")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Valor)
                .IsRequired(true)
                .HasColumnName("VALOR")
                .HasColumnType("decimal(12,4)");

                t.HasOne(x => x.Categoria)
                .WithMany(x => x.Alimentos)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired(true);

            });

            #endregion

            #region Categoria

            modelBuilder.Entity<Categoria>(t =>
            {
                t.ToTable("CATEGORIA");

                t.HasKey(x => x.Id);

                t.Property(x => x.Id)
                .IsRequired(true)
                .HasColumnName("ID")
                .HasColumnType("int")
                .ValueGeneratedOnAdd();

                t.Property(x => x.Nome)
                .IsRequired(true)
                .HasColumnName("NOME")
                .HasColumnType("varchar(100)");

                t.Property(x => x.Imagem)
                .IsRequired(false)
                .HasColumnName("IMAGEM")
                .HasColumnType("varchar(100)");

            });

            #endregion
        }
    }

}
