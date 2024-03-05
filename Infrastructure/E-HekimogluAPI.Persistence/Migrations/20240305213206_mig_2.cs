using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_HekimogluAPI.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BagcikKategoris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BagcikKategoris", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KesimKategoris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KesimKategoris", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KoliKategoris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KoliKategoris", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MalzemeRafs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Barkod = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalzemeRafs", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TabanKategoris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabanKategoris", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TutkalKategoris",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TutkalKategoris", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bagciks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Barkod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adı = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    BagcikKategoriId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RenkId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bagciks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bagciks_BagcikKategoris_BagcikKategoriId",
                        column: x => x.BagcikKategoriId,
                        principalTable: "BagcikKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bagciks_Renks_RenkId",
                        column: x => x.RenkId,
                        principalTable: "Renks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Koli",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Barkod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    Fiyat = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Gramaj = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    KoliKategoriId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Koli", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Koli_KoliKategoris_KoliKategoriId",
                        column: x => x.KoliKategoriId,
                        principalTable: "KoliKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "KesimMalzemes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Barkod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Miktar = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    GelisFiyat = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Gramaj = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    KesimKategoriId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    RenkId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    MalzemeRafId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KesimMalzemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KesimMalzemes_KesimKategoris_KesimKategoriId",
                        column: x => x.KesimKategoriId,
                        principalTable: "KesimKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KesimMalzemes_MalzemeRafs_MalzemeRafId",
                        column: x => x.MalzemeRafId,
                        principalTable: "MalzemeRafs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KesimMalzemes_Renks_RenkId",
                        column: x => x.RenkId,
                        principalTable: "Renks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TabanKayıts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Barkod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Miktar = table.Column<int>(type: "int", nullable: false),
                    GelisFiyat = table.Column<int>(type: "int", nullable: false),
                    TabanKategoriId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TabanKayıts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TabanKayıts_TabanKategoris_TabanKategoriId",
                        column: x => x.TabanKategoriId,
                        principalTable: "TabanKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tutkals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Barkod = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ad = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Aciklama = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Adet = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Gramaj = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    fiyat = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TutkalKategoriId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tutkals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tutkals_TutkalKategoris_TutkalKategoriId",
                        column: x => x.TutkalKategoriId,
                        principalTable: "TutkalKategoris",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "RenkTabanKayıt",
                columns: table => new
                {
                    RenksId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    TabanKayıtsId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RenkTabanKayıt", x => new { x.RenksId, x.TabanKayıtsId });
                    table.ForeignKey(
                        name: "FK_RenkTabanKayıt_Renks_RenksId",
                        column: x => x.RenksId,
                        principalTable: "Renks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RenkTabanKayıt_TabanKayıts_TabanKayıtsId",
                        column: x => x.TabanKayıtsId,
                        principalTable: "TabanKayıts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Bagciks_BagcikKategoriId",
                table: "Bagciks",
                column: "BagcikKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Bagciks_Barkod",
                table: "Bagciks",
                column: "Barkod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bagciks_RenkId",
                table: "Bagciks",
                column: "RenkId");

            migrationBuilder.CreateIndex(
                name: "IX_KesimMalzemes_Barkod",
                table: "KesimMalzemes",
                column: "Barkod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KesimMalzemes_KesimKategoriId",
                table: "KesimMalzemes",
                column: "KesimKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_KesimMalzemes_MalzemeRafId",
                table: "KesimMalzemes",
                column: "MalzemeRafId");

            migrationBuilder.CreateIndex(
                name: "IX_KesimMalzemes_RenkId",
                table: "KesimMalzemes",
                column: "RenkId");

            migrationBuilder.CreateIndex(
                name: "IX_Koli_Barkod",
                table: "Koli",
                column: "Barkod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Koli_KoliKategoriId",
                table: "Koli",
                column: "KoliKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_RenkTabanKayıt_TabanKayıtsId",
                table: "RenkTabanKayıt",
                column: "TabanKayıtsId");

            migrationBuilder.CreateIndex(
                name: "IX_TabanKayıts_Barkod",
                table: "TabanKayıts",
                column: "Barkod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TabanKayıts_TabanKategoriId",
                table: "TabanKayıts",
                column: "TabanKategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Tutkals_Barkod",
                table: "Tutkals",
                column: "Barkod",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tutkals_TutkalKategoriId",
                table: "Tutkals",
                column: "TutkalKategoriId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bagciks");

            migrationBuilder.DropTable(
                name: "KesimMalzemes");

            migrationBuilder.DropTable(
                name: "Koli");

            migrationBuilder.DropTable(
                name: "RenkTabanKayıt");

            migrationBuilder.DropTable(
                name: "Tutkals");

            migrationBuilder.DropTable(
                name: "BagcikKategoris");

            migrationBuilder.DropTable(
                name: "KesimKategoris");

            migrationBuilder.DropTable(
                name: "MalzemeRafs");

            migrationBuilder.DropTable(
                name: "KoliKategoris");

            migrationBuilder.DropTable(
                name: "TabanKayıts");

            migrationBuilder.DropTable(
                name: "TutkalKategoris");

            migrationBuilder.DropTable(
                name: "TabanKategoris");
        }
    }
}
