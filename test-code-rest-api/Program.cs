using AutoMapper;
using Microsoft.EntityFrameworkCore;
using test_code_rest_api.Database;
using test_code_rest_api.Interfaces;
using test_code_rest_api.Mapper;
using test_code_rest_api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HouseManagement")));
builder.Services.AddScoped<IApiDbContext, ApiDbContext>();
builder.Services.AddScoped<IDbService, DbService>();
builder.Services.AddScoped<IApartmentService, ApartmentService>();
builder.Services.AddScoped<IHouseService, HouseService>();
builder.Services.AddScoped<ICitizenService, CitizenService>();
builder.Services.AddTransient<DatabaseSeeder>();

var mapper = MapperCfg.ConfigureMapper(builder.Services);
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var dbContext = services.GetRequiredService<ApiDbContext>();

    dbContext.Database.Migrate();

    DatabaseSeeder.SeedData(dbContext);
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
