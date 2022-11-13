using API;
using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<CarDbContext>(o => o.UseSqlServer(
        "Server=localhost,1433;" +
        "Database=CarQraphQl;" +
        "User=sa;Password='Docker@123';" +
        "TrustServerCertificate=true"));
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>()
    .RegisterService<CarDbContext>(kind: ServiceKind.Default);
  
var app = builder.Build();

app.MapGraphQL();

app.Run();

