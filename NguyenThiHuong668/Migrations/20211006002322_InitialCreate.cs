using Microsoft.EntityFrameworkCore.Migrations;

namespace NguyenThiHuong668.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonNTH668",
                columns: table => new
                {
                    PersonId = table.Column<string>(type: "varchar(20)", nullable: false),
                    PersonName = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonNTH668", x => x.PersonId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonNTH668");
        }
    }
}
