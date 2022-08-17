namespace Vincit.PM
{
    internal static class Program
    {
        // TODO: Make this configuration based. Maybe even an env variable
        const string JobscopeApiBaseAddress = "https://jobscope01/JeeApi/";

        public static IServiceProvider? ServiceProvider { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Configure Dependency Injection Container
            var serviceCollection = new ServiceCollection();
            ConfigureServiceCollection(serviceCollection);
            serviceCollection.AddLogging();
            ServiceProvider = serviceCollection.BuildServiceProvider();

            Application.Run(ServiceProvider.GetService<MainForm>());
        }

        private static void ConfigureServiceCollection(IServiceCollection services)
        {
            services.AddSingleton(factory =>
            {
                var username = Environment.GetEnvironmentVariable(variable: "JOBSCOPEAPI_USERNAME");
                if (string.IsNullOrWhiteSpace(username))
                {
                    throw new ArgumentNullException(paramName: "username", message: "JOBSCOPEAPI_USERNAME value not found!");
                }

                var password = Environment.GetEnvironmentVariable(variable: "JOBSCOPEAPI_PASSWORD");
                if (string.IsNullOrWhiteSpace(password))
                {
                    throw new ArgumentNullException(paramName: "username", message: "JOBSCOPEAPI_PASSWORD value not found!");
                }

                return new Credentials
                {
                    Username = username,
                    Password = password
                };
            });

            services.AddSingleton<AppState>();

            services.AddTransient<AuthorizationHandler>();

            services
                .AddHttpClient("Vincit.Jobscope", client => client.BaseAddress = new Uri(uriString: JobscopeApiBaseAddress))
                .AddHttpMessageHandler<AuthorizationHandler>();

            services
                .AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Vincit.Jobscope"));

            services.AddScoped<IJobscopeClient, JobscopeClient>();

            services.AddTransient<MainForm>();
        }
    }
}