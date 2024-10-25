using Serilog;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.Dynatrace(
        accessToken: builder.Configuration.GetValue<string>("Dynatrace:AccessToken"),
        ingestUrl: builder.Configuration.GetValue<string>("Dynatrace:Url"))
    .CreateLogger();

builder.Host.UseSerilog();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.MapGet("/api/v1/logs", () =>
{
    Log.Information("Request received");

    return Results.Ok();
});

app.Run();
