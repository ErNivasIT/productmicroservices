using Microsoft.EntityFrameworkCore;
using Npgsql;

public static class Depedencies
{
    public static void ManageDepedencies(this WebApplicationBuilder app)
    {
        app.Services.AddScoped<ITrackOrderBAL,TrackOrderBAL>();
        app.Services.AddScoped<ITrackOrderDAL,TrackOrderDAL>();
        app.Services.AddAutoMapper(typeof(Program));
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        app.Services.AddDbContext<ApplicationContext>(option =>
        {
            option.UseNpgsql(app.Configuration.GetConnectionString("TrackOrderConn"));
        });
    }
}