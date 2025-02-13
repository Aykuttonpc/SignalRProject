using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SignalR.DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class added_descripton3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Ttile",
                table: "SocialMedias",
                newName: "Title");

            migrationBuilder.AddColumn<string>(
                name: "Descripton3",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descripton3",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "SocialMedias",
                newName: "Ttile");
        }
    }
}
