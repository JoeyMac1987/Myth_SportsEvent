using IngestionLib.EntityFramework.DALModels;
using IngestionLib.EntityFramework.Interface;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.DAL
{
    public class SportsEventDBContext : DbContext , iSportsEventDBContext
    {
        protected readonly IConfiguration Configuration;

        public SportsEventDBContext(IConfiguration configuration, DbContextOptions<SportsEventDBContext> options) : base(options)
        {
            Configuration = configuration;
            }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration["SportsEvent:Database"]);
        }


        #region DatabaseTables
        public DbSet<dateandtimeinfo> dateandtimeinfo { get; set; }
        public DbSet<metadata> metadata { get; set; }
        public DbSet<navigation_info> navigation_info { get; set; }
        public DbSet<navigationinfovalue> navigationinfovalue { get; set; }
        public DbSet<parent_sports_event_id> parent_sports_event_id { get; set; }
        public DbSet<properties> properties { get; set; }
        public DbSet<propertyvalue> propertyvalue { get; set; }
        public DbSet<relatedsportsevents> relatedsportsevents { get; set; }
        public DbSet<RSEnavigationinfo> RSEnavigationinfo { get; set; }
        public DbSet<SportModel> SportModel { get; set; }
        public DbSet<sports_organization_id> sports_organization_id { get; set; }
        public DbSet<State> State { get; set; }
        public DbSet<weather_conditions> weather_conditions { get; set; }




        #endregion

        #region BusinessObjects
        //public DbSet<SomeModel> SomeModel { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SomeModel>().HasNoKey();
            //modelBuilder.Entity<Lookup>().HasKey(table => new {
            //    table.Category,
            //    table.Code,
            //    table.LocationCode
            //});
        }

    }
}

