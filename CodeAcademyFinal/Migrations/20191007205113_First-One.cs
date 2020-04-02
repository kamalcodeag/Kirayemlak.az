using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeAcademyFinal.Migrations
{
    public partial class FirstOne : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Advertisements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdvertisementURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CityName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Durations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DurationType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Durations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EstateName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(maxLength: 100, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PhoneNumber = table.Column<string>(nullable: false),
                    Subject = table.Column<string>(maxLength: 100, nullable: false),
                    MessageText = table.Column<string>(maxLength: 2500, nullable: false),
                    SentTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MobileOperators",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MobileOperatorCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MobileOperators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MonthName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoomType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RuleText = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: true),
                    ProfilePictureURL = table.Column<string>(nullable: true),
                    MobileOperatorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_MobileOperators_MobileOperatorId",
                        column: x => x.MobileOperatorId,
                        principalTable: "MobileOperators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<decimal>(nullable: false),
                    AreaForView = table.Column<decimal>(nullable: false),
                    IsVIP = table.Column<bool>(nullable: false),
                    Details = table.Column<string>(maxLength: 2500, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    ViewCount = table.Column<long>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsBan = table.Column<bool>(nullable: false),
                    EstateId = table.Column<int>(nullable: true),
                    RoomId = table.Column<int>(nullable: true),
                    DurationId = table.Column<int>(nullable: true),
                    CityId = table.Column<int>(nullable: true),
                    MonthId = table.Column<int>(nullable: true),
                    CustomUserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Announcements_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_AspNetUsers_CustomUserId",
                        column: x => x.CustomUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_Durations_DurationId",
                        column: x => x.DurationId,
                        principalTable: "Durations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_Estates_EstateId",
                        column: x => x.EstateId,
                        principalTable: "Estates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_Months_MonthId",
                        column: x => x.MonthId,
                        principalTable: "Months",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Announcements_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AnnouncementPhotos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AnnouncementPhotoURL = table.Column<string>(nullable: true),
                    AnnouncementId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnnouncementPhotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnnouncementPhotos_Announcements_AnnouncementId",
                        column: x => x.AnnouncementId,
                        principalTable: "Announcements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Advertisements",
                columns: new[] { "Id", "AdvertisementURL" },
                values: new object[] { 1, "adv.jpg" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CityName" },
                values: new object[,]
                {
                    { 36, "Quba" },
                    { 37, "Qubadlı" },
                    { 38, "Qusar" },
                    { 39, "Laçın" },
                    { 40, "Lerik" },
                    { 41, "Lənkəran" },
                    { 42, "Masallı" },
                    { 43, "Mingəçevir" },
                    { 44, "Naftalan" },
                    { 45, "Neftçala" },
                    { 46, "Oğuz" },
                    { 47, "Saatlı" },
                    { 48, "Sabirabad" },
                    { 49, "Salyan" },
                    { 35, "Qobustan" },
                    { 50, "Samux" },
                    { 53, "Şabran" },
                    { 54, "Şamaxı" },
                    { 55, "Şirvan" },
                    { 56, "Şəki" },
                    { 57, "Şəmkir" },
                    { 58, "Şuşa" },
                    { 59, "Tərtər" },
                    { 60, "Tovuz" },
                    { 61, "Ucar" },
                    { 62, "Yardımlı" },
                    { 63, "Yevlax" },
                    { 64, "Zaqatala" },
                    { 65, "Zəngilan" },
                    { 66, "Zərdab" },
                    { 52, "Sumqayıt" },
                    { 34, "Qəbələ" },
                    { 51, "Siyəzən" },
                    { 32, "Qax" },
                    { 3, "Ağdam" },
                    { 4, "Ağdaş" },
                    { 5, "Ağstafa" },
                    { 6, "Ağsu" },
                    { 7, "Astara" },
                    { 8, "Bakı" },
                    { 9, "Balakən" },
                    { 10, "Beyləqan" },
                    { 11, "Bərdə" },
                    { 12, "Biləsuvar" },
                    { 13, "Cəbrayıl" },
                    { 14, "Cəlilabad" },
                    { 15, "Daşkəsən" },
                    { 33, "Qazax" },
                    { 2, "Ağcabədi" },
                    { 16, "Füzuli" },
                    { 18, "Gəncə" },
                    { 19, "Goranboy" },
                    { 20, "Göyçay" },
                    { 21, "Göygöl" },
                    { 22, "Hacıqabul" },
                    { 23, "Xaçmaz" },
                    { 24, "Xankəndi" },
                    { 25, "Xızı" },
                    { 26, "Xocalı" },
                    { 27, "Xocavənd" },
                    { 28, "İmişli" },
                    { 29, "İsmayıllı" },
                    { 30, "Kəlbəcər" },
                    { 31, "Kürdəmir" },
                    { 17, "Gədəbəy" },
                    { 1, "Abşeron" }
                });

            migrationBuilder.InsertData(
                table: "Durations",
                columns: new[] { "Id", "DurationType" },
                values: new object[,]
                {
                    { 2, "Günlük" },
                    { 1, "Aylıq" }
                });

            migrationBuilder.InsertData(
                table: "Estates",
                columns: new[] { "Id", "EstateName" },
                values: new object[,]
                {
                    { 1, "Mənzil" },
                    { 2, "Ev/Villa" },
                    { 3, "Bağ" },
                    { 4, "Torpaq" },
                    { 5, "Qaraj" },
                    { 6, "Ofis" },
                    { 7, "Obyekt" }
                });

            migrationBuilder.InsertData(
                table: "Messages",
                columns: new[] { "Id", "Email", "FullName", "MessageText", "PhoneNumber", "SentTime", "Subject" },
                values: new object[,]
                {
                    { 1, "mgb@gmail.com", "Mesaj göndərən", "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", "0501234567", new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qeydiyyat problemi" },
                    { 2, "mgb@gmail.com", "Mesaj göndərən", "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", "0501234567", new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qeydiyyat problemi" },
                    { 3, "mgb@gmail.com", "Mesaj göndərən", "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", "0501234567", new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qeydiyyat problemi" },
                    { 4, "mgb@gmail.com", "Mesaj göndərən", "Hər vaxtınız xeyir, mən qeydiyyat zamanı problemlə üzləşirəm. Email'imə təsdiq mesajı gəlmir.", "0501234567", new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Qeydiyyat problemi" }
                });

            migrationBuilder.InsertData(
                table: "MobileOperators",
                columns: new[] { "Id", "MobileOperatorCode" },
                values: new object[,]
                {
                    { 6, "+99477" },
                    { 5, "+99470" },
                    { 4, "+99455" },
                    { 2, "+99450" },
                    { 1, "+99440" },
                    { 3, "+99451" }
                });

            migrationBuilder.InsertData(
                table: "Months",
                columns: new[] { "Id", "MonthName" },
                values: new object[,]
                {
                    { 6, "iyun" },
                    { 1, "yanvar" },
                    { 2, "fevral" },
                    { 3, "mart" },
                    { 4, "aprel" },
                    { 5, "may" },
                    { 7, "iyul" },
                    { 8, "avqust" },
                    { 9, "sentyabr" },
                    { 10, "oktyabr" },
                    { 11, "noyabr" },
                    { 12, "dekabr" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "RoomType" },
                values: new object[,]
                {
                    { 4, "4 otaqlı" },
                    { 3, "3 otaqlı" },
                    { 5, "5+ otaqlı" },
                    { 1, "1 otaqlı" },
                    { 2, "2 otaqlı" }
                });

            migrationBuilder.InsertData(
                table: "Rules",
                columns: new[] { "Id", "RuleText" },
                values: new object[] { 1, "2019-cu ildən fəaliyyət göstərən Kirayemlak.az saytı Azərbaycanda daşınmaz əmlakın kirayəsi üçün nəzərdə tutulmuşdur. Günü-gündən inkişaf edən saytımızın gün ərzində minlərlə istifadəçisi olur. Portal olaraq daim inkişaf etmək əzmindəyik və bu səbəbdəndir ki saytımızın dizaynı, funksionallığı və qayda-qanunları yenilənir. Bu dəyişikliklərin hamısı saytımıza elan verən və saytımızda axtarış edən istifadəçilərin rahatlığı üçündür. Portal olaraq istifadəçilərimizin irad və təkliflərini diqqətlə dinləyir onları qeyd edir və növbəti dəyişikliklərimizdə uyğun gələnlərini tətbiq edirik. Bu da saytımızın dahada istifadəyə yararlı olmasına gətirib çıxardır." });

            migrationBuilder.InsertData(
                table: "Announcements",
                columns: new[] { "Id", "Area", "AreaForView", "CityId", "CustomUserId", "Details", "DurationId", "EstateId", "IsActive", "IsBan", "IsDeleted", "IsVIP", "MonthId", "Price", "PublishDate", "RoomId", "UpdateDate", "ViewCount" },
                values: new object[,]
                {
                    { 15, 3m, 3m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 3, false, false, false, false, 8, 580, new DateTime(2019, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 8, 67m, 67m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 2, 1, true, false, false, true, 7, 70, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 14, 58m, 58m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 2, false, false, false, false, 8, 80, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 7, 65m, 65m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, true, false, false, true, 7, 390, new DateTime(2019, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 6, 40m, 40m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, false, false, false, false, 7, 350, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 5, 70m, 70m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, false, false, false, false, 7, 430, new DateTime(2019, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 4, 59m, 59m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, false, false, false, false, 7, 550, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 279L },
                    { 13, 52m, 52m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 2, true, false, false, true, 8, 70, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 577L },
                    { 12, 40m, 40m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 2, true, false, false, true, 8, 90, new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 3, 60m, 60m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, false, false, false, false, 7, 850, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 979L },
                    { 2, 55m, 55m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, false, false, false, false, 7, 550, new DateTime(2019, 8, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 979L },
                    { 1, 50m, 50m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 1, false, false, false, false, 7, 450, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 770L },
                    { 11, 60m, 60m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 2, true, false, false, true, 7, 100, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 361L },
                    { 28, 135m, 135m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 7, true, false, false, true, 8, 660, new DateTime(2019, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 27, 110m, 110m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 7, true, false, false, true, 8, 300, new DateTime(2019, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 26, 80m, 80m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 2, 6, true, false, false, true, 8, 400, new DateTime(2019, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 379L },
                    { 25, 90m, 90m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 6, true, false, false, true, 8, 500, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 24, 63m, 63m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 5, false, false, false, false, 8, 720, new DateTime(2019, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 23, 51m, 51m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 5, false, false, false, false, 8, 750, new DateTime(2019, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 22, 4m, 4m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 4, true, false, false, true, 8, 850, new DateTime(2019, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 879L },
                    { 21, 3m, 3m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 4, true, false, false, true, 8, 540, new DateTime(2019, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 20, 8m, 8m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 4, true, false, false, true, 8, 490, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 19, 5m, 5m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 4, true, false, false, true, 8, 350, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 18, 6m, 6m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 4, false, false, false, false, 8, 750, new DateTime(2019, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 17, 6m, 6m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 3, false, false, false, false, 8, 600, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 579L },
                    { 16, 4m, 4m, 1, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 1, 3, false, false, false, false, 8, 420, new DateTime(2019, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 479L },
                    { 9, 50m, 50m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 2, 1, true, false, false, true, 7, 80, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 499L },
                    { 10, 60m, 60m, 8, null, "Premium layihəli Renessance Palace yaşayış komleksində Yasamal parkına baxan əla panaramalı, 2 balkonlu podmayak mənzildir. Mənzillərdə təmir işləri aparılır 20 sentyabrdan sakinlərə yaşamağa icazə veriləcək.", 2, 1, true, false, false, true, 7, 30, new DateTime(2019, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 472L }
                });

            migrationBuilder.InsertData(
                table: "AnnouncementPhotos",
                columns: new[] { "Id", "AnnouncementId", "AnnouncementPhotoURL" },
                values: new object[,]
                {
                    { 65, 15, "estate65.jpg" },
                    { 59, 13, "estate59.jpg" },
                    { 58, 13, "estate58.jpg" },
                    { 57, 13, "estate57.jpg" },
                    { 56, 13, "estate56.jpg" },
                    { 55, 12, "estate55.jpg" },
                    { 54, 12, "estate54.jpg" },
                    { 53, 12, "estate53.jpg" },
                    { 52, 12, "estate52.jpg" },
                    { 18, 3, "estate18.jpg" },
                    { 17, 3, "estate17.jpg" },
                    { 16, 3, "estate16.jpg" },
                    { 15, 3, "estate15.jpg" },
                    { 14, 3, "estate14.jpg" },
                    { 13, 3, "estate13.jpg" },
                    { 12, 3, "estate12.jpg" },
                    { 11, 2, "estate11.jpg" },
                    { 10, 2, "estate10.jpg" },
                    { 9, 2, "estate9.jpg" },
                    { 8, 2, "estate8.jpg" },
                    { 7, 1, "estate7.jpg" },
                    { 6, 1, "estate6.jpg" },
                    { 5, 1, "estate5.jpg" },
                    { 4, 1, "estate4.jpg" },
                    { 3, 1, "estate3.jpg" },
                    { 2, 1, "estate2.jpg" },
                    { 1, 1, "estate1.jpg" },
                    { 51, 11, "estate51.jpg" },
                    { 60, 13, "estate60.jpg" },
                    { 50, 11, "estate50.jpg" },
                    { 19, 4, "estate19.jpg" },
                    { 21, 4, "estate21.jpg" },
                    { 44, 10, "estate44.jpg" },
                    { 43, 10, "estate43.jpg" },
                    { 42, 9, "estate42.jpg" },
                    { 41, 9, "estate41.jpg" },
                    { 40, 9, "estate40.jpg" },
                    { 39, 9, "estate39.jpg" },
                    { 38, 8, "estate38.jpg" },
                    { 37, 8, "estate37.jpg" },
                    { 36, 8, "estate36.jpg" },
                    { 35, 8, "estate35.jpg" },
                    { 64, 14, "estate64.jpg" },
                    { 63, 14, "estate63.jpg" },
                    { 62, 14, "estate62.jpg" },
                    { 61, 14, "estate61.jpg" },
                    { 34, 7, "estate34.jpg" },
                    { 33, 7, "estate33.jpg" },
                    { 32, 7, "estate32.jpg" },
                    { 31, 7, "estate31.jpg" },
                    { 30, 6, "estate30.jpg" },
                    { 29, 6, "estate29.jpg" },
                    { 28, 6, "estate28.jpg" },
                    { 27, 6, "estate27.jpg" },
                    { 26, 5, "estate26.jpg" },
                    { 25, 5, "estate25.jpg" },
                    { 24, 5, "estate24.jpg" },
                    { 23, 5, "estate23.jpg" },
                    { 22, 4, "estate22.jpg" },
                    { 20, 4, "estate20.jpg" },
                    { 45, 10, "estate45.jpg" },
                    { 49, 11, "estate49.jpg" },
                    { 47, 11, "estate47.jpg" },
                    { 92, 21, "estate92.jpg" },
                    { 91, 21, "estate91.jpg" },
                    { 90, 21, "estate90.jpg" },
                    { 89, 21, "estate89.jpg" },
                    { 88, 20, "estate88.jpg" },
                    { 87, 20, "estate87.jpg" },
                    { 86, 20, "estate86.jpg" },
                    { 85, 20, "estate85.jpg" },
                    { 84, 19, "estate84.jpg" },
                    { 83, 19, "estate83.jpg" },
                    { 82, 19, "estate82.jpg" },
                    { 81, 19, "estate81.jpg" },
                    { 80, 18, "estate80.jpg" },
                    { 79, 18, "estate79.jpg" },
                    { 78, 18, "estate78.jpg" },
                    { 77, 18, "estate77.jpg" },
                    { 76, 17, "estate76.jpg" },
                    { 75, 17, "estate75.jpg" },
                    { 74, 17, "estate74.jpg" },
                    { 73, 17, "estate73.jpg" },
                    { 72, 16, "estate72.jpg" },
                    { 71, 16, "estate71.jpg" },
                    { 70, 16, "estate70.jpg" },
                    { 69, 16, "estate69.jpg" },
                    { 68, 15, "estate68.jpg" },
                    { 67, 15, "estate67.jpg" },
                    { 66, 15, "estate66.jpg" },
                    { 93, 22, "estate93.jpg" },
                    { 48, 11, "estate48.jpg" },
                    { 94, 22, "estate94.jpg" },
                    { 96, 22, "estate96.jpg" },
                    { 123, 28, "estate123.jpg" },
                    { 122, 28, "estate122.jpg" },
                    { 121, 28, "estate121.jpg" },
                    { 120, 28, "estate120.jpg" },
                    { 119, 28, "estate119.jpg" },
                    { 118, 27, "estate118.jpg" },
                    { 117, 27, "estate117.jpg" },
                    { 116, 27, "estate116.jpg" },
                    { 115, 27, "estate115.jpg" },
                    { 114, 27, "estate114.jpg" },
                    { 113, 27, "estate113.jpg" },
                    { 112, 26, "estate112.jpg" },
                    { 111, 26, "estate111.jpg" },
                    { 110, 26, "estate110.jpg" },
                    { 109, 26, "estate109.jpg" },
                    { 108, 25, "estate108.jpg" },
                    { 107, 25, "estate107.jpg" },
                    { 106, 25, "estate106.jpg" },
                    { 105, 25, "estate105.jpg" },
                    { 104, 24, "estate104.jpg" },
                    { 103, 24, "estate103.jpg" },
                    { 102, 24, "estate102.jpg" },
                    { 101, 24, "estate101.jpg" },
                    { 100, 23, "estate100.jpg" },
                    { 99, 23, "estate99.jpg" },
                    { 98, 23, "estate98.jpg" },
                    { 97, 23, "estate97.jpg" },
                    { 95, 22, "estate95.jpg" },
                    { 46, 10, "estate46.jpg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnnouncementPhotos_AnnouncementId",
                table: "AnnouncementPhotos",
                column: "AnnouncementId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CityId",
                table: "Announcements",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_CustomUserId",
                table: "Announcements",
                column: "CustomUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_DurationId",
                table: "Announcements",
                column: "DurationId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_EstateId",
                table: "Announcements",
                column: "EstateId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_MonthId",
                table: "Announcements",
                column: "MonthId");

            migrationBuilder.CreateIndex(
                name: "IX_Announcements_RoomId",
                table: "Announcements",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_MobileOperatorId",
                table: "AspNetUsers",
                column: "MobileOperatorId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertisements");

            migrationBuilder.DropTable(
                name: "AnnouncementPhotos");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Rules");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Durations");

            migrationBuilder.DropTable(
                name: "Estates");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "MobileOperators");
        }
    }
}
