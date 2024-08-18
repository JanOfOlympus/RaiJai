using RaiJaiApi.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();

builder.Services
	.AddGraphQLServer()
	.AddQueryType<Query>();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGraphQL();

app.Run();
