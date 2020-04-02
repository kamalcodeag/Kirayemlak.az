using CodeAcademyFinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademyFinal.DAL
{
    public class RentEstateDb : IdentityDbContext<CustomUser>
    {
        public RentEstateDb(DbContextOptions<RentEstateDb> options) : base(options)
        {
        }

        public DbSet<Estate> Estates { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Duration> Durations { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<AnnouncementPhoto> AnnouncementPhotos { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Rule> Rules { get; set; }
        public DbSet<Advertisement> Advertisements { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<MobileOperator> MobileOperators { get; set; }
        public DbSet<Month> Months { get; set; }

        //Seeding(recording data into tables manually)
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Estate>().HasData(
                new Estate {Id = 1, EstateName = "Mənzil" },
                new Estate { Id = 2, EstateName = "Ev/Villa" },
                new Estate { Id = 3, EstateName = "Bağ" },
                new Estate { Id = 4, EstateName = "Torpaq" },
                new Estate { Id = 5, EstateName = "Qaraj" },
                new Estate { Id = 6, EstateName = "Ofis" },
                new Estate { Id = 7, EstateName = "Obyekt" }
            );

            builder.Entity<Room>().HasData(
                new Room { Id = 1, RoomType = "1 otaqlı" },
                new Room { Id = 2, RoomType = "2 otaqlı" },
                new Room { Id = 3, RoomType = "3 otaqlı" },
                new Room { Id = 4, RoomType = "4 otaqlı" },
                new Room { Id = 5, RoomType = "5+ otaqlı" }
            );

            builder.Entity<Duration>().HasData(
                new Duration { Id = 1, DurationType = "Aylıq" },
                new Duration { Id = 2, DurationType = "Günlük" }
            );

            builder.Entity<City>().HasData(
                new City { Id = 1, CityName = "Abşeron" },
                new City { Id = 2, CityName = "Ağcabədi" },
                new City { Id = 3, CityName = "Ağdam" },
                new City { Id = 4, CityName = "Ağdaş" },
                new City { Id = 5, CityName = "Ağstafa" },
                new City { Id = 6, CityName = "Ağsu" },
                new City { Id = 7, CityName = "Astara" },
                new City { Id = 8, CityName = "Bakı" },
                new City { Id = 9, CityName = "Balakən" },
                new City { Id = 10, CityName = "Beyləqan" },
                new City { Id = 11, CityName = "Bərdə" },
                new City { Id = 12, CityName = "Biləsuvar" },
                new City { Id = 13, CityName = "Cəbrayıl" },
                new City { Id = 14, CityName = "Cəlilabad" },
                new City { Id = 15, CityName = "Daşkəsən" },
                new City { Id = 16, CityName = "Füzuli" },
                new City { Id = 17, CityName = "Gədəbəy" },
                new City { Id = 18, CityName = "Gəncə" },
                new City { Id = 19, CityName = "Goranboy" },
                new City { Id = 20, CityName = "Göyçay" },
                new City { Id = 21, CityName = "Göygöl" },
                new City { Id = 22, CityName = "Hacıqabul" },
                new City { Id = 23, CityName = "Xaçmaz" },
                new City { Id = 24, CityName = "Xankəndi" },
                new City { Id = 25, CityName = "Xızı" },
                new City { Id = 26, CityName = "Xocalı" },
                new City { Id = 27, CityName = "Xocavənd" },
                new City { Id = 28, CityName = "İmişli" },
                new City { Id = 29, CityName = "İsmayıllı" },
                new City { Id = 30, CityName = "Kəlbəcər" },
                new City { Id = 31, CityName = "Kürdəmir" },
                new City { Id = 32, CityName = "Qax" },
                new City { Id = 33, CityName = "Qazax" },
                new City { Id = 34, CityName = "Qəbələ" },
                new City { Id = 35, CityName = "Qobustan" },
                new City { Id = 36, CityName = "Quba" },
                new City { Id = 37, CityName = "Qubadlı" },
                new City { Id = 38, CityName = "Qusar" },
                new City { Id = 39, CityName = "Laçın" },
                new City { Id = 40, CityName = "Lerik" },
                new City { Id = 41, CityName = "Lənkəran" },
                new City { Id = 42, CityName = "Masallı" },
                new City { Id = 43, CityName = "Mingəçevir" },
                new City { Id = 44, CityName = "Naftalan" },
                new City { Id = 45, CityName = "Neftçala" },
                new City { Id = 46, CityName = "Oğuz" },
                new City { Id = 47, CityName = "Saatlı" },
                new City { Id = 48, CityName = "Sabirabad" },
                new City { Id = 49, CityName = "Salyan" },
                new City { Id = 50, CityName = "Samux" },
                new City { Id = 51, CityName = "Siyəzən" },
                new City { Id = 52, CityName = "Sumqayıt" },
                new City { Id = 53, CityName = "Şabran" },
                new City { Id = 54, CityName = "Şamaxı" },
                new City { Id = 55, CityName = "Şirvan" },
                new City { Id = 56, CityName = "Şəki" },
                new City { Id = 57, CityName = "Şəmkir" },
                new City { Id = 58, CityName = "Şuşa" },
                new City { Id = 59, CityName = "Tərtər" },
                new City { Id = 60, CityName = "Tovuz" },
                new City { Id = 61, CityName = "Ucar" },
                new City { Id = 62, CityName = "Yardımlı" },
                new City { Id = 63, CityName = "Yevlax" },
                new City { Id = 64, CityName = "Zaqatala" },
                new City { Id = 65, CityName = "Zəngilan" },
                new City { Id = 66, CityName = "Zərdab" }
            );

            builder.Entity<AnnouncementPhoto>().HasData(
                new AnnouncementPhoto { Id = 1, AnnouncementPhotoURL = "estate1.jpg", AnnouncementId = 1},
                new AnnouncementPhoto { Id = 2, AnnouncementPhotoURL = "estate2.jpg", AnnouncementId = 1 },
                new AnnouncementPhoto { Id = 3, AnnouncementPhotoURL = "estate3.jpg", AnnouncementId = 1 },
                new AnnouncementPhoto { Id = 4, AnnouncementPhotoURL = "estate4.jpg", AnnouncementId = 1 },
                new AnnouncementPhoto { Id = 5, AnnouncementPhotoURL = "estate5.jpg", AnnouncementId = 1 },
                new AnnouncementPhoto { Id = 6, AnnouncementPhotoURL = "estate6.jpg", AnnouncementId = 1 },
                new AnnouncementPhoto { Id = 7, AnnouncementPhotoURL = "estate7.jpg", AnnouncementId = 1 },
                new AnnouncementPhoto { Id = 8, AnnouncementPhotoURL = "estate8.jpg", AnnouncementId = 2 },
                new AnnouncementPhoto { Id = 9, AnnouncementPhotoURL = "estate9.jpg", AnnouncementId = 2 },
                new AnnouncementPhoto { Id = 10, AnnouncementPhotoURL = "estate10.jpg", AnnouncementId = 2 },
                new AnnouncementPhoto { Id = 11, AnnouncementPhotoURL = "estate11.jpg", AnnouncementId = 2 },
                new AnnouncementPhoto { Id = 12, AnnouncementPhotoURL = "estate12.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 13, AnnouncementPhotoURL = "estate13.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 14, AnnouncementPhotoURL = "estate14.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 15, AnnouncementPhotoURL = "estate15.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 16, AnnouncementPhotoURL = "estate16.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 17, AnnouncementPhotoURL = "estate17.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 18, AnnouncementPhotoURL = "estate18.jpg", AnnouncementId = 3 },
                new AnnouncementPhoto { Id = 19, AnnouncementPhotoURL = "estate19.jpg", AnnouncementId = 4 },
                new AnnouncementPhoto { Id = 20, AnnouncementPhotoURL = "estate20.jpg", AnnouncementId = 4 },
                new AnnouncementPhoto { Id = 21, AnnouncementPhotoURL = "estate21.jpg", AnnouncementId = 4 },
                new AnnouncementPhoto { Id = 22, AnnouncementPhotoURL = "estate22.jpg", AnnouncementId = 4 },
                new AnnouncementPhoto { Id = 23, AnnouncementPhotoURL = "estate23.jpg", AnnouncementId = 5 },
                new AnnouncementPhoto { Id = 24, AnnouncementPhotoURL = "estate24.jpg", AnnouncementId = 5 },
                new AnnouncementPhoto { Id = 25, AnnouncementPhotoURL = "estate25.jpg", AnnouncementId = 5 },
                new AnnouncementPhoto { Id = 26, AnnouncementPhotoURL = "estate26.jpg", AnnouncementId = 5 },
                new AnnouncementPhoto { Id = 27, AnnouncementPhotoURL = "estate27.jpg", AnnouncementId = 6 },
                new AnnouncementPhoto { Id = 28, AnnouncementPhotoURL = "estate28.jpg", AnnouncementId = 6 },
                new AnnouncementPhoto { Id = 29, AnnouncementPhotoURL = "estate29.jpg", AnnouncementId = 6 },
                new AnnouncementPhoto { Id = 30, AnnouncementPhotoURL = "estate30.jpg", AnnouncementId = 6 },
                new AnnouncementPhoto { Id = 31, AnnouncementPhotoURL = "estate31.jpg", AnnouncementId = 7 },
                new AnnouncementPhoto { Id = 32, AnnouncementPhotoURL = "estate32.jpg", AnnouncementId = 7 },
                new AnnouncementPhoto { Id = 33, AnnouncementPhotoURL = "estate33.jpg", AnnouncementId = 7 },
                new AnnouncementPhoto { Id = 34, AnnouncementPhotoURL = "estate34.jpg", AnnouncementId = 7 },
                new AnnouncementPhoto { Id = 35, AnnouncementPhotoURL = "estate35.jpg", AnnouncementId = 8 },
                new AnnouncementPhoto { Id = 36, AnnouncementPhotoURL = "estate36.jpg", AnnouncementId = 8 },
                new AnnouncementPhoto { Id = 37, AnnouncementPhotoURL = "estate37.jpg", AnnouncementId = 8 },
                new AnnouncementPhoto { Id = 38, AnnouncementPhotoURL = "estate38.jpg", AnnouncementId = 8 },
                new AnnouncementPhoto { Id = 39, AnnouncementPhotoURL = "estate39.jpg", AnnouncementId = 9 },
                new AnnouncementPhoto { Id = 40, AnnouncementPhotoURL = "estate40.jpg", AnnouncementId = 9 },
                new AnnouncementPhoto { Id = 41, AnnouncementPhotoURL = "estate41.jpg", AnnouncementId = 9 },
                new AnnouncementPhoto { Id = 42, AnnouncementPhotoURL = "estate42.jpg", AnnouncementId = 9 },
                new AnnouncementPhoto { Id = 43, AnnouncementPhotoURL = "estate43.jpg", AnnouncementId = 10 },
                new AnnouncementPhoto { Id = 44, AnnouncementPhotoURL = "estate44.jpg", AnnouncementId = 10 },
                new AnnouncementPhoto { Id = 45, AnnouncementPhotoURL = "estate45.jpg", AnnouncementId = 10 },
                new AnnouncementPhoto { Id = 46, AnnouncementPhotoURL = "estate46.jpg", AnnouncementId = 10 },
                new AnnouncementPhoto { Id = 47, AnnouncementPhotoURL = "estate47.jpg", AnnouncementId = 11 },
                new AnnouncementPhoto { Id = 48, AnnouncementPhotoURL = "estate48.jpg", AnnouncementId = 11 },
                new AnnouncementPhoto { Id = 49, AnnouncementPhotoURL = "estate49.jpg", AnnouncementId = 11 },
                new AnnouncementPhoto { Id = 50, AnnouncementPhotoURL = "estate50.jpg", AnnouncementId = 11 },
                new AnnouncementPhoto { Id = 51, AnnouncementPhotoURL = "estate51.jpg", AnnouncementId = 11 },
                new AnnouncementPhoto { Id = 52, AnnouncementPhotoURL = "estate52.jpg", AnnouncementId = 12 },
                new AnnouncementPhoto { Id = 53, AnnouncementPhotoURL = "estate53.jpg", AnnouncementId = 12 },
                new AnnouncementPhoto { Id = 54, AnnouncementPhotoURL = "estate54.jpg", AnnouncementId = 12 },
                new AnnouncementPhoto { Id = 55, AnnouncementPhotoURL = "estate55.jpg", AnnouncementId = 12 },
                new AnnouncementPhoto { Id = 56, AnnouncementPhotoURL = "estate56.jpg", AnnouncementId = 13 },
                new AnnouncementPhoto { Id = 57, AnnouncementPhotoURL = "estate57.jpg", AnnouncementId = 13 },
                new AnnouncementPhoto { Id = 58, AnnouncementPhotoURL = "estate58.jpg", AnnouncementId = 13 },
                new AnnouncementPhoto { Id = 59, AnnouncementPhotoURL = "estate59.jpg", AnnouncementId = 13 },
                new AnnouncementPhoto { Id = 60, AnnouncementPhotoURL = "estate60.jpg", AnnouncementId = 13 },
                new AnnouncementPhoto { Id = 61, AnnouncementPhotoURL = "estate61.jpg", AnnouncementId = 14 },
                new AnnouncementPhoto { Id = 62, AnnouncementPhotoURL = "estate62.jpg", AnnouncementId = 14 },
                new AnnouncementPhoto { Id = 63, AnnouncementPhotoURL = "estate63.jpg", AnnouncementId = 14 },
                new AnnouncementPhoto { Id = 64, AnnouncementPhotoURL = "estate64.jpg", AnnouncementId = 14 },
                new AnnouncementPhoto { Id = 65, AnnouncementPhotoURL = "estate65.jpg", AnnouncementId = 15 },
                new AnnouncementPhoto { Id = 66, AnnouncementPhotoURL = "estate66.jpg", AnnouncementId = 15 },
                new AnnouncementPhoto { Id = 67, AnnouncementPhotoURL = "estate67.jpg", AnnouncementId = 15 },
                new AnnouncementPhoto { Id = 68, AnnouncementPhotoURL = "estate68.jpg", AnnouncementId = 15 },
                new AnnouncementPhoto { Id = 69, AnnouncementPhotoURL = "estate69.jpg", AnnouncementId = 16 },
                new AnnouncementPhoto { Id = 70, AnnouncementPhotoURL = "estate70.jpg", AnnouncementId = 16 },
                new AnnouncementPhoto { Id = 71, AnnouncementPhotoURL = "estate71.jpg", AnnouncementId = 16 },
                new AnnouncementPhoto { Id = 72, AnnouncementPhotoURL = "estate72.jpg", AnnouncementId = 16 },
                new AnnouncementPhoto { Id = 73, AnnouncementPhotoURL = "estate73.jpg", AnnouncementId = 17 },
                new AnnouncementPhoto { Id = 74, AnnouncementPhotoURL = "estate74.jpg", AnnouncementId = 17 },
                new AnnouncementPhoto { Id = 75, AnnouncementPhotoURL = "estate75.jpg", AnnouncementId = 17 },
                new AnnouncementPhoto { Id = 76, AnnouncementPhotoURL = "estate76.jpg", AnnouncementId = 17 },
                new AnnouncementPhoto { Id = 77, AnnouncementPhotoURL = "estate77.jpg", AnnouncementId = 18 },
                new AnnouncementPhoto { Id = 78, AnnouncementPhotoURL = "estate78.jpg", AnnouncementId = 18 },
                new AnnouncementPhoto { Id = 79, AnnouncementPhotoURL = "estate79.jpg", AnnouncementId = 18 },
                new AnnouncementPhoto { Id = 80, AnnouncementPhotoURL = "estate80.jpg", AnnouncementId = 18 },
                new AnnouncementPhoto { Id = 81, AnnouncementPhotoURL = "estate81.jpg", AnnouncementId = 19 },
                new AnnouncementPhoto { Id = 82, AnnouncementPhotoURL = "estate82.jpg", AnnouncementId = 19 },
                new AnnouncementPhoto { Id = 83, AnnouncementPhotoURL = "estate83.jpg", AnnouncementId = 19 },
                new AnnouncementPhoto { Id = 84, AnnouncementPhotoURL = "estate84.jpg", AnnouncementId = 19 },
                new AnnouncementPhoto { Id = 85, AnnouncementPhotoURL = "estate85.jpg", AnnouncementId = 20 },
                new AnnouncementPhoto { Id = 86, AnnouncementPhotoURL = "estate86.jpg", AnnouncementId = 20 },
                new AnnouncementPhoto { Id = 87, AnnouncementPhotoURL = "estate87.jpg", AnnouncementId = 20 },
                new AnnouncementPhoto { Id = 88, AnnouncementPhotoURL = "estate88.jpg", AnnouncementId = 20 },
                new AnnouncementPhoto { Id = 89, AnnouncementPhotoURL = "estate89.jpg", AnnouncementId = 21 },
                new AnnouncementPhoto { Id = 90, AnnouncementPhotoURL = "estate90.jpg", AnnouncementId = 21 },
                new AnnouncementPhoto { Id = 91, AnnouncementPhotoURL = "estate91.jpg", AnnouncementId = 21 },
                new AnnouncementPhoto { Id = 92, AnnouncementPhotoURL = "estate92.jpg", AnnouncementId = 21 },
                new AnnouncementPhoto { Id = 93, AnnouncementPhotoURL = "estate93.jpg", AnnouncementId = 22 },
                new AnnouncementPhoto { Id = 94, AnnouncementPhotoURL = "estate94.jpg", AnnouncementId = 22 },
                new AnnouncementPhoto { Id = 95, AnnouncementPhotoURL = "estate95.jpg", AnnouncementId = 22 },
                new AnnouncementPhoto { Id = 96, AnnouncementPhotoURL = "estate96.jpg", AnnouncementId = 22 },
                new AnnouncementPhoto { Id = 97, AnnouncementPhotoURL = "estate97.jpg", AnnouncementId = 23 },
                new AnnouncementPhoto { Id = 98, AnnouncementPhotoURL = "estate98.jpg", AnnouncementId = 23 },
                new AnnouncementPhoto { Id = 99, AnnouncementPhotoURL = "estate99.jpg", AnnouncementId = 23 },
                new AnnouncementPhoto { Id = 100, AnnouncementPhotoURL = "estate100.jpg", AnnouncementId = 23 },
                new AnnouncementPhoto { Id = 101, AnnouncementPhotoURL = "estate101.jpg", AnnouncementId = 24 },
                new AnnouncementPhoto { Id = 102, AnnouncementPhotoURL = "estate102.jpg", AnnouncementId = 24 },
                new AnnouncementPhoto { Id = 103, AnnouncementPhotoURL = "estate103.jpg", AnnouncementId = 24 },
                new AnnouncementPhoto { Id = 104, AnnouncementPhotoURL = "estate104.jpg", AnnouncementId = 24 },
                new AnnouncementPhoto { Id = 105, AnnouncementPhotoURL = "estate105.jpg", AnnouncementId = 25 },
                new AnnouncementPhoto { Id = 106, AnnouncementPhotoURL = "estate106.jpg", AnnouncementId = 25 },
                new AnnouncementPhoto { Id = 107, AnnouncementPhotoURL = "estate107.jpg", AnnouncementId = 25 },
                new AnnouncementPhoto { Id = 108, AnnouncementPhotoURL = "estate108.jpg", AnnouncementId = 25 },
                new AnnouncementPhoto { Id = 109, AnnouncementPhotoURL = "estate109.jpg", AnnouncementId = 26 },
                new AnnouncementPhoto { Id = 110, AnnouncementPhotoURL = "estate110.jpg", AnnouncementId = 26 },
                new AnnouncementPhoto { Id = 111, AnnouncementPhotoURL = "estate111.jpg", AnnouncementId = 26 },
                new AnnouncementPhoto { Id = 112, AnnouncementPhotoURL = "estate112.jpg", AnnouncementId = 26 },
                new AnnouncementPhoto { Id = 113, AnnouncementPhotoURL = "estate113.jpg", AnnouncementId = 27 },
                new AnnouncementPhoto { Id = 114, AnnouncementPhotoURL = "estate114.jpg", AnnouncementId = 27 },
                new AnnouncementPhoto { Id = 115, AnnouncementPhotoURL = "estate115.jpg", AnnouncementId = 27 },
                new AnnouncementPhoto { Id = 116, AnnouncementPhotoURL = "estate116.jpg", AnnouncementId = 27 },
                new AnnouncementPhoto { Id = 117, AnnouncementPhotoURL = "estate117.jpg", AnnouncementId = 27 },
                new AnnouncementPhoto { Id = 118, AnnouncementPhotoURL = "estate118.jpg", AnnouncementId = 27 },
                new AnnouncementPhoto { Id = 119, AnnouncementPhotoURL = "estate119.jpg", AnnouncementId = 28 },
                new AnnouncementPhoto { Id = 120, AnnouncementPhotoURL = "estate120.jpg", AnnouncementId = 28 },
                new AnnouncementPhoto { Id = 121, AnnouncementPhotoURL = "estate121.jpg", AnnouncementId = 28 },
                new AnnouncementPhoto { Id = 122, AnnouncementPhotoURL = "estate122.jpg", AnnouncementId = 28 },
                new AnnouncementPhoto { Id = 123, AnnouncementPhotoURL = "estate123.jpg", AnnouncementId = 28 }
            );

            builder.Entity<Month>().HasData(
                new Month { Id = 1, MonthName = "yanvar" },
                new Month { Id = 2, MonthName = "fevral" },
                new Month { Id = 3, MonthName = "mart" },
                new Month { Id = 4, MonthName = "aprel" },
                new Month { Id = 5, MonthName = "may" },
                new Month { Id = 6, MonthName = "iyun" },
                new Month { Id = 7, MonthName = "iyul" },
                new Month { Id = 8, MonthName = "avqust" },
                new Month { Id = 9, MonthName = "sentyabr" },
                new Month { Id = 10, MonthName = "oktyabr" },
                new Month { Id = 11, MonthName = "noyabr" },
                new Month { Id = 12, MonthName = "dekabr" }
            );

            builder.Entity<Announcement>().HasData(
                new Announcement { Id = 1, EstateId = 1, RoomId = 2, DurationId = 1, CityId = 1, Area = 50, AreaForView = 50, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 450, ViewCount = 770, PublishDate = new DateTime(2019,08,26), MonthId = 7, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 2, EstateId = 1, RoomId = 2, DurationId = 1, CityId = 1, Area = 55, AreaForView = 55, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 550, ViewCount = 979, PublishDate = new DateTime(2019, 08, 27), MonthId = 7, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 3, EstateId = 1, RoomId = 2, DurationId = 1, CityId = 1, Area = 60, AreaForView = 60, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 850, ViewCount = 979, PublishDate = new DateTime(2019, 08, 27), MonthId = 7, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 4, EstateId = 1, RoomId = 3, DurationId = 1, CityId = 1, Area = 59, AreaForView = 59, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 550, ViewCount = 279, PublishDate = new DateTime(2019, 08, 27), MonthId = 7, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 5, EstateId = 1, RoomId = 3, DurationId = 1, CityId = 1, Area = 70, AreaForView = 70, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 430, ViewCount = 479, PublishDate = new DateTime(2019, 08, 28), MonthId = 7, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 6, EstateId = 1, RoomId = 3, DurationId = 1, CityId = 8, Area = 40, AreaForView = 40, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 350, ViewCount = 479, PublishDate = new DateTime(2019, 08, 28), MonthId = 7, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 7, EstateId = 1, RoomId = 3, DurationId = 1, CityId = 8, Area = 65, AreaForView = 65, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 390, ViewCount = 479, PublishDate = new DateTime(2019, 08, 29), MonthId = 7, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 8, EstateId = 1, RoomId = 4, DurationId = 2, CityId = 8, Area = 67, AreaForView = 67, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 70, ViewCount = 479, PublishDate = new DateTime(2019, 08, 29), MonthId = 7, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 9, EstateId = 1, RoomId = 4, DurationId = 2, CityId = 8, Area = 50, AreaForView = 50, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 80, ViewCount = 499, PublishDate = new DateTime(2019, 08, 30), MonthId = 7, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 10, EstateId = 1, RoomId = 5, DurationId = 2, CityId = 8, Area = 60, AreaForView = 60, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 30, ViewCount = 472, PublishDate = new DateTime(2019, 08, 31), MonthId = 7, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 11, EstateId = 2, RoomId = 1, DurationId = 1, CityId = 8, Area = 60, AreaForView = 60, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 100, ViewCount = 361, PublishDate = new DateTime(2019, 08, 31), MonthId = 7, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 12, EstateId = 2, RoomId = 2, DurationId = 1, CityId = 8, Area = 40, AreaForView = 40, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 90, ViewCount = 479, PublishDate = new DateTime(2019, 09, 01), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 13, EstateId = 2, RoomId = 2, DurationId = 1, CityId = 8, Area = 52, AreaForView = 52, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 70, ViewCount = 577, PublishDate = new DateTime(2019, 09, 01), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 14, EstateId = 2, RoomId = 3, DurationId = 1, CityId = 8, Area = 58, AreaForView = 58, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 80, ViewCount = 479, PublishDate = new DateTime(2019, 09, 01), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 15, EstateId = 3, RoomId = null, DurationId = 1, CityId = 1, Area = 3, AreaForView = 3, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 580, ViewCount = 479, PublishDate = new DateTime(2019, 09, 02), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 16, EstateId = 3, RoomId = null, DurationId = 1, CityId = 1, Area = 4, AreaForView = 4, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 420, ViewCount = 479, PublishDate = new DateTime(2019, 09, 03), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 17, EstateId = 3, RoomId = null, DurationId = 1, CityId = 1, Area = 6, AreaForView = 6, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 600, ViewCount = 579, PublishDate = new DateTime(2019, 09, 03), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 18, EstateId = 4, RoomId = null, DurationId = 1, CityId = 1, Area = 6, AreaForView = 6, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 750, ViewCount = 479, PublishDate = new DateTime(2019, 09, 04), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 19, EstateId = 4, RoomId = null, DurationId = 1, CityId = 1, Area = 5, AreaForView = 5, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 350, ViewCount = 479, PublishDate = new DateTime(2019, 09, 04), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 20, EstateId = 4, RoomId = null, DurationId = 1, CityId = 1, Area = 8, AreaForView = 8, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 490, ViewCount = 479, PublishDate = new DateTime(2019, 09, 05), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 21, EstateId = 4, RoomId = null, DurationId = 1, CityId = 1, Area = 3, AreaForView = 3, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 540, ViewCount = 479, PublishDate = new DateTime(2019, 09, 06), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 22, EstateId = 4, RoomId = null, DurationId = 1, CityId = 1, Area = 4, AreaForView = 4, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 850, ViewCount = 879, PublishDate = new DateTime(2019, 09, 07), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 23, EstateId = 5, RoomId = null, DurationId = 1, CityId = 8, Area = 51, AreaForView = 51, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 750, ViewCount = 479, PublishDate = new DateTime(2019, 09, 08), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 24, EstateId = 5, RoomId = null, DurationId = 1, CityId = 8, Area = 63, AreaForView = 63, IsVIP = false, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 720, ViewCount = 479, PublishDate = new DateTime(2019, 09, 09), MonthId = 8, IsActive = false, IsDeleted = false, IsBan = false },
                new Announcement { Id = 25, EstateId = 6, RoomId = null, DurationId = 1, CityId = 8, Area = 90, AreaForView = 90, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 500, ViewCount = 479, PublishDate = new DateTime(2019, 09, 10), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 26, EstateId = 6, RoomId = null, DurationId = 2, CityId = 8, Area = 80, AreaForView = 80, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 400, ViewCount = 379, PublishDate = new DateTime(2019, 09, 11), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 27, EstateId = 7, RoomId = null, DurationId = 1, CityId = 8, Area = 110, AreaForView = 110, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 300, ViewCount = 479, PublishDate = new DateTime(2019, 09, 12), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false },
                new Announcement { Id = 28, EstateId = 7, RoomId = null, DurationId = 1, CityId = 8, Area = 135, AreaForView = 135, IsVIP = true, Details = "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", Price = 660, ViewCount = 479, PublishDate = new DateTime(2019, 09, 13), MonthId = 8, IsActive = true, IsDeleted = false, IsBan = false }
            );

            builder.Entity<Rule>().HasData(
                new Rule { Id = 1, RuleText = "2019-cu ildən fəaliyyət göstərən Kirayemlak.az saytı Azərbaycanda daşınmaz əmlakın kirayəsi üçün nəzərdə tutulmuşdur. Günü-gündən inkişaf edən saytımızın gün ərzində minlərlə istifadəçisi olur. Portal olaraq daim inkişaf etmək əzmindəyik və bu səbəbdəndir ki saytımızın dizaynı, funksionallığı və qayda-qanunları yenilənir. Bu dəyişikliklərin hamısı saytımıza elan verən və saytımızda axtarış edən istifadəçilərin rahatlığı üçündür. Portal olaraq istifadəçilərimizin irad və təkliflərini diqqətlə dinləyir onları qeyd edir və növbəti dəyişikliklərimizdə uyğun gələnlərini tətbiq edirik. Bu da saytımızın dahada istifadəyə yararlı olmasına gətirib çıxardır." }
            );

            builder.Entity<Advertisement>().HasData(
                new Advertisement { Id = 1, AdvertisementURL = "adv.jpg" }
            );

            builder.Entity<Message>().HasData(
                new Message { Id = 1, FullName = "Mesaj göndərən", Email = "mgb@gmail.com", PhoneNumber = "0501234567", Subject = "Qeydiyyat problemi", MessageText = "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", SentTime = new DateTime(2019,09,07) },
                new Message { Id = 2, FullName = "Mesaj göndərən", Email = "mgb@gmail.com", PhoneNumber = "0501234567", Subject = "Qeydiyyat problemi", MessageText = "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", SentTime = new DateTime(2019, 09, 09) },
                new Message { Id = 3, FullName = "Mesaj göndərən", Email = "mgb@gmail.com", PhoneNumber = "0501234567", Subject = "Qeydiyyat problemi", MessageText = "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", SentTime = new DateTime(2019, 09, 10) },
                new Message { Id = 4, FullName = "Mesaj göndərən", Email = "mgb@gmail.com", PhoneNumber = "0501234567", Subject = "Qeydiyyat problemi", MessageText = "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", SentTime = new DateTime(2019, 09, 11) }
            );

            builder.Entity<MobileOperator>().HasData(
                new MobileOperator { Id = 1, MobileOperatorCode = "+99440" },
                new MobileOperator { Id = 2, MobileOperatorCode = "+99450" },
                new MobileOperator { Id = 3, MobileOperatorCode = "+99451" },
                new MobileOperator { Id = 4, MobileOperatorCode = "+99455" },
                new MobileOperator { Id = 5, MobileOperatorCode = "+99470" },
                new MobileOperator { Id = 6, MobileOperatorCode = "+99477" }
            );
        }

        //Using Lazy Loading
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies()
                          .ConfigureWarnings(warnings => warnings.Ignore(CoreEventId.DetachedLazyLoadingWarning));
        }
    }
}
