using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;


namespace MyXunitProject
{
    public partial class JobsContext : DbContext
    {
        public JobsContext()
        {
        }

        public JobsContext(DbContextOptions<JobsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Referral> Referral { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var builder = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

                var configuration = builder.Build();
                var conn = configuration.GetSection("ConnectionString").Value;
                optionsBuilder.UseMySql(conn);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Jobid });

                entity.ToTable("jobs");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("int(11)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Jobid)
                    .HasColumnName("jobid")
                    .HasColumnType("varchar(20)");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'");

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Location)
                    .HasColumnName("location")
                    .HasColumnType("varchar(45)");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary")
                    .HasColumnType("varchar(100)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)");
            });

            modelBuilder.Entity<Referral>(entity =>
            {
                entity.HasKey(e => e.Idreferral);

                entity.ToTable("referral");

                entity.HasIndex(e => e.Company)
                    .HasName("company_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Idreferral)
                    .HasColumnName("idreferral")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Company)
                    .HasColumnName("company")
                    .HasColumnType("varchar(200)");

                entity.Property(e => e.Contact)
                    .HasColumnName("contact")
                    .HasColumnType("varchar(200)")
                    .HasDefaultValueSql("'Empty'");

                entity.Property(e => e.Isagent)
                    .HasColumnName("isagent")
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("'0'");
            });
        }
    }
}
