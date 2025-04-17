using Microsoft.EntityFrameworkCore;
using ToDoList.Dal;
using System.Runtime.CompilerServices;
using ToDoList.Repository.SqlConnectionString;

namespace Exam5.Configurations
{
    public static class DatabaseConfiguration
    {
        public static void Configuration(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

            builder.Services.AddSingleton(new SqlDBConnectionString(connectionString));

            builder.Services.AddDbContext<MainContext>(options =>
                options.UseSqlServer(connectionString));
        }

        
    }
}
