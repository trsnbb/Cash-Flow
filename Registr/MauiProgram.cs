using Microsoft.Extensions.Logging;
using System.Globalization;

namespace Registr
{
    public static class MauiProgram
    {
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

            return builder.Build();
        }

        private static void SetCultureInfo()
        {
            CultureInfo culture = new CultureInfo("uk");
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;
        }
    }
}
