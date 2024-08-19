namespace ApiGateway
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)

                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    // ajoute le fichier ocelot.json � la configuration de l�application, o� les routes Ocelot sont d�finies
                    config.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
                })

                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
