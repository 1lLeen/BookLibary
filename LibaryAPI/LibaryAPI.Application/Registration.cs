using LibaryAPI.Application.Services.BooksService;
using LibaryAPI.Application.Services.Interfaces;
using LibaryAPI.Application.Services.ReadersService;
using LibaryAPI.Infrastructure.Repositories;
using LibaryAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging; 

namespace LibaryAPI.Application;

public static class Registration
{
    public static void RegistrationLogger(this IServiceCollection services)
    {
        var serviceProvider = services.BuildServiceProvider();
        var loggerBook = serviceProvider.GetRequiredService<ILogger<BookService>>();
        var loggerReader = serviceProvider.GetRequiredService<ILogger<ReaderService>>();
        var loggerReaderNewsletter = serviceProvider.GetRequiredService<ILogger<ReaderService>>();
        services.AddSingleton(typeof(ILogger), loggerBook);
        services.AddSingleton(typeof(ILogger), loggerReader);
        services.AddSingleton(typeof(ILogger), loggerReaderNewsletter);
    }
    public static void RegistrationRepositories(this IServiceCollection services)
    {
        services.AddTransient<IBookRepository, BookRepository>();
        services.AddTransient<IReaderRepository, ReaderRepository>();
        services.AddTransient<IReaderNewsletterRepository, ReaderNewsletterRepository>();

    }
    public static void RegistrationServices(this IServiceCollection services)
    {
        services.AddTransient<IBookService, BookService>();
        services.AddTransient<IReaderService, ReaderService>();
        services.AddTransient<IReaderNewsletterService, ReaderNewsletterService>();
    }
     
}
public static class MediatRDependencyHandler
{
    public static IServiceCollection RegisterRequestHandlers(
    this IServiceCollection services)
    {
        return services
            .AddMediatR(cf => cf.RegisterServicesFromAssembly(typeof(MediatRDependencyHandler).Assembly));
    }
}
