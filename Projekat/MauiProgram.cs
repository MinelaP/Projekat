using Microsoft.Extensions.Logging;
using Projekat.Services;
using System.IO;

namespace Projekat
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
                });

            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "projekat.db3");
            builder.Services.AddSingleton(new SQLiteHelper(dbPath));

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
