using BL.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddCors();
builder.Services.AddServices();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
