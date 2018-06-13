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


            //Add current assembly to application parts
            mvcBuilder.AddApplicationPart(currentAssembly);

            var fileProvider = new EmbeddedFileProvider(currentAssembly);

            services.AddSingleton<IFileProvider>(fileProvider);

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.FileProviders.Clear();
                options.FileProviders.Add(fileProvider);
            });
        }
    }
}
