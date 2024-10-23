using Givestar.API;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationHelper.Initialize(builder.Configuration);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//builder.Services.AddScoped<Givestar.DataAccess.DbAccess.ISqlDataAccess, Givestar.DataAccess.DbAccess.SqlDataAccess>();

//builder.Services.AddScoped<Givestar.BusinessLogic.IDocument, Givestar.BusinessLogic.Document>();

Injector.Register(builder);

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
