using Empregados.Domain.Handlers;
using Empregados.Domain.Handlers.Interfaces;
using Empregados.Domain.Handlers.Interfaces.Queries;
using Empregados.Domain.Handlers.Queries;
using Empregados.Domain.Infra.Contexts;
using Empregados.Domain.Infra.Repositories;
using Empregados.Domain.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IEmpregadoRepository, EmpregadoRepository>();
builder.Services.AddScoped<IRecuperaEmpregadosQueryHandler, RecuperaEmpregadosQueryHandler>();
builder.Services.AddScoped<IRecuperaEmpregadoPorIdQueryHandler, RecuperaEmpregadoPorIdQueryHandler>();
builder.Services.AddScoped<ICriarEmpregadoHandler, CriarEmpregadoHandler>();
builder.Services.AddScoped<IAlterarEmpregadoHandler, AlterarEmpregadoHandler>();
builder.Services.AddScoped<IExcluirEmpregadoHandler, ExcluirEmpregadoHandler>();
builder.Services.AddScoped<IEmpresaRepository, EmpresaRepository>();
builder.Services.AddScoped<IRecuperarDadosEmpresaQueryHandler, RecuperarDadosEmpresaQueryHandler>();
builder.Services.AddScoped<IAlterarEmpresaHandler, AlterarEmpresaHandler>();

builder.Services.AddDbContext<DataContext>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
