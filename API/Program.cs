using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddCors();

builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddAuthentication(JWTBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options => )

// void JWTBearerDefaults(AuthenticationOptions options)
// {
//     throw new NotImplementedException();
// }

// void JWTBearerDefaults(AuthenticationOptions options)
// {
//     throw new NotImplementedException();
// }

var app = builder.Build();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));

app.MapControllers();
app.Run();