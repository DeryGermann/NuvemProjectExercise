using Microsoft.EntityFrameworkCore;
using NuvemProjectExercise.Pharmacy.Service.Data;
using NuvemProjectExercise.Pharmacy.Service.Service.PharmacyService;
using NuvemProjectExercise.Pharmacy.Service.Service.ReportingService;

var builder = WebApplication.CreateBuilder(args);

// Connecting the DBContext using connection string
builder.Services.AddDbContext<PharmacyContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddDbContext<NuvemProjectExerciseContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(Program).Assembly);

// Adding the IServices and Services
builder.Services.AddScoped<IPharmacyService, PharmacyService>();
builder.Services.AddScoped<IReportingService, ReportingService>();

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
