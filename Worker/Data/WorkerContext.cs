using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Worker.Helper;

namespace Worker.Data
{
    public class WorkerContext : DbContext
    {
        public WorkerContext()
        {

        }
        public WorkerContext(DbContextOptions<WorkerContext> options) : base(options)
        {
        }

        public virtual DbSet<Bundle> Bundles { get; set; }
        public virtual DbSet<BundleDetail> BundleDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bundle>().HasIndex(cus => cus.Id);

            modelBuilder.Entity<BundleDetail>().HasIndex(cus => cus.Id);
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ConfigurationHelper _configuration = new ConfigurationHelper();
            optionsBuilder.UseSqlServer(_configuration.GetConnectionStringPath());
        }
    }

    public class BundleDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ProcessName { get; set; }


        public int BundleId { get; set; }
    }

    public class Bundle
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<BundleDetail> BundleDetails { get; set; }
    }
}