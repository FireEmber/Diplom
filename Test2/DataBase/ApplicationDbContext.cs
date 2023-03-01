using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test2.DataBase
{
    public partial class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Discipline> Disciplines { get; set; } = null!;
        public virtual DbSet<Exercise> Exercises { get; set; } = null!;
        public virtual DbSet<ExerciseContent> ExerciseContents { get; set; } = null!;
        public virtual DbSet<ExerciseType> ExerciseTypes { get; set; } = null!;
        public virtual DbSet<FalseAnswer> FalseAnswers { get; set; } = null!;
        public virtual DbSet<Test> Tests { get; set; } = null!;
        public virtual DbSet<TrueAnswer> TrueAnswers { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=PC-232-05\\SQLEXPRESS;Trusted_Connection=True;Initial Catalog =MarininV2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Discipline>(entity =>
            {
                entity.ToTable("Discipline");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Discipline1).HasColumnName("Discipline");
            });

            modelBuilder.Entity<Exercise>(entity =>
            {
                entity.ToTable("Exercise");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Exercise1).HasColumnName("Exercise");

                entity.Property(e => e.ExerciseType).HasColumnName("Exercise type");

                entity.HasOne(d => d.DisciplineNavigation)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.Discipline)
                    .HasConstraintName("FK__Exercise__Discip__4316F928");

                entity.HasOne(d => d.ExerciseContentNavigation)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.ExerciseContent)
                    .HasConstraintName("FK__Exercise__Exerci__45F365D3");

                entity.HasOne(d => d.ExerciseTypeNavigation)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.ExerciseType)
                    .HasConstraintName("FK__Exercise__Exerci__440B1D61");

                entity.HasOne(d => d.FalseAnswersNavigation)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.FalseAnswers)
                    .HasConstraintName("FK__Exercise__FalseA__46E78A0C");

                entity.HasOne(d => d.TestNavigation)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.Test)
                    .HasConstraintName("FK__Exercise__Test__44FF419A");

                entity.HasOne(d => d.TrueAnswerNavigation)
                    .WithMany(p => p.Exercises)
                    .HasForeignKey(d => d.TrueAnswer)
                    .HasConstraintName("FK__Exercise__TrueAn__47DBAE45");
            });

            modelBuilder.Entity<ExerciseContent>(entity =>
            {
                entity.ToTable("ExerciseContent");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<ExerciseType>(entity =>
            {
                entity.ToTable("Exercise type");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.TaskType).HasColumnName("Task type");
            });

            modelBuilder.Entity<FalseAnswer>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.ToTable("Test");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TrueAnswer>(entity =>
            {
                entity.ToTable("TrueAnswer");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.TrueAnswer1).HasColumnName("TrueAnswer");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
