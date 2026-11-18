using System;
using System.Collections.Generic;
using Clase11.Models;
using Microsoft.EntityFrameworkCore;

namespace Clase11.Data;

public partial class ApiGestionPersonasContext : DbContext
{
    public ApiGestionPersonasContext(DbContextOptions<ApiGestionPersonasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Persona> Personas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Persona>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personas__3214EC075032AC7E");

            entity.Property(e => e.Nombre).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
