using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace iSlavici.Connection.Models.db
{
    public partial class SlaviciContext : DbContext
    {

        public SlaviciContext() { }


        public SlaviciContext(DbContextOptions<SlaviciContext> options, IServiceCollection service)
            : base(options) {
            service.AddDbContext<SlaviciContext>(ServiceLifetime.Transient);
        }


        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Note> Note { get; set; }
        public virtual DbSet<NoteType> NoteType { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }
        public virtual DbSet<SubjectType> SubjectType { get; set; }
        public virtual DbSet<SubjectExamination> SubjectExamination { get; set; }
        public virtual DbSet<Student> Student { get; set; }

    
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
                optionsBuilder.UseSqlServer("Data Source=100.42.52.207;Initial Catalog=nicudehelean_iSlavici; User=nicudehelean_rzvdev; Password=ksy7AJE8y0iNw3WJ;Encrypt=Yes; TrustServerCertificate=Yes");
            }

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 

            modelBuilder.Entity<Account>(entity => {
                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);


                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Person>(entity => {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);
            });

            modelBuilder.Entity<Profile>(entity => {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Role>(entity => {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
