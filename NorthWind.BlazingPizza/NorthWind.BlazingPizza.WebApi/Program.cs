using NorthWind.BlazingPizza.Backend.BusinessObjects.Options;
using NorthWind.BlazingPizza.Backend.IoC;
using NorthWind.BlazingPizza.EFCore.DataSources.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddBlazingPizzaServices
    (
        dbOptions =>
        builder.Configuration.GetRequiredSection(DBOptions.SectionKey)
        .Bind(dbOptions),
        blazingPizzaOptions => builder.Configuration.GetRequiredSection(BlazingPizzaOptions.SectionKey)
        .Bind(blazingPizzaOptions)
        );

builder.Services.AddCors(options =>
    {
        options.AddDefaultPolicy(builder =>
        {
            builder.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
        });
    }
    );

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseBlazingPizzaEndpoints();
app.UseCors();

app.Run();

