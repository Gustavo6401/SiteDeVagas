using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using GustaVagas.Domain.Entities;

namespace GustaVagas.Infra.Contexto
{
    public class VagasContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Enterprise> Enterprise { get; set; }
        public DbSet<Area> Area { get; set; }
        public DbSet<Cargo> Cargo { get; set; }
        public DbSet<CargoUser> CargoUser { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
        public DbSet<Candidatura> Candidatura { get; set; }
        public DbSet<AreaUser> AreaUser { get; set; }
        public DbSet<Formacao> Formacao { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ServicoPortaria;Trusted_Connection=True;");
        }
        public virtual void Modify(object entity)
        {
            Entry(entity).State = EntityState.Modified;
        }
    }
}
