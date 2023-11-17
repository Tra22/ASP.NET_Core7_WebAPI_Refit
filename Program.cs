using Asp.Versioning;
using ASP.NET_CORE7_API_OAUTH2_RESOURCE.Services;
using ASP.NET_Core7_WebAPI_Refit.Configurations.Swagger;
using Microsoft.Extensions.Options;
using Refit;
using Swashbuckle.AspNetCore.SwaggerGen;

const string SwaggerRoutePrefix = "api-docs";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services
    .AddApiVersioning(
                options =>
                {
                    // reporting api versions will return the headers "api-supported-versions" and "api-deprecated-versions"
                    options.ReportApiVersions = true;
                })
    .AddApiExplorer(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);
        // Add the versioned API explorer, which also adds IApiVersionDescriptionProvider service
        // note: the specified format code will format the version as "'v'major[.minor][-status]"
        options.GroupNameFormat = "'v'VVV";

        // note: this option is only necessary when versioning by url segment. the SubstitutionFormat
        // can also be used to control the format of the API version in route templates
        options.SubstituteApiVersionInUrl = true;
        options.AssumeDefaultVersionWhenUnspecified = true;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddTransient<IConfigureOptions<SwaggerGenOptions>, ConfigureSwaggerOptions>();
builder.Services.AddSwaggerGen(options =>
{
    // Add a custom operation filter which sets default values
    options.OperationFilter<SwaggerDefaultValues>();
});
string FakeAPIUrl = builder.Configuration["FakeAPI:URL"] ?? string.Empty;
//add Refit for User Fake API
builder.Services.AddScoped<IUsersApiClientService>(x => RestService.For<IUsersApiClientService>(FakeAPIUrl));
//add Regit for Product Fake API
builder.Services.AddScoped<IProductsApiClientService>(x => RestService.For<IProductsApiClientService>(FakeAPIUrl));
//add Regit for Cart Fake API
builder.Services.AddScoped<ICartsApiClientService>(x => RestService.For<ICartsApiClientService>(FakeAPIUrl));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options => { options.RouteTemplate = $"{SwaggerRoutePrefix}/{{documentName}}/docs.json"; });
    app.UseSwaggerUI(options =>
    {
        options.RoutePrefix = SwaggerRoutePrefix;
        foreach (var description in app.DescribeApiVersions())
            options.SwaggerEndpoint($"/{SwaggerRoutePrefix}/{description.GroupName}/docs.json", description.GroupName.ToUpperInvariant());
    });
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
