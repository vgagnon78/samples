using multiple_files.Settings;

var builder = WebApplication.CreateBuilder(args);

// README :
// Ajouter le code suivant pour initialiser les valeurs du appsettings selon
// l'environnement.
//
// Ajouter aussi les valeurs des variables d'environnements selon configuration windows
// -- ATTENTION --
// Si la valeur de la variable d'environnement windows est changé, il faut redémarrer soit
//  Visual Studio pour le dev ;
//  Le Application Pool / Web site de IIS ;
//
var env = builder.Environment;

builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile("appsettings.json")
    .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
    .AddEnvironmentVariables("ASPNETCORE_")
    .Build();

// Configuration d'une section strong-typed pour les variables du fichiers appsettings.
// Voir classes $/Settings/MyCustomSettings
builder.Services.Configure<MyCustomSettings>(builder.Configuration.GetSection("MyCustomSettings"));

// FIN README

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
//
// A des fins de demos, la condition a ete commenter
// Ne jamais permettre Swagger en test, pilote, pre production, production etc
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
