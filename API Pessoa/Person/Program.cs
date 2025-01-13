using Person.Routes;

var builder = WebApplication.CreateBuilder(args);

// Adicionar o Swagger ao container de serviços
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Configurar a UI do Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.PersonRoutes();

app.UseHttpsRedirection();
app.Run();