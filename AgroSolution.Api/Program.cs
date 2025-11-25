using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
MaquinaController mcont = new MaquinaController();
var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
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
.WithName("GetWeatherForecast")
.WithOpenApi();

var maquinaGroup = app.MapGroup("/maquinas");
maquinaGroup.MapGet("", () =>
{
    List<Maquina> maquinas = mcont.ObterTodos();
    return Results.Ok(maquinas);
});
maquinaGroup.MapPost("", ([FromBody]Maquina maquina) =>
{
    mcont.Adicionar(maquina);
    return Results.Ok("Maquina adicionada com sucesso");
});
maquinaGroup.MapPut("", ([FromBody]Maquina maquina) =>
{
    mcont.Editar(maquina);
    return Results.Ok("Maquina editada com sucesso");
});
maquinaGroup.MapDelete("", ([FromBody]Maquina maquina) =>
{
    mcont.Remover(maquina);
    return Results.Ok("Maquina deletada com sucesso");
});
app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
