using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MyFinanceBlazor.Services;
using MyFinanceBlazor.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);
string connection = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var baseAddress = builder.Configuration.GetValue<string>("BaseUrl");
builder.Services.AddHttpClient("AntonsConfig", opt => { opt.BaseAddress = new Uri(baseAddress); });
builder.Services.AddTransient<MyHttpService>();
builder.Services.AddTransient<IFinancialOperationService, FinancialOperationService>();
builder.Services.AddTransient<IOperationTypeService, OperationTypeService>();
builder.Services.AddTransient<IReportService, ReportService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
