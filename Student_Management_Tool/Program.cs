using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Student_Management_Tool.Data;
namespace Student_Management_Tool
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var serviceProvider = new ServiceCollection()
                .AddDbContext<StudentManagementContext>(options =>
                    options.UseSqlServer(DatabaseConfig.ConnectionString)) //dependency injection
                .AddTransient<FormAnaMenu>()
                .AddTransient<FormAddStudent>()
                .BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormAnaMenu(serviceProvider.GetRequiredService<StudentManagementContext>()));
        }   
    }
}
