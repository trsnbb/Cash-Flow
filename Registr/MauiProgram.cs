using Infrastructure;
using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Registr
{
    public static class MauiProgram
    {
        public static IncomingRepository IncomingRepository { get; private set; }

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Montserrat-Regular.ttf", "Montserrat");
                    fonts.AddFont("Montserrat-Bold.ttf", "MontserratBold");

                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            SetCultureInfo();
            ConfigDb();

            return builder.Build();
        }

        private static void SetCultureInfo()
        {
            CultureInfo culture = new CultureInfo("en");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }

        private static void ConfigDb()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "cach-flow.db3");
            IncomingRepository = new IncomingRepository(dbPath);
        }
    }
}
