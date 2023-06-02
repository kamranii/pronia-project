using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProniaBE.Migrations
{
    public partial class PostCreationDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreationDate",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValueSql: "GetUtcDate()",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreationDate",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValueSql: "GetUtcDate()");
        }
    }
}
