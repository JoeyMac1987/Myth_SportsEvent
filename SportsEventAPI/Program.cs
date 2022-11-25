using IngestionLib.EntityFramework.DAL;
using IngestionLib.EntityFramework.Interface;
using IngestionLib.EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


var connectionString = builder.Configuration.GetConnectionString("SportsEventDBContext");
builder.Services.AddDbContext<SportsEventDBContext>(options => options.UseSqlServer(connectionString));

Bulk_EF_AddToScope(builder.Services);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   // app.UseSwagger();
   // app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();




void Bulk_EF_AddToScope(IServiceCollection services)
{
    services.AddScoped<iSportsEventDBContext, SportsEventDBContext>();

    services.AddScoped<IDateandtimeinfoRepository, DateandtimeinfoRepository>();
    services.AddScoped<IMetadataRepository, MetadataRepository>();
    services.AddScoped<INavigation_infoRepository, Navigation_infoRepository>();
    services.AddScoped<INavigationinfovalueRepository, NavigationinfovalueRepository>();
    services.AddScoped<IPropertiesRepository, PropertiesRepository>();
    services.AddScoped<IPropertyvalueRepository, PropertyvalueRepository>();
    services.AddScoped<IRelatedsportseventsRepository, RelatedsportseventsRepository>();
    services.AddScoped<IRSEnavigationinfoRepository, RSEnavigationinfoRepository>();
    services.AddScoped<ISportsModelRepository, SportsModelRepository>();
    services.AddScoped<IStateRepository, StateRepository>();
    services.AddScoped<IWeather_conditionsRepository, Weather_conditionsRepository>();

    services.AddScoped<IUnitofWork, UnitofWork>();
}