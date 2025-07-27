using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using PayFast;
using play_360.EF.Contexts;
using play_360.Services.Abstration;
using play_360.Services.Abstration.BusinessLogic;
using play_360.Services.Abstration.DataAccess;
using play_360.Services.Abstration.Messaging;
using play_360.Services.Concrete;
using play_360.Services.Concrete.BusinessLogic;
using play_360.Services.Concrete.DataAccess;
using play_360.Services.Concrete.Messaging;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var connectionString = builder.Configuration.GetConnectionString("Play360DBConnection");
builder.Services.AddDbContext<Play360Context>(options => options.UseSqlServer(connectionString));

builder.Services.Configure<PayFastSettings>(builder.Configuration.GetSection("PayFastSettings"));
builder.Services.AddPayFastIntegration();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters 
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"])),
            ValidateIssuer = true, // on production make it true
            ValidIssuer = builder.Configuration["Jwt:Issuer"],
            ValidateAudience = true, // on production make it true
            ValidAudience = builder.Configuration["Jwt:Audience"],
            ValidateLifetime = true
        };

        options.Events = new JwtBearerEvents
        {
            OnAuthenticationFailed = context =>
            {
                if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                {
                    context.Request.Headers.Append("IS-TOKEN-EXPIRED", "true");
                }
                return Task.CompletedTask;
            }
        };
    });

builder.Services.AddScoped<IJWTService, JWTService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IUserBusinessLogicService, UserBusinessLogicService>();
builder.Services.AddScoped<IEmailMessager, EmailMessager>();
builder.Services.AddScoped<ICreditRepository, CreditRepository>();
builder.Services.AddScoped<ICreditBusinessLogicService, CreditBusinessLogicService>();
builder.Services.AddScoped<ITransactionRepository, TransactionRepository>();
builder.Services.AddScoped<ITransactionBusinessLogicService, TransactionBusinessLogicService>();
builder.Services.AddScoped<IWellnessCheckinQuestionRepository, WellnessCheckinQuestionRepository> ();
builder.Services.AddScoped<IWellnessCheckinQuestionBusinessLogicService, WellnessCheckinQuestionBusinessLogicService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
