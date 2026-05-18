using TodoApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Conexao com o banco 
builder.Services.AddSingleton<TarefaRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Comunicação com o Front-End
builder.Services.AddCors(options =>
{
    options.AddPolicy("MinhaPoliticaCORS", policy =>
    {
        // Porta do Vue.Js
        policy.WithOrigins("http://localhost:5173").AllowAnyHeader().AllowAnyMethod();

    });

});

var app = builder.Build();
app.UseCors("MinhaPoliticaCORS");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Sobe o swagger e sua interface (SwaggerUI)
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
