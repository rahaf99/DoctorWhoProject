using AutoMapper;
using DoctorWho;
using DoctorWho.Db.Interfaces;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Services;
using DoctorWho.Web.Validators;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();
//builder.Services.AddTransient<IMapper, Mapper>();
builder.Services.AddTransient<IAuthorRepository, AuthorRepository >();
builder.Services.AddTransient<ICompanionRepository, CompanionRepository>();
builder.Services.AddTransient<IDoctorRepository, DoctorRepository>();
builder.Services.AddTransient<IEnemyRepository, EnemyRepository>();
builder.Services.AddTransient<IEpisodeCompanionRepository, EpisodeCompanionRepository>();
builder.Services.AddTransient<IEpisodeEnemyRepository, EpisodeEnemyRepository>();
builder.Services.AddTransient<IEpisodeRepository, EpisodeRepository>();
builder.Services.AddTransient<IAuthorService, AuthorService>();
builder.Services.AddTransient<IDoctorService , DoctorService>();
builder.Services.AddTransient<IEpisodeService , EpisodeService >();
builder.Services.AddTransient<IEpisodeCompanionService , EpisodeCompanionService >();
builder.Services.AddTransient<IEpisodeEnemyService, EpisodeEnemyService>();
builder.Services.AddTransient<DoctorValidator, DoctorValidator>();
builder.Services.AddTransient<EpisodeValidator, EpisodeValidator>();

builder.Services.AddDbContext<DoctorWhoCoreDbContext>
    (options => options.UseSqlServer(builder.Configuration["ConnectionStrings:DoctorWhoDbContextConnection"]));

builder.Services.AddControllers().AddJsonOptions(x =>
    x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);

builder.Services.AddCors(options => options.AddPolicy(name: "NgOrigins", policy =>
{
    policy.WithOrigins("https://localhost:7248/").AllowAnyMethod().AllowAnyHeader();
}));

var app = builder.Build();


//app.UseSession();

app.UseCookiePolicy();

app.UseHttpsRedirection();


app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

//app.UseRouting();
app.MapRazorPages();

app.Run();








