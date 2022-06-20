/*
Because our Angular application will be running on a different hostname, we will need to enable CORS. We should only enable CORS for the hostname of our Angular application, but for this simple demo we will enable CORS for all domains. Why do we have to do this? What is CORS? CORS is a security mechanism that browsers use to help prevent malicious scripts from running code without a user’s knowledge. With CORS, we restrict our applications as much as possible.
*/
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x =>
x.AllowAnyMethod()
.AllowAnyOrigin()
.AllowAnyHeader()
.SetIsOriginAllowed(origin => true));

app.UseAuthorization();

app.MapControllers();

app.Run();
