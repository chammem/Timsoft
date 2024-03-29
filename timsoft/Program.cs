using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System.Text;
using timsoft.DataBase;
using timsoft.repositories;
using timsoft.services;
using timsoft.Utils;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        Description = "Standard Authorization header using the Bearer scheme (\"bearer {token}\")",
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
// Add services to the container.



builder.Services.AddControllers();

builder.Services.AddDbContext<DataBaseContext>(
    o => o.UseNpgsql(builder.Configuration.GetConnectionString("Timsoft")));

builder.Services.AddCors(o => o.AddPolicy(name: "SuperHeroOrigins",
   policy => { policy.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader(); }));
 

builder.Services.AddTransient<IQuestionRepository, QuestionRepository>();
builder.Services.AddTransient<IQuestionService, QuestionService>();

builder.Services.AddTransient<IUtil, Util>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddTransient<IUserRepository, UserRepository>();

builder.Services.AddTransient<IInvitationRepository, InvitationRepository>();
builder.Services.AddTransient<IInvitationService, InvitationService>();

builder.Services.AddTransient<IEpreuveRepository, EpreuveRepository>();
builder.Services.AddTransient<IEpreuveService, EpreuveService>();

builder.Services.AddTransient<IRéclamationRepository, RéclamationRepository>();
builder.Services.AddTransient<IRéclamationService, RéclamationService>();

builder.Services.AddTransient<IRéclamationRepository, RéclamationRepository>();
builder.Services.AddTransient<IRéclamationService, RéclamationService>();


builder.Services.AddTransient<IReponseRepository, ReponseRepository>();
builder.Services.AddTransient<IReponseService, ReponseService>();

builder.Services.AddTransient<IType_EpreuveRepository, Type_EpreuveRepository>();
builder.Services.AddTransient<IType_EpreuveService, Type_EpreuveService>();

builder.Services.AddTransient<IRoleRepository, RoleRepository>();
builder.Services.AddTransient<IRoleService, RoleService>();



//JWT Authentication
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8
                   .GetBytes("superSecretKey@345")),
           // builder.Configuration.GetSection("Jwt:key").Value
            ValidateIssuer = true,
            ValidateAudience = true ,
            ValidateLifetime = true ,
            ValidIssuer = "http://localhost:4200",
            ValidAudience = "http://localhost:4200"
        };
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("SuperHeroOrigins");
app.UseHttpsRedirection();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
