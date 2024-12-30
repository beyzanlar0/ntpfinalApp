using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ntpfinalApp.Migrations
{
    /// <inheritdoc />
    public partial class SinifEkle : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontenjan" },
                values: new object[] { "A", "5" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontenjan" },
                values: new object[] { "B", "5" });

            migrationBuilder.InsertData(
                table: "Siniflar",
                columns: new[] { "SinifAd", "SinifKontenjan" },
                values: new object[] { "C", "5" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
