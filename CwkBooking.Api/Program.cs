using CwkBooking.Api;
using CwkBooking.Api.Services;
using CwkBooking.Api.Services.Abstractions;

var builder = WebApplication.CreateBuilder(args);
{
    // Add services to the container.
    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
    builder.Services.AddSingleton<DataSource>();
    builder.Services.AddSingleton<ISingletonOperation, SingletonOperation>();
    builder.Services.AddTransient<ITransientOperation , TransientOperation>();
    builder.Services.AddScoped<IScopedOperation, ScopedOperation>();
}
var app = builder.Build();
{

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }


    app.UseRouting();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}