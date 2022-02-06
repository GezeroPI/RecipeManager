using Microsoft.EntityFrameworkCore;
using RecipeManager.Api.Extensions;
using RecipeManager.Domain.Entities;
using RecipeManager.Infrastructure.Context;
using System.Configuration;
using NLog;
using NLog.Web;
using FluentValidation.AspNetCore;
using RecipeManager.Api.DTOs;

var logger = NLog.LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("init main");

try
{

    var builder = WebApplication.CreateBuilder(args);
    IConfiguration configuration = builder.Configuration;
    // Add services to the container.
    builder.Services.AddControllers().AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<AddUserRequestValidator>());
    builder.Logging.ClearProviders();
    builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
    builder.Host.UseNLog();
    builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


    builder.Services.AddDatabase(configuration)
                .AddUnitOfWork()
                .AddRepositories()
                .AddBusinessServices();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();



    var app = builder.Build();

    // Configure the HTTP request pipeline.
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
catch (Exception exception)
{
    // NLog: catch setup errors
    logger.Error(exception, "Stopped program because of exception");
    throw;
}
finally
{
    // Ensure to flush and stop internal timers/threads before application-exit (Avoid segmentation fault on Linux)
    NLog.LogManager.Shutdown();
}