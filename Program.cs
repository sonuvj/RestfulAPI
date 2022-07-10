using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace RestfulAPI
{
    /// <summary>
    /// Web API execution start point.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Defines the entry point of application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Creates the web host builder.
        /// </summary>
        /// <param name="args">The arguments.</param>
        /// <returns>Returns the web host builder.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
