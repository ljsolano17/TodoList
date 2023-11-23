using Microsoft.EntityFrameworkCore;
using Solution.DO.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Solution.DAL.EF
{
    public partial class SolutionDbContext : DbContext
    {
        public SolutionDbContext(DbContextOptions<SolutionDbContext> options) : base(options)
        {
        }
        public virtual DbSet<Tareas> Tareas { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tareas>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__Tareas__3214EC0751016A18");

                entity.Property(e => e.Descripcion).HasMaxLength(255);
                entity.Property(e => e.FechaDeCreacion).HasColumnType("datetime");
                entity.Property(e => e.FechaDeVencimiento).HasColumnType("datetime");
                entity.Property(e => e.Titulo).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

