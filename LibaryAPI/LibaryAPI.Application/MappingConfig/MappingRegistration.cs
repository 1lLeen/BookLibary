using Microsoft.Extensions.DependencyInjection;

namespace LibaryAPI.Application.MappingConfig;

public static class MappingRegistration
{
    public static void RegistrationAutoMapper(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(MappingProfile));
    }
}
