using MyFinanceLibrary.Data;
using Microsoft.EntityFrameworkCore;
using MyFinanceLibrary.Services;
using MyFinanceLibrary.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

string connection = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<MyFinanceContext>(options => options.UseSqlServer(connection));
// Add services to the container.
builder.Services.AddScoped<IOperationTypeService, OperationTypeService>();
builder.Services.AddScoped<IFinancialOperationService, FinancialOperationService>();
builder.Services.AddScoped<IReportService, ReportService>();
builder.Services.AddControllers();

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
