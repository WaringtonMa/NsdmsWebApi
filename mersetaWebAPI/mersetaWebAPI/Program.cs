using mersetaWebAPI.Data;
using mersetaWebAPI.Extentions;
using mersetaWebAPI.Implementation;
using mersetaWebAPI.Interface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//Inject DBContext 
var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<mersetaContext>(options => options.EnableSensitiveDataLogging(true).UseMySql(connectionstring, ServerVersion.AutoDetect(connectionstring), mySqlOptionsAction: sqloptions =>
{
    sqloptions.EnableRetryOnFailure(maxRetryCount: 10,
           maxRetryDelay: TimeSpan.FromSeconds(30),
           errorNumbersToAdd: null);
}));

// configure DI for application services
builder.Services.AddScoped<ITowns, TownService>();
builder.Services.AddScoped<ICompany, CompanyService>();
builder.Services.AddScoped<ISaqua, SaqaQualificationService>();
builder.Services.AddScoped<ICompanyLeaners, CompanyLearnerService>();
builder.Services.AddScoped<ISingleUser, SingleUserService>();
builder.Services.AddScoped<ICompLearner, CompLearnerService>();
builder.Services.AddScoped<IIntervention, InterventionService>();
builder.Services.AddScoped<IFunding, FundingService>();
builder.Services.AddScoped<ITrainingProvider, TrainingProviderService>();
builder.Services.AddScoped<IUsers, UserService>();

/*builder.Services.AddCors((setup) =>
{
    setup.AddPolicy("default", (options) =>
    {
        options.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
    });

}); */


/*var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:4200",
                                              "https://localhost:7253/api/User");
                      });
}); */


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

//app.UseCors("default");
//app.UseCors(MyAllowSpecificOrigins);
app.UseCorsExtension();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
