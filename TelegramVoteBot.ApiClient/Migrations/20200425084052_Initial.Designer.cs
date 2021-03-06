﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TelegramVoteBot.ApiClient.Persistence;

namespace TelegramVoteBot.ApiClient.Migrations
{
    [DbContext(typeof(BotDbContext))]
    [Migration("20200425084052_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("TelegramVoteBot.ApiClient.Entities.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Author")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Urls")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "@Vit",
                            Name = "Инвертор 24 - 220 В 1500 ВА",
                            Urls = "https://telegra.ph/Proekt-1-Invertor-24-220-V-1500-VA-01-23"
                        },
                        new
                        {
                            Id = 2,
                            Author = "@dmitriy_shi",
                            Name = "PIndastrial shield — модуль питания и интерфейса RS-485 для Raspberry PI",
                            Urls = "https://habr.com/ru/post/486258/,https://gitlab.com/dm_sh/pindastrial_shield"
                        },
                        new
                        {
                            Id = 3,
                            Author = "@Dab0G",
                            Name = "IoT шлюз Ethernet-RS485 на базе STM32",
                            Urls = "https://habr.com/ru/post/488408/,https://github.com/mysensors-rus/STM32_Ethernet-RS485_gate"
                        },
                        new
                        {
                            Id = 4,
                            Author = "@EfektaSB",
                            Name = "Ардуино термометр & гигрометр с E-PAPER на nRF52832 — или о том, что забыли выпустить производители",
                            Urls = "https://habr.com/ru/post/452532/,https://youtu.be/T66y83lF-xg,https://github.com/smartboxchannel/EFEKTA-EINK-TEMP-HUM-SENSOR-NRF52"
                        },
                        new
                        {
                            Id = 5,
                            Author = "@EfektaSB",
                            Name = "Беспроводной датчик протечки воды на nRF52832, DIY проект",
                            Urls = "https://habr.com/ru/post/460177/,https://youtu.be/xsoeffaGAG0,https://youtu.be/5jZt3NWf9GA,https://github.com/smartboxchannel/EFEKTA_WATER_LEAK_SENSOR"
                        },
                        new
                        {
                            Id = 6,
                            Author = "@EfektaSB",
                            Name = "Мини датчик света и удара | nRF52840",
                            Urls = "https://habr.com/ru/post/478960/,https://youtu.be/I2ywIxp-RsE,https://github.com/smartboxchannel/EFEKTA-LIS2DW12-MAX44009-E73C"
                        },
                        new
                        {
                            Id = 7,
                            Author = "@outwaves",
                            Name = "Модульный синтезатор",
                            Urls = "https://telegra.ph/testovoe-01-26,https://github.com/Outwaves/stm32/tree/master/sequencer"
                        },
                        new
                        {
                            Id = 8,
                            Author = "@hextomato",
                            Name = "Контроллер детского электромотоцикла KEMC1804",
                            Urls = "https://telegra.ph/Kontroller-detskogo-ehlektromotocikla-KEMC1804-03-15,https://yadi.sk/d/NESmi9MeB7s8mg"
                        },
                        new
                        {
                            Id = 9,
                            Author = "@Escaper19",
                            Name = "СИСТЕМА АВТОМАТИЧЕСКОГО РЕГУЛИРОВАНИЯ ТЕМПЕРАТУРЫ ВОЗДУХА В ТЕПЛИЦЕ",
                            Urls = "https://telegra.ph/SISTEMA-AVTOMATICHESKOGO-REGULIROVANIYA-TEMPERATURY-VOZDUHA-V-TEPLICE-03-29,https://github.com/Escaper2/proect"
                        },
                        new
                        {
                            Id = 10,
                            Author = "@Valentyn_Korniienko",
                            Name = "Подготовка к велосипедостроению.",
                            Urls = "https://telegra.ph/Podgotovka-k-velosipedostroeniyu-04-14,https://github.com/ValentiWorkLearning/GradWork"
                        },
                        new
                        {
                            Id = 11,
                            Author = "@tim_kh",
                            Name = "Все этапы создания робота для следования по линии, или как собрать все грабли с STM32",
                            Urls = "https://telegra.ph/Vse-ehtapy-sozdaniya-robota-dlya-sledovaniya-po-linii-ili-kak-sobrat-vse-grabli-s-STM32-04-15"
                        },
                        new
                        {
                            Id = 12,
                            Author = "@Dr_Zlo13",
                            Name = "Hardware User Interface Mockup Kit",
                            Urls = "https://telegra.ph/Hardware-User-Interface-Mockup-Kit-04-15,https://github.com/DrZlo13/huimk"
                        },
                        new
                        {
                            Id = 13,
                            Author = "@numenor",
                            Name = "Заметки о разработке МРРТ контроллера",
                            Urls = "https://habr.com/ru/post/495548/,https://github.com/gardarica/mppt-2420-hardware"
                        },
                        new
                        {
                            Id = 14,
                            Author = "@Velkarn",
                            Name = "Источник питания промышленного контроллера на 100 Вт",
                            Urls = "https://telegra.ph/Istochnik-pitaniya-promyshlennogo-kontrollera-na-100-Vt-04-16"
                        });
                });

            modelBuilder.Entity("TelegramVoteBot.ApiClient.Entities.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ProjectId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TelegramUserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("TelegramVoteBot.ApiClient.Entities.Vote", b =>
                {
                    b.HasOne("TelegramVoteBot.ApiClient.Entities.Project", "Project")
                        .WithMany("Votes")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
