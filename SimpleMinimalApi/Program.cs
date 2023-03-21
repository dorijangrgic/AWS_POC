using SimpleMinimalApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

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

// endpoints

app.MapGet("/weatherforecast/hello", () =>
{
    return Enumerable.Range(1, 5).Select(x => new WeatherForecast
    {
        Date = DateTime.UtcNow,
        TemperatureC = x,
        Summary = $"{x}_forecastsss"
    });
});

app.Run();