using DependencyInjectionExercise;
using Unity.Microsoft.DependencyInjection;

namespace WebApplication3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var container = CreateHostBuilder(args).Build();
            ContainerProvider.Container = container;
            container.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseUnityServiceProvider()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
