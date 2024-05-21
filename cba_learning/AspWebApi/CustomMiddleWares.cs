namespace AspWebApi
{
    public static class CustomMiddleWares
    {
        public static void UseMyCustomMiddleware1(this WebApplication app)
        {
            app.Use(async (context, next) => {
                // logging of your request
                context.Response.WriteAsync("Hello From Middleware request pipeline 1 \n");
                await next();
                context.Response.WriteAsync("Hello From Middleware response pipeline 1 \n");
            });
        }
        public static void UseMyCustomMiddleware2(this WebApplication app)
        {
            app.Use(async (context, next) => {
                // logging of your request
                context.Response.WriteAsync("Hello From Middleware request pipeline 2 \n");
                await next();
                context.Response.WriteAsync("Hello From Middleware response pipeline 2 \n");
            });
        }
    }
}
