using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace WebApiMyApp
{
    public static class DataBaseSeeder
    {
        public static void SeedData(this IApplicationBuilder app)
        {
            using (var scope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>().CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppEFContext>();
                context.Database.Migrate();
            }
        }
    }
}
