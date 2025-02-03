using LibaryAPI.Infrastructure.ModelConfiguration;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Models.Readers;
using Microsoft.EntityFrameworkCore;

namespace LibaryAPI.Infrastructure;
public class LibaryDbContext:DbContext
{
    public LibaryDbContext(DbContextOptions<LibaryDbContext> options) : base(options) {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
    public LibaryDbContext() { }///*Unable to create a 'DbContext' of type 'RuntimeType'. The exception 'Unable to resolve service for type*///
    /*Решение проблемы с проблемы с помощью пустого конструктора*/
    public DbSet<BookModel> Books { get; set; }
    public DbSet<ReaderModel> Readers { get; set; }
    public DbSet<ReaderNewsletterModel> ReadersNewsletter { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // использование Fluent API
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BaseModelConfiguration<BookModel>());
        modelBuilder.ApplyConfiguration(new BaseModelConfiguration<ReaderModel>());
        modelBuilder.ApplyConfiguration(new BaseModelConfiguration<ReaderNewsletterModel>());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Libary;Username=postgres;Password=jangir001");//Нужно вставить свои данные
        ///*UseNpgsql был вызван для того что не понятной мне причине миграциия никак не хотела себя проявлять*//
        ///*Пытался без этого метода через проект LibaryAPI и LibaryAPI.Infrastructure но выдавлвал разные ошибки
        ///*и что бы не тратить время сделал так*//
    }

}
