namespace CustomMiddleware
{
    public class LoggerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {

            Console.WriteLine("Custom START Middleware");
            await next(context);
            Console.WriteLine("Custom AFTER Middleware");

        }
    }
}
