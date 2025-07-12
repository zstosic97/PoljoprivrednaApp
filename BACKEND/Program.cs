
using BACKEND.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen();

// dodavanje DB contexta
builder.Services.AddDbContext<EdunovaContext>(o =>
{
    o.UseSqlServer(builder.Configuration.GetConnectionString("EdunovaContext"));
}
);

builder.Services.AddCors(o =>
{
    o.AddPolicy("CorsPolicy", p =>
        {
            p.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();   

        });

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSwagger();
app.UseSwaggerUI(p =>
{
    p.EnableTryItOutByDefault();
});

app.MapControllers();

app.UseStaticFiles();//omogu?i kori�tenje stati?nih datoteka
app.UseDefaultFiles(); //datoteke se naalaze u wwwroot
app.MapFallbackToFile("index.html"); //ako ne?ega nema idi na index.html

app.UseCors("CorsPolicy");

app.Run();