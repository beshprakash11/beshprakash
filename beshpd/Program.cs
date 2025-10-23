var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();
app.MapFallbackToController("Index", "Fallback");

app.Run();
