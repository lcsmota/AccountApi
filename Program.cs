using System.Text.Json.Serialization;
using AccountApi.Context;
using AccountApi.DTOs.Mappings;
using AccountApi.Interfaces;
using AccountApi.Repository;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
{
    builder.Services.AddDbContext<AppDbContext>(opt =>
        opt.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

    builder.Services.AddControllers().AddJsonOptions(options =>
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen(sw =>
    {
        sw.SwaggerDoc("v1", new OpenApiInfo
        {
            Title = "Account API",
            Version = "v1",
            Description = "Simple CRUD using Entity Framework 7"
        });
    });

    var mappingConfig = new MapperConfiguration(mconf =>
    {
        mconf.AddProfile(new MappingProfile());
    });

    IMapper mapper = mappingConfig.CreateMapper();

    builder.Services.AddSingleton(mapper);
}

var app = builder.Build();
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}