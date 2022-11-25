using IngestionLib.EntityFramework.DALModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngestionLib.EntityFramework.Interface
{
    public interface iSportsEventDBContext
    {

        //Database Specific
        DbSet<dateandtimeinfo> dateandtimeinfo { get; set; }
        DbSet<metadata> metadata { get; set; }
        DbSet<navigation_info> navigation_info { get; set; }
        DbSet<navigationinfovalue> navigationinfovalue { get; set; }
        DbSet<parent_sports_event_id> parent_sports_event_id { get; set; }
        DbSet<properties> properties { get; set; }
        DbSet<propertyvalue> propertyvalue { get; set; }
        DbSet<relatedsportsevents> relatedsportsevents { get; set; }
        DbSet<RSEnavigationinfo> RSEnavigationinfo { get; set; }
        DbSet<SportModel> SportModel { get; set; }
        DbSet<sports_organization_id> sports_organization_id { get; set; }
        DbSet<State> State { get; set; }
        DbSet<weather_conditions> weather_conditions { get; set; }
    }
}
