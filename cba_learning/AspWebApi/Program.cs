class Program
{
    static void Main(string[] args)
    {
        // we are configuring a web solutions 
        var builder = WebApplication.CreateBuilder(args);

        #region :: Configure Service for DI ::
        // Add services to the container.
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddControllers(); // select the web solution type  Controllers with swagger feature 
        
       /* builder.Services.AddSwaggerGen(); // openapi sepc is create */

        #endregion


        // create a web application 
        var app = builder.Build();

        #region :: Configure Middlewares for your appication ::
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
           /* app.UseSwagger();
            app.UseSwaggerUI();*/
        }

        app.MapGet("/greetings", () =>
        {
            var hello = "Hello world";
            return hello;
        });

        app.MapGet("/bye", () =>
        {
            var hello = "See you later";
            return hello;
        });

        #endregion 

        // running your application 
        app.Run();
    }
}
