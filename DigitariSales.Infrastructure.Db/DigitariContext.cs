using DigitariSales.Domain;
using DigitariSales.Infrastructure.Db.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DigitalSales.Infrastructure.Db
{
    public class DigitariContext : DbContext
    {
        private readonly IOptions<DbOptions> _options;

        public DigitariContext(IOptions<DbOptions> options)
        {
            _options = options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseNpgsql(_options.Value.ConnectionString);

        public DbSet<User> Users { get; set; }
        public DbSet<Language> Languages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>()
                .HasOne(a => a.DefaultLanguage)
                .WithMany();

            var languageBuilder = modelBuilder.Entity<Language>();
            var userBuilder = modelBuilder.Entity<User>();
            var languageUserBuilder = modelBuilder.Entity("LanguageUser");

            languageBuilder.HasData(
                new Language() { Id = 1, Name = "en" },
                new Language() { Id = 2, Name = "fr" },
                new Language() { Id = 3, Name = "it" },
                new Language() { Id = 4, Name = "de" },
                new Language() { Id = 5, Name = "pl" },
                new Language() { Id = 6, Name = "es" },
                new Language() { Id = 7, Name = "sv" },
                new Language() { Id = 8, Name = "ru" },
                new Language() { Id = 9, Name = "ra" },
                new Language() { Id = 10, Name = "ja" },
                new Language() { Id = 11, Name = "zu" },
                new Language() { Id = 12, Name = "ta" },
                new Language() { Id = 13, Name = "af" },
                new Language() { Id = 14, Name = "sq" },
                new Language() { Id = 15, Name = "ca" },
                new Language() { Id = 16, Name = "zh" },
                new Language() { Id = 17, Name = "ko" },
                new Language() { Id = 18, Name = "ms" },
                new Language() { Id = 19, Name = "dk" },
                new Language() { Id = 20, Name = "fa" },
                new Language() { Id = 21, Name = "fi" },
                new Language() { Id = 22, Name = "lv" },
                new Language() { Id = 23, Name = "da" },
                new Language() { Id = 24, Name = "nl" }
            );

            userBuilder.HasData(
                new User() { Id = 1, DefaultLanguageId = 1 },
                new User() { Id = 2, DefaultLanguageId = 1 },
                new User() { Id = 3, DefaultLanguageId = 1 },
                new User() { Id = 4, DefaultLanguageId = 5 },
                new User() { Id = 5, DefaultLanguageId = 1 },
                new User() { Id = 6, DefaultLanguageId = 10 },
                new User() { Id = 7, DefaultLanguageId = 15 },
                new User() { Id = 8, DefaultLanguageId = 2 },
                new User() { Id = 9, DefaultLanguageId = 20 },
                new User() { Id = 10, DefaultLanguageId = 1 }
            );

            languageUserBuilder.HasData(
                new { UsersId = 1, LanguagesId = 1},
                new { UsersId = 2, LanguagesId = 1 },
                new { UsersId = 3, LanguagesId = 1 },
                new { UsersId = 3, LanguagesId = 2 },
                new { UsersId = 3, LanguagesId = 3 },
                new { UsersId = 3, LanguagesId = 4 },
                new { UsersId = 4, LanguagesId = 5 },
                new { UsersId = 4, LanguagesId = 6 },
                new { UsersId = 4, LanguagesId = 7 },
                new { UsersId = 4, LanguagesId = 8 },
                new { UsersId = 5, LanguagesId = 1 },
                new { UsersId = 5, LanguagesId = 9 },
                new { UsersId = 6, LanguagesId = 10 },
                new { UsersId = 6, LanguagesId = 11 },
                new { UsersId = 6, LanguagesId = 12 },
                new { UsersId = 6, LanguagesId = 13 },
                new { UsersId = 6, LanguagesId = 14 },
                new { UsersId = 6, LanguagesId = 1 },
                new { UsersId = 7, LanguagesId = 15 },
                new { UsersId = 7, LanguagesId = 16 },
                new { UsersId = 7, LanguagesId = 17 },
                new { UsersId = 7, LanguagesId = 18 },
                new { UsersId = 8, LanguagesId = 2 },
                new { UsersId = 8, LanguagesId = 19 },
                new { UsersId = 9, LanguagesId = 20 },
                new { UsersId = 9, LanguagesId = 21 },
                new { UsersId = 9, LanguagesId = 22 },
                new { UsersId = 9, LanguagesId = 1 },
                new { UsersId = 10, LanguagesId = 1 },
                new { UsersId = 10, LanguagesId = 4 },
                new { UsersId = 10, LanguagesId = 2 },
                new { UsersId = 10, LanguagesId = 23 },
                new { UsersId = 10, LanguagesId = 24 }
            );
        }
    }
}