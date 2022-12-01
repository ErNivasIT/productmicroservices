using Microsoft.EntityFrameworkCore;
using ProductServices.BAL;
using ProductServices.DAL;
using ProductServices.Models;
using System.Reflection;

namespace ProductServices.Depedencies
{
    public static class Depedencies
    {
        public static void ManageDepedencies(this WebApplicationBuilder app)
        {
            app.Services.AddScoped<IProductBAL, ProductBAL>();
            app.Services.AddScoped<IProductDAL, ProductDAL>();
            app.Services.AddAutoMapper(typeof(Program));
        }
    }
}
