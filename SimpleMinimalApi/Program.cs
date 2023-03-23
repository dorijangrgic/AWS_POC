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

app.MapGet("/hello", () =>
{
    return Enumerable.Range(1, 2).Select(x => new WeatherForecast
    {
        Date = DateTime.UtcNow,
        TemperatureC = x,
        Summary = $"{x}_forecast"
    });
});

app.MapGet("/yello", () => new { name = "Dorijan", surname = "Grgic" });

app.MapGet("/payments", () => Enumerable.Range(1, 100).Select(x => new
{
    idPeyment = x,
    occured = DateTime.UtcNow,
    status = "Finished"
}));

app.Run();