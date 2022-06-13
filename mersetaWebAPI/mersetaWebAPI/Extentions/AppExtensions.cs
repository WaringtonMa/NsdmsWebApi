using Microsoft.AspNetCore.Builder;
//using WebApi.Middlewares;

namespace mersetaWebAPI.Extentions
{
    public static class AppExtensions
    {
        public static void UseSwaggerExtension(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "mersetaWebAPI");
            });
        }
        public static void UseErrorHandlingMiddleware(this IApplicationBuilder app)
        {
          // app.UseMiddleware<ErrorHandlerMiddleware>();
        }

        public static void UseCorsExtension(this IApplicationBuilder app)
        {
            app.UseCors(x => x
               .AllowAnyMethod()
               .AllowAnyHeader()
               .SetIsOriginAllowed(origin => true) // allow any origin
               .AllowCredentials()); // allow credentials
        }
    }
}
