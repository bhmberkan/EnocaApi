using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarrierConfigurationHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Handlers.CarriersHandlers;
using EnocaApi.Application.Features.CQRSDesingPattern.Queries.CarrierConfigurationQueries;
using EnocaApi.Persistence;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<EnocaContext>();

builder.Services.AddScoped<CreateCarrierCommandHandler>();
builder.Services.AddScoped<UpdateCarrierCommandHandler>();
builder.Services.AddScoped<RemoveCarrierCommandHandler>();
builder.Services.AddScoped<GetCarrierByIdQueryHandler>();
builder.Services.AddScoped<GetCarrierQueryHandler>();



builder.Services.AddScoped<CreateCarrierConfigurationCommandHandler>();
builder.Services.AddScoped<UpdateCarrierConfigurationCommandHandler>();
builder.Services.AddScoped<RemoveCarrierConfigurationCommandHandler>();
builder.Services.AddScoped<GetCarrierConfigurationByIdHandler>();
builder.Services.AddScoped<GetCarrierConfigurationQueryHandler>();

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(x => 
{
    x.SwaggerDoc("v1", new OpenApiInfo { Title = "ApiEnocaDb", Version = "v1" });
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
   app.UseSwagger();
    app.UseSwaggerUI(c=>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Enoca Api V1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
