using BuberBreakfast.Models;
using BuberBreakfast.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);
{
builder.Services.AddControllers();
builder.Services.AddSingleton <BreakfastService, BreakfastService>();
}

var app = builder.Build();
{
app.UseHttpsRedirection();

app.MapControllers();

app.Run();
}