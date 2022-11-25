using IngestionLib.EntityFramework.DALModels;

namespace SportsEventAPI
{
    public class ModelContainer
    {

        public dateandtimeinfo? DateAndTimeInfo {get;set;}
        public metadata? MetaData {get;set;} 
        public navigation_info[]? NavigationInfo {get;set;} 
        public navigationinfovalue[]? NavigationInfoValue {get;set;} 
        public parent_sports_event_id[]? ParentSports_Event_Id {get;set;} 
        public IngestionLib.EntityFramework.DALModels.properties[]? Properties {get;set;}
        public IngestionLib.EntityFramework.DALModels.propertyvalue[]? PropertyValues { get; set; }
        public IngestionLib.EntityFramework.DALModels.relatedsportsevents[]? RelatedSportsEvents {get;set;}  
        public IngestionLib.EntityFramework.DALModels.RSEnavigationinfo[]? RSENavigationInfo {get;set;} 
        public SportModel SportModel {get;set;} 
        public sports_organization_id[]? Sports_Organization_Id {get;set;} 
        public IngestionLib.EntityFramework.DALModels.State[]? State {get;set;} 
        public weather_conditions? Weather_Conditions {get;set;} 
    }
}
