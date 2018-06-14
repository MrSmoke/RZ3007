namespace ClassLibrary1
{
    using System.Reflection;
    using Microsoft.AspNetCore.Mvc.Razor;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.FileProviders;

    public static class ServiceExtensions
    {
        public static void AddWeb(this IServiceCollection services, IMvcBuilder mvcBuilder)
        {
            var currentAssembly = typeof(ServiceExtensions).GetTypeInfo().Assembly;
            var fileProvider = new EmbeddedFileProvider(currentAssembly);

            // In the event you're using this for static resources (not Views)
            services.AddSingleton<IFileProvider>(fileProvider);
        }
    }
}
