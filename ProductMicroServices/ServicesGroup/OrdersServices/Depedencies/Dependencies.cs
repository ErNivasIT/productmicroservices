using MongoDB.Services;

public static class Depedencies
{
    public static void ManageDepedencies(this WebApplicationBuilder app)
    {
        app.Services.AddScoped<ICustomerOrdersBAL, CustomerOrdersBAL>();
        app.Services.AddScoped<ICustomerOrdersDAL, CustomerOrdersDAL>();
        app.Services.Configure<DbOptions>(
        app.Configuration.GetSection("DbOptions"));
        app.Services.AddSingleton<CustomerOrdersService>();
        app.Services.AddAutoMapper(typeof(Program));
    }
}