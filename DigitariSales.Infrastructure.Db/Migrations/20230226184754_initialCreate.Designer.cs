// <auto-generated />
using DigitalSales.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DigitariSales.Infrastructure.Db.Migrations
{
    [DbContext(typeof(DigitariContext))]
    [Migration("20230226184754_initialCreate")]
    partial class initialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DigitariSales.Domain.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "en"
                        },
                        new
                        {
                            Id = 2,
                            Name = "fr"
                        },
                        new
                        {
                            Id = 3,
                            Name = "it"
                        },
                        new
                        {
                            Id = 4,
                            Name = "de"
                        },
                        new
                        {
                            Id = 5,
                            Name = "pl"
                        },
                        new
                        {
                            Id = 6,
                            Name = "es"
                        },
                        new
                        {
                            Id = 7,
                            Name = "sv"
                        },
                        new
                        {
                            Id = 8,
                            Name = "ru"
                        },
                        new
                        {
                            Id = 9,
                            Name = "ra"
                        },
                        new
                        {
                            Id = 10,
                            Name = "ja"
                        },
                        new
                        {
                            Id = 11,
                            Name = "zu"
                        },
                        new
                        {
                            Id = 12,
                            Name = "ta"
                        },
                        new
                        {
                            Id = 13,
                            Name = "af"
                        },
                        new
                        {
                            Id = 14,
                            Name = "sq"
                        },
                        new
                        {
                            Id = 15,
                            Name = "ca"
                        },
                        new
                        {
                            Id = 16,
                            Name = "zh"
                        },
                        new
                        {
                            Id = 17,
                            Name = "ko"
                        },
                        new
                        {
                            Id = 18,
                            Name = "ms"
                        },
                        new
                        {
                            Id = 19,
                            Name = "dk"
                        },
                        new
                        {
                            Id = 20,
                            Name = "fa"
                        },
                        new
                        {
                            Id = 21,
                            Name = "fi"
                        },
                        new
                        {
                            Id = 22,
                            Name = "lv"
                        },
                        new
                        {
                            Id = 23,
                            Name = "da"
                        },
                        new
                        {
                            Id = 24,
                            Name = "nl"
                        });
                });

            modelBuilder.Entity("DigitariSales.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("DefaultLanguageId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("DefaultLanguageId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DefaultLanguageId = 1
                        },
                        new
                        {
                            Id = 2,
                            DefaultLanguageId = 1
                        },
                        new
                        {
                            Id = 3,
                            DefaultLanguageId = 1
                        },
                        new
                        {
                            Id = 4,
                            DefaultLanguageId = 5
                        },
                        new
                        {
                            Id = 5,
                            DefaultLanguageId = 1
                        },
                        new
                        {
                            Id = 6,
                            DefaultLanguageId = 10
                        },
                        new
                        {
                            Id = 7,
                            DefaultLanguageId = 15
                        },
                        new
                        {
                            Id = 8,
                            DefaultLanguageId = 2
                        },
                        new
                        {
                            Id = 9,
                            DefaultLanguageId = 20
                        },
                        new
                        {
                            Id = 10,
                            DefaultLanguageId = 1
                        });
                });

            modelBuilder.Entity("LanguageUser", b =>
                {
                    b.Property<int>("LanguagesId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("LanguagesId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("LanguageUser");

                    b.HasData(
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 1
                        },
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 2
                        },
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 3
                        },
                        new
                        {
                            LanguagesId = 2,
                            UsersId = 3
                        },
                        new
                        {
                            LanguagesId = 3,
                            UsersId = 3
                        },
                        new
                        {
                            LanguagesId = 4,
                            UsersId = 3
                        },
                        new
                        {
                            LanguagesId = 5,
                            UsersId = 4
                        },
                        new
                        {
                            LanguagesId = 6,
                            UsersId = 4
                        },
                        new
                        {
                            LanguagesId = 7,
                            UsersId = 4
                        },
                        new
                        {
                            LanguagesId = 8,
                            UsersId = 4
                        },
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 5
                        },
                        new
                        {
                            LanguagesId = 9,
                            UsersId = 5
                        },
                        new
                        {
                            LanguagesId = 10,
                            UsersId = 6
                        },
                        new
                        {
                            LanguagesId = 11,
                            UsersId = 6
                        },
                        new
                        {
                            LanguagesId = 12,
                            UsersId = 6
                        },
                        new
                        {
                            LanguagesId = 13,
                            UsersId = 6
                        },
                        new
                        {
                            LanguagesId = 14,
                            UsersId = 6
                        },
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 6
                        },
                        new
                        {
                            LanguagesId = 15,
                            UsersId = 7
                        },
                        new
                        {
                            LanguagesId = 16,
                            UsersId = 7
                        },
                        new
                        {
                            LanguagesId = 17,
                            UsersId = 7
                        },
                        new
                        {
                            LanguagesId = 18,
                            UsersId = 7
                        },
                        new
                        {
                            LanguagesId = 2,
                            UsersId = 8
                        },
                        new
                        {
                            LanguagesId = 19,
                            UsersId = 8
                        },
                        new
                        {
                            LanguagesId = 20,
                            UsersId = 9
                        },
                        new
                        {
                            LanguagesId = 21,
                            UsersId = 9
                        },
                        new
                        {
                            LanguagesId = 22,
                            UsersId = 9
                        },
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 9
                        },
                        new
                        {
                            LanguagesId = 1,
                            UsersId = 10
                        },
                        new
                        {
                            LanguagesId = 4,
                            UsersId = 10
                        },
                        new
                        {
                            LanguagesId = 2,
                            UsersId = 10
                        },
                        new
                        {
                            LanguagesId = 23,
                            UsersId = 10
                        },
                        new
                        {
                            LanguagesId = 24,
                            UsersId = 10
                        });
                });

            modelBuilder.Entity("DigitariSales.Domain.User", b =>
                {
                    b.HasOne("DigitariSales.Domain.Language", "DefaultLanguage")
                        .WithMany()
                        .HasForeignKey("DefaultLanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DefaultLanguage");
                });

            modelBuilder.Entity("LanguageUser", b =>
                {
                    b.HasOne("DigitariSales.Domain.Language", null)
                        .WithMany()
                        .HasForeignKey("LanguagesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DigitariSales.Domain.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
