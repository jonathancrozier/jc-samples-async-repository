using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace JC.Samples.AsyncRepository.App
{
    /// <summary>
    /// Main Program class.
    /// </summary>
    public class Program
    {
        #region Methods

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The command-line arguments passed to the program</param>
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Initialises the web hosting environment and runs the application in it.
        /// </summary>
        /// <param name="args">The command-line arguments</param>
        /// <returns><see cref="IHostBuilder"/></returns>
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        #endregion
    }
}