using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace InciOneSoft.DAL.Migrations
{
    public partial class Initial_Setup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FileInfo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Export = table.Column<string>(maxLength: 100, nullable: true),
                    Version = table.Column<string>(maxLength: 100, nullable: true),
                    FactureNonSoldees = table.Column<string>(maxLength: 100, nullable: true),
                    FileDateHour = table.Column<DateTime>(nullable: false),
                    UploadedDate = table.Column<DateTime>(nullable: false),
                    UploadedByUserName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    Address = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(maxLength: 128, nullable: false),
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
                    LoginProvider = table.Column<string>(maxLength: 128, nullable: false),
                    Name = table.Column<string>(maxLength: 128, nullable: false),
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
                name: "FileData",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FileInfoId = table.Column<int>(nullable: false),
                    FileInfoId1 = table.Column<Guid>(nullable: true),
                    ClientPayeur = table.Column<string>(nullable: true),
                    CodeClient = table.Column<int>(nullable: false),
                    CodeTiers = table.Column<int>(nullable: false),
                    NumeroV1 = table.Column<int>(nullable: false),
                    DateFacture = table.Column<DateTime>(nullable: false),
                    DateEcheance = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: true),
                    Activite = table.Column<string>(nullable: true),
                    ModeReglement = table.Column<string>(nullable: true),
                    TTC = table.Column<double>(nullable: false),
                    MontantDu = table.Column<double>(nullable: false),
                    Teletransmissable = table.Column<bool>(nullable: false),
                    DuRo = table.Column<double>(nullable: false),
                    PartRo = table.Column<double>(nullable: false),
                    EtatT1 = table.Column<string>(nullable: true),
                    DuRc = table.Column<double>(nullable: false),
                    PartRc = table.Column<double>(nullable: false),
                    EtatT2 = table.Column<string>(nullable: true),
                    DuClient = table.Column<double>(nullable: false),
                    PartClient = table.Column<double>(nullable: false),
                    Ets = table.Column<string>(nullable: true),
                    ClientLivre = table.Column<string>(nullable: true),
                    AgentCommercial = table.Column<string>(nullable: true),
                    DebutLoc1 = table.Column<DateTime>(nullable: false),
                    FinLoc1 = table.Column<DateTime>(nullable: false),
                    OrgAmo = table.Column<string>(nullable: true),
                    OrgAmc = table.Column<string>(nullable: true),
                    PremiereRelanceClient = table.Column<DateTime>(nullable: false),
                    DeuxiemeRelanceClient = table.Column<DateTime>(nullable: false),
                    TroisiemeRelanceClient = table.Column<DateTime>(nullable: false),
                    PremiereRelanceAmo = table.Column<DateTime>(nullable: false),
                    DeuxiemeRelanceAmo = table.Column<DateTime>(nullable: false),
                    TroisiemeRelanceAmo = table.Column<DateTime>(nullable: false),
                    PremiereRelanceAmc = table.Column<DateTime>(nullable: false),
                    DeuxiemeRelanceAmc = table.Column<DateTime>(nullable: false),
                    TroisiemeRelanceAmc = table.Column<DateTime>(nullable: false),
                    MontantRegle = table.Column<double>(nullable: false),
                    DateReglemet = table.Column<DateTime>(nullable: false),
                    DelaiReglemet = table.Column<int>(nullable: false),
                    DepasseEcheance = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileData_FileInfo_FileInfoId1",
                        column: x => x.FileInfoId1,
                        principalTable: "FileInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { new Guid("fa110e69-3bb9-4f6b-a2aa-36ac8c47f76b"), null, "Sassine", "Abou-Jaoude" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { new Guid("0947949a-e893-4e4b-809c-a61cfa656942"), null, "Anthony", "Khalife" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Address", "FirstName", "LastName" },
                values: new object[] { new Guid("4eaedede-bdf1-4c8e-ada3-9b8092370bb0"), null, "Marc", "Abou Rjeili" });

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
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FileData_FileInfoId1",
                table: "FileData",
                column: "FileInfoId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "FileData");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "FileInfo");
        }
    }
}
