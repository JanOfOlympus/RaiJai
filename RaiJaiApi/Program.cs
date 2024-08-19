using RaiJaiApi;
using RaiJaiApi.Queries;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();

builder.Services
	.AddGraphQLServer()
	.AddQueryType<Query>()
	.AddMutationType<Mutation>()
	.AddType<UploadType>()
	.AddMutationConventions();

var app = builder.Build();

app.UseStaticFiles();

app.MapGraphQL();

app.Run();
