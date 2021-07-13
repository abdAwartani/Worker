using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Configuration;

namespace Worker.Data
{
    public class WorkerContext : DbContext
    {
        public WorkerContext()
        {
                
        }
        public WorkerContext(DbContextOptions<WorkerContext> options):base(options)
        {
        }

        public virtual DbSet<Bundle> Bundles { get; set; }
        public virtual DbSet<BundleDetail> BundleDetails { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bundle>().HasIndex(cus => cus.Id);

            modelBuilder.Entity<BundleDetail>().HasIndex(cus => cus.Id);
        }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //string conn=String.Empty;
        //    //var builder = new ConfigurationBuilder()
        //    //                    .SetBasePath(Directory.GetCurrentDirectory())
        //    //                    .AddJsonFile("appsettings.json");
        //    //var configuration = builder.Build();
        //    //    //configuration.Providers.FirstOrDefault(p => p.TryGet("ConnectionStrings",out conn));
        //    // var c=   configuration.Pro viders.FirstOrDefault();
        //    // c.
        //    //optionsBuilder.UseSqlServer(conn);
        //    optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LP-AbdallahA\source\repos\Worker\Worker\WorkerDB.mdf;Integrated Security=True");
        //}
    }

    public class BundleDetail
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

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