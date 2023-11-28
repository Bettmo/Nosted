using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Vinsj.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServiceSkjema");

            migrationBuilder.DropTable(
                name: "SjekklisteViews");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServiceSkjema",
                columns: table => new
                {
                    ServiceOrdreID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    KundeAdresse = table.Column<string>(type: "text", nullable: false),
                    KundeEpost = table.Column<string>(type: "text", nullable: false),
                    KundeNavn = table.Column<string>(type: "text", nullable: false),
                    KundeTelefon = table.Column<int>(type: "integer", nullable: false),
                    ProduktArsmodell = table.Column<int>(type: "integer", nullable: false),
                    ProduktGaranti = table.Column<string>(type: "text", nullable: false),
                    ProduktMottat = table.Column<string>(type: "text", nullable: false),
                    ProduktSerienummer = table.Column<string>(type: "text", nullable: false),
                    ProduktType = table.Column<string>(type: "text", nullable: false),
                    SArbeidsTimer = table.Column<int>(type: "integer", nullable: false),
                    SAvtaltKunde = table.Column<string>(type: "text", nullable: false),
                    SDelerBrukt = table.Column<string>(type: "text", nullable: false),
                    SDelerRetunert = table.Column<string>(type: "text", nullable: false),
                    SFerdigDato = table.Column<string>(type: "text", nullable: false),
                    SForsendelseMate = table.Column<string>(type: "text", nullable: false),
                    SRepBeskrivelse = table.Column<string>(type: "text", nullable: false),
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
                    funksjonsBremsekraft = table.Column<float>(type: "real", nullable: false),
                    funksjonsTestVinsj = table.Column<string>(type: "text", nullable: true),
                    funksjonsTrekkraft = table.Column<float>(type: "real", nullable: false),
                    komponentAvdeling = table.Column<string>(type: "text", nullable: true),
                    komponentKomponent = table.Column<string>(type: "text", nullable: true),
                    komponentKomponent_Status = table.Column<string>(type: "text", nullable: true),
                    signaturDato = table.Column<string>(type: "text", nullable: true),
                    signaturKommentar = table.Column<string>(type: "text", nullable: true),
                    signaturSignatur = table.Column<string>(type: "text", nullable: true),
                    trykkBar = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SjekklisteViews", x => x.ServiceOrdreID);
                });
        }
    }
}
