using Microsoft.EntityFrameworkCore.Migrations;

namespace coreProject.Migrations
{
    public partial class createdb22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matiere_Professeur_codeFiliere",
                table: "Matiere");

            migrationBuilder.DropIndex(
                name: "IX_Matiere_codeFiliere",
                table: "Matiere");

            migrationBuilder.DropColumn(
                name: "codeFiliere",
                table: "Matiere");

            migrationBuilder.CreateIndex(
                name: "IX_Matiere_codeProf",
                table: "Matiere",
                column: "codeProf");

            migrationBuilder.AddForeignKey(
                name: "FK_Matiere_Professeur_codeProf",
                table: "Matiere",
                column: "codeProf",
                principalTable: "Professeur",
                principalColumn: "codeProf",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matiere_Professeur_codeProf",
                table: "Matiere");

            migrationBuilder.DropIndex(
                name: "IX_Matiere_codeProf",
                table: "Matiere");

            migrationBuilder.AddColumn<int>(
                name: "codeFiliere",
                table: "Matiere",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Matiere_codeFiliere",
                table: "Matiere",
                column: "codeFiliere");

            migrationBuilder.AddForeignKey(
                name: "FK_Matiere_Professeur_codeFiliere",
                table: "Matiere",
                column: "codeFiliere",
                principalTable: "Professeur",
                principalColumn: "codeProf",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
