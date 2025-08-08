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
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options => options.AddPolicy("developmentCORS", policy =>
{
    policy
    .AllowAnyHeader()
    .AllowAnyMethod()
    .WithOrigins("*", "http://ec2-52-14-238-110.us-east-2.compute.amazonaws.com:5000")
    .Build();
}));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    options.JsonSerializerOptions.WriteIndented = true;
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
builder.Services.AddScoped<IAcheivementRepository, AcheivementRepository>();
builder.Services.AddScoped<IAcheivementBusinessLogicService, AcheivementBusinessLogicService>();
builder.Services.AddScoped<IReferralRepositoryService, ReferralRepositoryService>();
builder.Services.AddScoped<IReferralBusinessLogicService, ReferralBusinessLogicService>();
builder.Services.AddScoped<ISportTypeRepository, SportTypeRepository>();
builder.Services.AddScoped<ISportTypeBusinessLogicService, SportTypeBusinessLogicService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI(options => // UseSwaggerUI is called only in Development.
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weather", () =>
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

app.UseCors("developmentCORS");
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
