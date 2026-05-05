var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Настройки для разработки
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();         // Генерация OpenAPI документа
    app.UseSwaggerUI();       // Визуальный интерфейс Swagger
}

// Middleware общего назначения (для всех сред)
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers(); // Более современный способ вместо MapControllerRoute

app.Run();