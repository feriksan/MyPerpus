using Microsoft.Extensions.DependencyInjection;
using MyPerpus.Repositories.BookRepo;
using MyPerpus.Repositories.UserRepo;
using MyPerpus.Repositories.AnggotaRepo;
using MyPerpus.Views;
using MyPerpus.Repositories.PeminjamanRepo;
using MyPerpus.Repositories.PengembalianRepo;

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
                .AddScoped<IBookRepo, DbBookRepo>()
                .AddScoped<IAnggotaRepo, DbAnggotaRepo>()
                .AddScoped<IPeminjamanRepo, DbPeminjamanRepo>()
                .AddScoped<IPengembalianRepo, DbPengembalianRepo>()
                .BuildServiceProvider() ;
            Application.Run(new FormHome());
        }

        //variable service provider
        public static ServiceProvider? ServiceProvider { get; private set; }
    }
}