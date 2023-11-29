using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutenticacaoDeDoisFatores.Migrations
{
    public partial class validator_model_Com_Email : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Username",
                table: "ValidatorModels",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "ValidatorModels",
                newName: "Username");
        }
    }
}
