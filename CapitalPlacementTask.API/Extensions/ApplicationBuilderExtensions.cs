using CapitalPlacementTask.Application.Utilities;

namespace CapitalPlacementTask.API.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder AddGlobalErrorHandler(this IApplicationBuilder applicationBuilder)
        {
            return applicationBuilder.UseMiddleware<GlobalExceptionHandler>();
        }
    }
}
