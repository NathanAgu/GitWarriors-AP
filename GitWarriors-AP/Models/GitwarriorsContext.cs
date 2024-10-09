using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace GitWarriors_AP.Models;

public partial class GitwarriorsContext : DbContext
{
    public GitwarriorsContext()
    {
    }

    public GitwarriorsContext(DbContextOptions<GitwarriorsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Etat> Etats { get; set; }

    public virtual DbSet<Famille> Familles { get; set; }

    public virtual DbSet<Fichefrai> Fichefrais { get; set; }

    public virtual DbSet<FraisForfait> FraisForfaits { get; set; }

    public virtual DbSet<Laboratoire> Laboratoires { get; set; }

    public virtual DbSet<LigneFraisForfait> LigneFraisForfaits { get; set; }

    public virtual DbSet<LigneFraisHorsForfait> LigneFraisHorsForfaits { get; set; }

    public virtual DbSet<Medecin> Medecins { get; set; }

    public virtual DbSet<Medicament> Medicaments { get; set; }

    public virtual DbSet<Motif> Motifs { get; set; }

    public virtual DbSet<Offrir> Offrirs { get; set; }

    public virtual DbSet<Rapport> Rapports { get; set; }

    public virtual DbSet<Region> Regions { get; set; }

    public virtual DbSet<Secteur> Secteurs { get; set; }

    public virtual DbSet<Specialite> Specialites { get; set; }

    public virtual DbSet<Visiteur> Visiteurs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=SRV-SGBD\\SQLSERVERGLOBAL;Initial Catalog=gitwarriors;User ID=gitwarriors;Password=gitwarriors;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Etat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Etat__3213E83F1E70707A");

            entity.ToTable("Etat");

            entity.Property(e => e.Id)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Libelle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("libelle");
        });

        modelBuilder.Entity<Famille>(entity =>
        {
            entity.HasKey(e => e.IdFamille).HasName("PK__FAMILLE__CC8A49783882106F");

            entity.ToTable("FAMILLE");

            entity.Property(e => e.IdFamille)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idFamille");
            entity.Property(e => e.LibFamille)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("libFamille");
        });

        modelBuilder.Entity<Fichefrai>(entity =>
        {
            entity.HasKey(e => new { e.IdVisiteur, e.Mois }).HasName("PK__fichefra__EDD484AED3A9507F");

            entity.ToTable("fichefrais");

            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Mois)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mois");
            entity.Property(e => e.DateModif)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("dateModif");
            entity.Property(e => e.IdEtat)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("CR")
                .IsFixedLength()
                .HasColumnName("idEtat");
            entity.Property(e => e.MontantValide)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montantValide");
            entity.Property(e => e.NbJustificatifs)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("nbJustificatifs");

            entity.HasOne(d => d.IdEtatNavigation).WithMany(p => p.Fichefrais)
                .HasForeignKey(d => d.IdEtat)
                .HasConstraintName("FK__fichefrai__idEta__534D60F1");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Fichefrais)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__fichefrai__idVis__5441852A");
        });

        modelBuilder.Entity<FraisForfait>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FraisFor__3213E83FC514F302");

            entity.ToTable("FraisForfait");

            entity.Property(e => e.Id)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("id");
            entity.Property(e => e.Libelle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .IsFixedLength()
                .HasColumnName("libelle");
            entity.Property(e => e.Montant)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("montant");
        });

        modelBuilder.Entity<Laboratoire>(entity =>
        {
            entity.HasKey(e => e.IdLabo);

            entity.ToTable("Laboratoire");

            entity.Property(e => e.IdLabo).HasColumnName("idLabo");
            entity.Property(e => e.NomLabo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("nomLabo");
        });

        modelBuilder.Entity<LigneFraisForfait>(entity =>
        {
            entity.HasKey(e => new { e.IdVisiteur, e.Mois, e.IdFraisForfait }).HasName("PK__LigneFra__9BB2656B428CAAEA");

            entity.ToTable("LigneFraisForfait");

            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Mois)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mois");
            entity.Property(e => e.IdFraisForfait)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idFraisForfait");
            entity.Property(e => e.Quantite)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("quantite");

            entity.HasOne(d => d.IdFraisForfaitNavigation).WithMany(p => p.LigneFraisForfaits)
                .HasForeignKey(d => d.IdFraisForfait)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneFrai__idFra__59063A47");

            entity.HasOne(d => d.Fichefrai).WithMany(p => p.LigneFraisForfaits)
                .HasForeignKey(d => new { d.IdVisiteur, d.Mois })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneFraisForfai__5812160E");
        });

        modelBuilder.Entity<LigneFraisHorsForfait>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LigneFra__3213E83FA46211B6");

            entity.ToTable("LigneFraisHorsForfait");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Date)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("date");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Libelle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("(NULL)")
                .HasColumnName("libelle");
            entity.Property(e => e.Mois)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("mois");
            entity.Property(e => e.Montant)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("montant");

            entity.HasOne(d => d.Fichefrai).WithMany(p => p.LigneFraisHorsForfaits)
                .HasForeignKey(d => new { d.IdVisiteur, d.Mois })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__LigneFraisHorsFo__5EBF139D");
        });

        modelBuilder.Entity<Medecin>(entity =>
        {
            entity.HasKey(e => e.IdMedecin).HasName("PK__MEDECIN__180DFB727C854114");

            entity.ToTable("MEDECIN");

            entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");
            entity.Property(e => e.Adresse)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasColumnName("adresse");
            entity.Property(e => e.Departement).HasColumnName("departement");
            entity.Property(e => e.IdSpecialite)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idSpecialite");
            entity.Property(e => e.Nom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Prenom)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Tel)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("tel");

            entity.HasOne(d => d.IdSpecialiteNavigation).WithMany(p => p.Medecins)
                .HasForeignKey(d => d.IdSpecialite)
                .HasConstraintName("medecin_fk");
        });

        modelBuilder.Entity<Medicament>(entity =>
        {
            entity.HasKey(e => e.IdMedicament).HasName("PK__MEDICAME__1A803189D3E6E377");

            entity.ToTable("MEDICAMENT");

            entity.Property(e => e.IdMedicament)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idMedicament");
            entity.Property(e => e.Composition)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("composition");
            entity.Property(e => e.ContreIndications)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("contreIndications");
            entity.Property(e => e.Effets)
                .HasMaxLength(256)
                .IsUnicode(false)
                .HasColumnName("effets");
            entity.Property(e => e.IdFamille)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idFamille");
            entity.Property(e => e.NomCommercial)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("nomCommercial");

            entity.HasOne(d => d.IdFamilleNavigation).WithMany(p => p.Medicaments)
                .HasForeignKey(d => d.IdFamille)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("medicament_fk");
        });

        modelBuilder.Entity<Motif>(entity =>
        {
            entity.HasKey(e => e.IdMotif).HasName("PK__MOTIF__186EF2C3C9225C8F");

            entity.ToTable("MOTIF");

            entity.Property(e => e.IdMotif).HasColumnName("idMotif");
            entity.Property(e => e.LibMotif)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libMotif");
        });

        modelBuilder.Entity<Offrir>(entity =>
        {
            entity.HasKey(e => new { e.IdRapport, e.IdMedicament }).HasName("PK__OFFRIR__8E6CD178D98BAC6D");

            entity.ToTable("OFFRIR");

            entity.Property(e => e.IdRapport).HasColumnName("idRapport");
            entity.Property(e => e.IdMedicament)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idMedicament");
            entity.Property(e => e.Quantite).HasColumnName("quantite");

            entity.HasOne(d => d.IdMedicamentNavigation).WithMany(p => p.Offrirs)
                .HasForeignKey(d => d.IdMedicament)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("offrir_fk2");

            entity.HasOne(d => d.IdRapportNavigation).WithMany(p => p.Offrirs)
                .HasForeignKey(d => d.IdRapport)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("offrir_fk1");
        });

        modelBuilder.Entity<Rapport>(entity =>
        {
            entity.HasKey(e => e.IdRapport).HasName("PK__RAPPORT__0FC4D260FD6F30FA");

            entity.ToTable("RAPPORT");

            entity.Property(e => e.IdRapport).HasColumnName("idRapport");
            entity.Property(e => e.Bilan)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("bilan");
            entity.Property(e => e.DateRapport).HasColumnName("dateRapport");
            entity.Property(e => e.IdMedecin).HasColumnName("idMedecin");
            entity.Property(e => e.IdMotif).HasColumnName("idMotif");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");

            entity.HasOne(d => d.IdMedecinNavigation).WithMany(p => p.Rapports)
                .HasForeignKey(d => d.IdMedecin)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rapport_fk2");

            entity.HasOne(d => d.IdMotifNavigation).WithMany(p => p.Rapports)
                .HasForeignKey(d => d.IdMotif)
                .HasConstraintName("rapport_fk3");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Rapports)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("rapport_fk1");
        });

        modelBuilder.Entity<Region>(entity =>
        {
            entity.HasKey(e => e.IdRegion).HasName("PK_REGION");

            entity.ToTable("Region");

            entity.Property(e => e.IdRegion)
                .ValueGeneratedNever()
                .HasColumnName("idRegion");
            entity.Property(e => e.IdSecteur).HasColumnName("idSecteur");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.LibRegion)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libRegion");

            entity.HasOne(d => d.IdSecteurNavigation).WithMany(p => p.Regions)
                .HasForeignKey(d => d.IdSecteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SECTEUR");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Regions)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VISITEUR");
        });

        modelBuilder.Entity<Secteur>(entity =>
        {
            entity.HasKey(e => e.IdSecteur).HasName("PK_SECTEUR");

            entity.ToTable("Secteur");

            entity.Property(e => e.IdSecteur)
                .ValueGeneratedNever()
                .HasColumnName("idSecteur");
            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.LibSecteur)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libSecteur");

            entity.HasOne(d => d.IdVisiteurNavigation).WithMany(p => p.Secteurs)
                .HasForeignKey(d => d.IdVisiteur)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_VISITEURSECTEUR");
        });

        modelBuilder.Entity<Specialite>(entity =>
        {
            entity.HasKey(e => e.IdSpecialite).HasName("PK__SPECIALI__1023B1561A05F388");

            entity.ToTable("SPECIALITE");

            entity.Property(e => e.IdSpecialite)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idSpecialite");
            entity.Property(e => e.LibSpecialite)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("libSpecialite");
        });

        modelBuilder.Entity<Visiteur>(entity =>
        {
            entity.HasKey(e => e.IdVisiteur).HasName("PK_VISITEUR");

            entity.ToTable("Visiteur");

            entity.Property(e => e.IdVisiteur)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("idVisiteur");
            entity.Property(e => e.Actif).HasColumnName("actif");
            entity.Property(e => e.Cp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cp");
            entity.Property(e => e.DateEmbauche)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("dateEmbauche");
            entity.Property(e => e.IdLabo).HasColumnName("idLabo");
            entity.Property(e => e.Identifiant)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("identifiant");
            entity.Property(e => e.NbEssai).HasColumnName("nbEssai");
            entity.Property(e => e.Nom)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("nom");
            entity.Property(e => e.Password)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Prenom)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("prenom");
            entity.Property(e => e.Rue)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("rue");
            entity.Property(e => e.Ville)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("ville");

            entity.HasOne(d => d.IdLaboNavigation).WithMany(p => p.Visiteurs)
                .HasForeignKey(d => d.IdLabo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Laboratoire");

            entity.HasMany(d => d.IdRegions).WithMany(p => p.IdVisiteurs)
                .UsingEntity<Dictionary<string, object>>(
                    "Travailler",
                    r => r.HasOne<Region>().WithMany()
                        .HasForeignKey("IdRegion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_TRAVAILLER"),
                    l => l.HasOne<Visiteur>().WithMany()
                        .HasForeignKey("IdVisiteur")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_VISITEURTRAVAIL"),
                    j =>
                    {
                        j.HasKey("IdVisiteur", "IdRegion").HasName("PK_TRAVAILLER");
                        j.ToTable("Travailler");
                        j.IndexerProperty<string>("IdVisiteur")
                            .HasMaxLength(3)
                            .IsUnicode(false)
                            .IsFixedLength()
                            .HasColumnName("idVisiteur");
                        j.IndexerProperty<int>("IdRegion").HasColumnName("idRegion");
                    });
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
