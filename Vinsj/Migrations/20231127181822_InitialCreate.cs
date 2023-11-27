using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Vinsj.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceOrdres",
                columns: table => new
                {
                    ServiceOrdreID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceOrdres", x => x.ServiceOrdreID);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSkjema",
                columns: table => new
                {
                    ServiceOrdreID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KundeNavn = table.Column<string>(type: "text", nullable: false),
                    KundeAdresse = table.Column<string>(type: "text", nullable: false),
                    KundeEpost = table.Column<string>(type: "text", nullable: false),
                    KundeTelefon = table.Column<int>(type: "integer", nullable: false),
                    ProduktType = table.Column<string>(type: "text", nullable: false),
                    ProduktArsmodell = table.Column<int>(type: "integer", nullable: false),
                    ProduktSerienummer = table.Column<string>(type: "text", nullable: false),
                    ProduktGaranti = table.Column<string>(type: "text", nullable: false),
                    ProduktMottat = table.Column<string>(type: "text", nullable: false),
                    SAvtaltKunde = table.Column<string>(type: "text", nullable: false),
                    SRepBeskrivelse = table.Column<string>(type: "text", nullable: false),
                    SDelerBrukt = table.Column<string>(type: "text", nullable: false),
                    SArbeidsTimer = table.Column<int>(type: "integer", nullable: false),
                    SFerdigDato = table.Column<string>(type: "text", nullable: false),
                    SDelerRetunert = table.Column<string>(type: "text", nullable: false),
                    SForsendelseMate = table.Column<string>(type: "text", nullable: false),
                    SSignKunde = table.Column<string>(type: "text", nullable: false),
                    SSignRep = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSkjema", x => x.ServiceOrdreID);
                });

            migrationBuilder.CreateTable(
                name: "SjekklisteViews",
                columns: table => new
                {
                    ServiceOrdreID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    komponentKomponent = table.Column<string>(type: "text", nullable: true),
                    komponentAvdeling = table.Column<string>(type: "text", nullable: true),
                    komponentKomponent_Status = table.Column<string>(type: "text", nullable: true),
                    funksjonsTestVinsj = table.Column<string>(type: "text", nullable: true),
                    funksjonsTrekkraft = table.Column<float>(type: "real", nullable: false),
                    funksjonsBremsekraft = table.Column<float>(type: "real", nullable: false),
                    trykkBar = table.Column<float>(type: "real", nullable: false),
                    signaturKommentar = table.Column<string>(type: "text", nullable: true),
                    signaturSignatur = table.Column<string>(type: "text", nullable: true),
                    signaturDato = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SjekklisteViews", x => x.ServiceOrdreID);
                });

            migrationBuilder.CreateTable(
                name: "FunksjonsTests",
                columns: table => new
                {
                    ServiceOrdreID_FK = table.Column<int>(type: "integer", nullable: false),
                    TestVinsj = table.Column<string>(type: "text", nullable: true),
                    Trekkraft = table.Column<float>(type: "real", nullable: false),
                    Bremsekraft = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FunksjonsTests", x => x.ServiceOrdreID_FK);
                    table.ForeignKey(
                        name: "FK_FunksjonsTests_ServiceOrdres_ServiceOrdreID_FK",
                        column: x => x.ServiceOrdreID_FK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KomponentServices",
                columns: table => new
                {
                    ServiceOrdreID_FK = table.Column<int>(type: "integer", nullable: false),
                    Komponent = table.Column<string>(type: "text", nullable: false),
                    Avdeling = table.Column<string>(type: "text", nullable: true),
                    Komponent_Status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KomponentServices", x => new { x.ServiceOrdreID_FK, x.Komponent });
                    table.ForeignKey(
                        name: "FK_KomponentServices_ServiceOrdres_ServiceOrdreID_FK",
                        column: x => x.ServiceOrdreID_FK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KundeInformasjons",
                columns: table => new
                {
                    ServiceOrdreIDFK = table.Column<int>(type: "integer", nullable: false),
                    Kunde = table.Column<string>(type: "text", nullable: true),
                    Adresse = table.Column<string>(type: "text", nullable: true),
                    Epost = table.Column<string>(type: "text", nullable: true),
                    Telefon = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KundeInformasjons", x => x.ServiceOrdreIDFK);
                    table.ForeignKey(
                        name: "FK_KundeInformasjons_ServiceOrdres_ServiceOrdreIDFK",
                        column: x => x.ServiceOrdreIDFK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProduktInformasjons",
                columns: table => new
                {
                    ServiceOrdreIDFK = table.Column<int>(type: "integer", nullable: false),
                    ProduktType = table.Column<string>(type: "text", nullable: true),
                    Arsmodell = table.Column<int>(type: "integer", nullable: false),
                    Serienummer = table.Column<string>(type: "text", nullable: true),
                    Garanti = table.Column<string>(type: "text", nullable: true),
                    DatoMottat = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProduktInformasjons", x => x.ServiceOrdreIDFK);
                    table.ForeignKey(
                        name: "FK_ProduktInformasjons_ServiceOrdres_ServiceOrdreIDFK",
                        column: x => x.ServiceOrdreIDFK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServiceSkjemas",
                columns: table => new
                {
                    ServiceOrdreIDFK = table.Column<int>(type: "integer", nullable: false),
                    AvtaltKunde = table.Column<string>(type: "text", nullable: true),
                    RepBeskrivelse = table.Column<string>(type: "text", nullable: true),
                    DelerBrukt = table.Column<string>(type: "text", nullable: true),
                    AbreidsTimer = table.Column<int>(type: "integer", nullable: false),
                    FerdigDato = table.Column<string>(type: "text", nullable: true),
                    DelerRetunert = table.Column<string>(type: "text", nullable: true),
                    ForsendelseMate = table.Column<string>(type: "text", nullable: true),
                    SignKunde = table.Column<string>(type: "text", nullable: true),
                    SignRep = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceSkjemas", x => x.ServiceOrdreIDFK);
                    table.ForeignKey(
                        name: "FK_ServiceSkjemas_ServiceOrdres_ServiceOrdreIDFK",
                        column: x => x.ServiceOrdreIDFK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SignaturerModels",
                columns: table => new
                {
                    ServiceOrdreIDFK = table.Column<int>(type: "integer", nullable: false),
                    Kommentar = table.Column<string>(type: "text", nullable: true),
                    Signatur = table.Column<string>(type: "text", nullable: true),
                    Dato = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SignaturerModels", x => x.ServiceOrdreIDFK);
                    table.ForeignKey(
                        name: "FK_SignaturerModels_ServiceOrdres_ServiceOrdreIDFK",
                        column: x => x.ServiceOrdreIDFK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrykkSettingers",
                columns: table => new
                {
                    ServiceOrdreID_FK = table.Column<int>(type: "integer", nullable: false),
                    Bar = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrykkSettingers", x => x.ServiceOrdreID_FK);
                    table.ForeignKey(
                        name: "FK_TrykkSettingers_ServiceOrdres_ServiceOrdreID_FK",
                        column: x => x.ServiceOrdreID_FK,
                        principalTable: "ServiceOrdres",
                        principalColumn: "ServiceOrdreID",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FunksjonsTests");

            migrationBuilder.DropTable(
                name: "KomponentServices");

            migrationBuilder.DropTable(
                name: "KundeInformasjons");

            migrationBuilder.DropTable(
                name: "ProduktInformasjons");

            migrationBuilder.DropTable(
                name: "ServiceSkjema");

            migrationBuilder.DropTable(
                name: "ServiceSkjemas");

            migrationBuilder.DropTable(
                name: "SignaturerModels");

            migrationBuilder.DropTable(
                name: "SjekklisteViews");

            migrationBuilder.DropTable(
                name: "TrykkSettingers");

            migrationBuilder.DropTable(
                name: "ServiceOrdres");
        }
    }
}
