using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Horsing.Models.Database
{
    public partial class rgr_dbContext : DbContext
    {
        public rgr_dbContext()
        {
        }

        public rgr_dbContext(DbContextOptions<rgr_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Coach> Coaches { get; set; } = null!;
        public virtual DbSet<Horse> Horses { get; set; } = null!;
        public virtual DbSet<Jockey> Jockeys { get; set; } = null!;
        public virtual DbSet<Race> Races { get; set; } = null!;
        public virtual DbSet<Result> Results { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlite("Data Source=F:\\visaul_progr\\Horsing\\Horsing\\Assets\\rgr_db.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Coach>(entity =>
            {
                entity.HasKey(e => e.CoachName);

                entity.ToTable("Coach");

                entity.Property(e => e.CoachName).HasColumnName("Coach_name");
            });

            modelBuilder.Entity<Horse>(entity =>
            {
                entity.HasKey(e => e.HorseName);

                entity.ToTable("Horse");

                entity.Property(e => e.HorseName).HasColumnName("Horse_name");

                entity.Property(e => e.CoachName).HasColumnName("Coach_name");

                entity.Property(e => e.JockeyName).HasColumnName("Jockey_name");

                entity.Property(e => e.OwnerName).HasColumnName("Owner_name");

                entity.HasOne(d => d.CoachNameNavigation)
                    .WithMany(p => p.Horses)
                    .HasForeignKey(d => d.CoachName);

                entity.HasOne(d => d.JockeyNameNavigation)
                    .WithMany(p => p.Horses)
                    .HasForeignKey(d => d.JockeyName);
            });

            modelBuilder.Entity<Jockey>(entity =>
            {
                entity.HasKey(e => e.JockeyName);

                entity.ToTable("Jockey");

                entity.Property(e => e.JockeyName).HasColumnName("Jockey_name");
            });

            modelBuilder.Entity<Race>(entity =>
            {
                entity.HasKey(e => e.RaceName);

                entity.ToTable("Race");

                entity.Property(e => e.RaceName).HasColumnName("Race_name");

                entity.Property(e => e.ParticipantAge).HasColumnName("Participant_age");

                entity.Property(e => e.ParticipantSex).HasColumnName("Participant_sex");

                entity.Property(e => e.RaceTrack).HasColumnName("Race_track");

                entity.Property(e => e.RaceType).HasColumnName("Race_type");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasKey(e => new { e.HorseName, e.RaceName });

                entity.ToTable("Result");

                entity.Property(e => e.HorseName).HasColumnName("Horse_name");

                entity.Property(e => e.RaceName).HasColumnName("Race_name");

                entity.Property(e => e.FinishPos).HasColumnName("Finish_pos");

                entity.Property(e => e.GateNum).HasColumnName("Gate_num");

                entity.Property(e => e.HorseNum).HasColumnName("Horse_num");

                entity.HasOne(d => d.HorseNameNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.HorseName)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.RaceNameNavigation)
                    .WithMany(p => p.Results)
                    .HasForeignKey(d => d.RaceName)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
