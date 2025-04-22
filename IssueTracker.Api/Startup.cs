using IssueTracker.Api.Extensions;
using IssueTracker.Application;
using IssueTracker.Persistence;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Api
{
    public static class Startup
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {

            builder.Services.AddApplicationServices();
            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseCustomExceptionHandler();
            app.UseHttpsRedirection();
            app.MapControllers();
            return app;
        }

        public static async Task ResetDatabaseAsync(this WebApplication app)
        {

            using var scope = app.Services.CreateScope();
            try
            {
                var context = scope.ServiceProvider.GetService<IssueTrackerDbContext>();
                if (context != null)
                {
                    await context.Database.EnsureDeletedAsync();
                    await context.Database.MigrateAsync();

                }
            }
            catch (Exception ex)
            {
                // log exception here
            }
        }
    }
}
