using LibaryAPI.Infrastructure.ModelConfiguration;
using LibaryAPI.Infrastructure.Models.Books;
using LibaryAPI.Infrastructure.Models.Readers;
using Microsoft.EntityFrameworkCore;

namespace LibaryAPI.Infrastructure;
public class LibaryDbContext:DbContext
{
    public LibaryDbContext(DbContextOptions<LibaryDbContext> options) : base(options) { }
    public LibaryDbContext() { }

    public DbSet<BookModel> Books { get; set; }
    public DbSet<ReaderModel> Readers { get; set; }
    public DbSet<ReaderNewsletterModel> ReadersNewsletter { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new BaseModelConfiguration<BookModel>());
        modelBuilder.ApplyConfiguration(new BaseModelConfiguration<ReaderModel>());
        modelBuilder.ApplyConfiguration(new BaseModelConfiguration<ReaderNewsletterModel>());
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Libary;Username=postgres;Password=jangir001");
        ///*UseNpgsql был вызван для того что не понятной мне причине миграциия никак не хотела себя проявлять*//
        ///*Пытался без этого метода через проект LibaryAPI и LibaryAPI.Infrastructure но выдавлвал разные ошибки
        ///*и что бы не тратить время сделал так*//
    }

}
