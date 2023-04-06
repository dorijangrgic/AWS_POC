using SimpleMinimalApi.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDataAccess();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddEnvironmentVariables();

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

app.MapGet("/env", (IConfiguration configuration, IWebHostEnvironment environment) => new
{
	prodiadbconnstring = configuration.GetConnectionString("ProdiaDB"),
	env = environment.EnvironmentName,
	redisurl = configuration["RedisUrl"]
});


app.Run();