using Empregados.Domain.Handlers;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Infra.Contexts;
using Empregados.Domain.Infra.Repositories;
using Empregados.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<EmpregadosContext>();
builder.Services.AddScoped<IEmpregadoRepository, EmpregadoRepository>();
builder.Services.AddScoped<IRecuperaEmpregadosQueryHandler, RecuperaEmpregadosQueryHandler>();
builder.Services.AddScoped<IRecuperaEmpregadoPorIdQueryHandler, RecuperaEmpregadoPorIdQueryHandler>();
builder.Services.AddScoped<ICriarEmpregadoHandler, CriarEmpregadoHandler>();
builder.Services.AddScoped<IAlterarEmpregadoHandler, AlterarEmpregadoHandler>();


builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
