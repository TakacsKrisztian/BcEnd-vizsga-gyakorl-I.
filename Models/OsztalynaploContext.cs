using Microsoft.EntityFrameworkCore;

namespace Takács_Krisztián_backend.Models;

public partial class OsztalynaploContext : DbContext
{
    public OsztalynaploContext()
    {
    }

    public OsztalynaploContext(DbContextOptions<OsztalynaploContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Jegyek> Jegyeks { get; set; }

    public virtual DbSet<Tanarok> Tanaroks { get; set; }

    public virtual DbSet<Tantargyak> Tantargyaks { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("server=localhost;database=osztalynaplo;user=root;sslmode=none", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.32-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_hungarian_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Jegyek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("jegyek");

            entity.HasIndex(e => e.IdTanarok, "id_tanarok");

            entity.HasIndex(e => e.IdTantargyak, "id_tantargyak");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BeirasDatuma).HasColumnName("beiras_datuma");
            entity.Property(e => e.IdTanarok)
                .HasColumnType("int(11)")
                .HasColumnName("id_tanarok");
            entity.Property(e => e.IdTantargyak)
                .HasColumnType("int(11)")
                .HasColumnName("id_tantargyak");
            entity.Property(e => e.JegySzammal)
                .HasColumnType("int(1)")
                .HasColumnName("jegy_szammal");
            entity.Property(e => e.JegySzoveggel)
                .HasMaxLength(10)
                .HasColumnName("jegy_szoveggel");
            entity.Property(e => e.ModositasDatuma).HasColumnName("modositas_datuma");

            entity.HasOne(d => d.IdTanarokNavigation).WithMany(p => p.Jegyek)
                .HasForeignKey(d => d.IdTanarok)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("jegyek_ibfk_1");

            entity.HasOne(d => d.IdTantargyakNavigation).WithMany(p => p.Jegyek)
                .HasForeignKey(d => d.IdTantargyak)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("jegyek_ibfk_2");
        });

        modelBuilder.Entity<Tanarok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tanarok");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.KeresztNev)
                .HasMaxLength(30)
                .HasColumnName("kereszt_nev");
            entity.Property(e => e.Nem)
                .HasMaxLength(10)
                .HasColumnName("nem");
            entity.Property(e => e.VezetekNev)
                .HasMaxLength(30)
                .HasColumnName("vezetek_nev");
        });

        modelBuilder.Entity<Tantargyak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("tantargyak");

            entity.Property(e => e.Id)
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.TantargyLeiras)
                .HasMaxLength(50)
                .HasColumnName("tantargy_leiras");
            entity.Property(e => e.TantargyNev)
                .HasMaxLength(20)
                .HasColumnName("tantargy_nev");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}