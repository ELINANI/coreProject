using Microsoft.EntityFrameworkCore.Migrations;

namespace coreProject.Migrations
{
    public partial class createdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "adresseProfesseur",
                table: "Professeur",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "nomProfesseur",
                table: "Professeur",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "phoneProfesseur",
                table: "Professeur",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "prenomProfesseur",
                table: "Professeur",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "adresseProfesseur",
                table: "Professeur");

            migrationBuilder.DropColumn(
                name: "nomProfesseur",
                table: "Professeur");

            migrationBuilder.DropColumn(
                name: "phoneProfesseur",
                table: "Professeur");

            migrationBuilder.DropColumn(
                name: "prenomProfesseur",
                table: "Professeur");
        }
    }
}
