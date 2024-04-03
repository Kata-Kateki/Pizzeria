public class RootRedirectMiddleware
{
    private readonly RequestDelegate next;

    public RootRedirectMiddleware(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task Invoke(HttpContext context)
    {
        if (context.Request.Path == "/")
        {
            context.Response.Redirect("/Pizza"); // Adjust controller and action as needed
        }
        else
        {
            await next(context);
        }
    }
}