using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Fasyens.Core;
using Fasyens.Core.Entities.FasyenClass;

namespace Fasyens.DAL
{
    public class FasyenContextInitializer : CreateDatabaseIfNotExists<fasyenContext>
    {
        protected override void Seed(fasyenContext context)
        {
            base.Seed(context);
        }
    }
    public class fasyenContext : DbContext
    {
        public fasyenContext() : base("Fashion")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBuilder.Entity<Core.fasyen.fasyenClass.fasyen>()
            //    .HasOptional(fasyen => fasyen.Description)
            //    .WithRequired(Description => Description.fasyen);
        }

        static fasyenContext()
        {
            Database.SetInitializer(new FasyenContextInitializer());
        }


        public static fasyenContext Create()
        {
            return new fasyenContext();
        }

        public DbSet<Fasyen> Fasyen { get; set; }
        public DbSet<Fasyen> Categoty { get; set; }       
        //buat bikin databasenya, fasyen itu sebagai nama tablenya
        // kalo mau migrat database pertama ke web config yang di project utama, terus di ubah connection stringnya ke sql masing2 komputer.
        //buka tools, nuget package manager poloj yang console
        //too

    }
}
