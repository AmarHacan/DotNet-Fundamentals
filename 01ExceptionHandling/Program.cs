using System.Web.Http.ExceptionHandling;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.Run();


public class CustomExceptionHandling : IExceptionHandler
{
    public Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}