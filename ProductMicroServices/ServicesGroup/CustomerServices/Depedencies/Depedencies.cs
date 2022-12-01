using CustomerServices.BAL;
using CustomerServices.DAL;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ProductServices.Depedencies
{
    public static class Depedencies
    {
        public static void ManageDepedencies(this WebApplicationBuilder app)
        {
            app.Services.AddScoped<ICustomerBAL, CustomerBAL>();
            app.Services.AddScoped<ICustomerDAL, CustomerDAL>();
            app.Services.AddAutoMapper(typeof(Program));
        }
    }
}
