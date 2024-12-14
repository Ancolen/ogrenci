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

            //docker indir
            //docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=<StrongPassword123!>" -p 1433:1433 --name sql1 -d mcr.microsoft.com/mssql/server:2019-latest
            //docker exec -it sql1 "bash"
            //amazonu aç mouse sipariþi ver
            // /opt/mssql-tools/bin/sqlcmd -S localhost -U sa -P "<StrongPassword123!>"
            //CREATE DATABASE StudentManagement
            //

            var serviceProvider = new ServiceCollection()
                .AddDbContext<StudentManagementContext>(options =>
                    options.UseSqlServer(DatabaseConfig.ConnectionString)) //dependency injection
                .AddTransient<FormGiriþ>()
                .AddTransient<FormAnaMenu>()
                .AddTransient<FormÖðrenciEkle>()
                .BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(new FormGiriþ(serviceProvider.GetRequiredService<StudentManagementContext>()));
        }   
    }
}
