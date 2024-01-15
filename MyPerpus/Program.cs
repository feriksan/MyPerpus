using Microsoft.Extensions.DependencyInjection;
using MyPerpus.Repositories.UserRepo;

namespace MyPerpus
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
            ApplicationConfiguration.Initialize();
            ServiceProvider = new ServiceCollection()
                .AddScoped<IUserRepo, DbUserRepo>()
                .BuildServiceProvider() ;
            Application.Run(new Form1());
        }

        //variable service provider
        public static ServiceProvider? ServiceProvider { get; private set; }
    }
}