using MinimalApiDemo;
using MinimalApiDemo.DataAccess;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddKeyedSingleton<ISql, MySql>("MySQL");
builder.Services.AddKeyedSingleton<ISql, Sql>("SQL");
builder.Services.AddSingleton<OtherDemo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/SQL", ([FromKeyedServices("SQL")] ISql db) => db.OpenConnection());
app.MapGet("/MySQL", ([FromKeyedServices("MySQL")] ISql db) => db.OpenConnection());
app.MapGet("/OtherDemo", (OtherDemo demo) => demo.PrintMessage());



app.Run();

