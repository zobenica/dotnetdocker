namespace myWebApp.Startup
{
    public static partial class ServiceInitializer
    {
        public static WebApplication ConfigureMiddleware(this WebApplication app)
        {
            //app.UseSwagger().UseSwaggerUI();

            //app.UseHttpsRedirection();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
            }

            return app;
        }
    }
}
