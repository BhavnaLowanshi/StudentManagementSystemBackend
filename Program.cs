//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//builder.Services.AddControllers();
//// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();


//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Data;
//using SchoolManagement.Api.Services;

//var builder = WebApplication.CreateBuilder(args);

//// Add Controllers
//builder.Services.AddControllers();

//// Swagger
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// Database
//builder.Services.AddDbContext<SchoolDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
//);

//// Services
//builder.Services.AddScoped<LeaveService>();
//builder.Services.AddScoped<AuthService>();
//builder.Services.AddScoped<NoticeService>();

//var app = builder.Build();

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();
//app.MapControllers();

//app.Run();



//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Data;
//using SchoolManagement.Api.Services;

//var builder = WebApplication.CreateBuilder(args);

//// -------------------- Services --------------------

//// Controllers
//builder.Services.AddControllers();

//// Swagger
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// Database
//builder.Services.AddDbContext<SchoolDbContext>(options =>
//    options.UseSqlServer(
//        builder.Configuration.GetConnectionString("DefaultConnection")
//    )
//);

//// Custom Services
//builder.Services.AddScoped<LeaveService>();
//builder.Services.AddScoped<AuthService>();
//builder.Services.AddScoped<NoticeService>();

//var app = builder.Build();

//// -------------------- Middleware --------------------

//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.UseHttpsRedirection();

//// 🔹 Ye line add karna BEST PRACTICE hai
//app.UseAuthorization();

//app.MapControllers();

//app.Run();


//using Microsoft.EntityFrameworkCore;
//using SchoolManagement.Api.Data;

//var builder = WebApplication.CreateBuilder(args);

//// 🔹 Add services
//builder.Services.AddControllers();

//// 🔹 Swagger services (MUST)
//builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

//// 🔹 DbContext (example)
//builder.Services.AddDbContext<SchoolDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//var app = builder.Build();

//// 🔹 Swagger middleware (TEMPORARILY without condition)
//app.UseSwagger();
//app.UseSwaggerUI(c =>
//{
//    c.SwaggerEndpoint("/swagger/v1/swagger.json", "School API V1");
//});

//app.UseHttpsRedirection();
//app.UseAuthorization();

//app.MapControllers();

//app.Run();

using Microsoft.EntityFrameworkCore;
using SchoolManagement.Api.Data;
using SchoolManagement.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Controllers
builder.Services.AddControllers();

// 🔹 Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// 🔹 DbContext
builder.Services.AddDbContext<SchoolDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

// 🔹 Services
builder.Services.AddScoped<LeaveService>();

var app = builder.Build();

// 🔹 Swagger enable (development + optional production)
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "School API V1");
    c.RoutePrefix = string.Empty; // Swagger root page = http://localhost:<port>/
});

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

