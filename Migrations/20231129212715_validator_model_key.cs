using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AutenticacaoDeDoisFatores.Migrations
{
    public partial class validator_model_key : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Code",
                table: "ValidatorModels",
                newName: "Key");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Key",
                table: "ValidatorModels",
                newName: "Code");
        }
    }
}
