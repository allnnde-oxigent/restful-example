using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ResfulExample.Entities;

namespace ResfulExample.Context;

public partial class OxigentContext : DbContext
{
    public OxigentContext()
    {
    }

    public OxigentContext(DbContextOptions<OxigentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employer> Employers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=oxigent;User Id=sa;Password=Sql1234.;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employer__3214EC072A392A21");

            entity.ToTable("Employer");

            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumbre)
                .HasMaxLength(150)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
