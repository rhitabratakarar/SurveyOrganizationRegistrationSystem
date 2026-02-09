using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SurveyOrganizationRegistrationSystem.Database;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
string? connectionString = builder.Configuration.GetConnectionString("SurveyManagement");

if (connectionString is null)
    return;

builder.Services.AddDbContext<SurveyManagementDbContext>(option => option.UseSqlServer(connectionString));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
