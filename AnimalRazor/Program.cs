using AnimalRazor.Extensions;
using AnimalRazor.Models;
using AnimalRazor.Repozitorys.Interfaces;
using AnimalRazor.Repozitorys;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterRepos();

builder.Services.AddRazorPages();

var app = builder.Build();
//app.UseMiddleware<AnimalRepozitory>();

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
