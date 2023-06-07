namespace myWebApp.Startup
{
    public static partial class ServiceInitializer
    {
        public static WebApplication RegisterEndpoints(this WebApplication app)
        {
            //app.UseSwagger().UseSwaggerUI();

            // app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapRazorPages();

            return app;
        }
    }
}
