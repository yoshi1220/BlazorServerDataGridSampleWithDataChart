﻿using BlazorServerDataGridSampleWithDataChart.Data;
using BlazorServerDataGridSampleWithDataChart.Repositories;
using BlazorServerDataGridSampleWithDataChart.Services;
using IgniteUI.Blazor.Controls;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//DB関連
builder.Services.AddDbContext<SampleDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

//Repository関連
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ISalesDetailRepository, SalesDetailRepository>();
//builder.Services.AddScoped<IUserRepository, UserRepositoryDapper>(); //Dapperを使う場合

//Service関連            
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<ISalesDetailService, SalesDetailService>();

//MudBlazor
builder.Services.AddMudServices();

//Ignite UI for Blazor
builder.Services.AddIgniteUIBlazor(
                typeof(IgbPropertyEditorPanelModule),
                typeof(IgbGridModule),
                typeof(IgbDataChartCoreModule),
                typeof(IgbDataChartCategoryCoreModule),
                typeof(IgbDataChartCategoryModule),
                typeof(IgbDataChartInteractivityModule),
                typeof(IgbDataChartAnnotationModule),
                typeof(IgbCalloutLayerModule),
                typeof(IgbNumberAbbreviatorModule),
                typeof(IgbLegendModule),
                typeof(IgbCategoryChartModule)
           );

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


