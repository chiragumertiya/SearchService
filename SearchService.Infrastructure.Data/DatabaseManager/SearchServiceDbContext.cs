using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace SearchService.Infrastructure.Data.DatabaseManager;

public partial class SearchServiceDbContext : DbContext
{
    public SearchServiceDbContext()
    {
    }

    public SearchServiceDbContext(DbContextOptions<SearchServiceDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblPerson> TblPeople { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=SearchServiceDb;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblPerson>(entity =>
        {
            entity.ToTable("tbl_Person");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
