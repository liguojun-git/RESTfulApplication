using WebApplication1.Services;
using WebApplication1.Services.IServices;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddCors(c => c.AddPolicy("any",p=> p.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));


builder.Services.AddControllers();
builder.Services.AddTransient<IUserService,UserService>();


builder.Services.AddTransient<IIocService1, IocService1>();
builder.Services.AddTransient<IIocService2, IocService2>();
// 作用域服务
builder.Services.AddScoped<IscopedService, scopedService>();
// 单例作用域
builder.Services.AddSingleton<IsingletonService, singletonService>();
// 瞬时作用域
builder.Services.AddTransient<ItransientService, transientService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGet("/", () =>
{
    return "ace";
});

//app.MapPost("/", (TestPostEditViewModel model) =>
//{
//    return model;
//});

app.MapPost("/", (UserService userService) =>
{
    return userService.UserName();
});

app.Run();


