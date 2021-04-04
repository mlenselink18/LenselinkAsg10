using Microsoft.EntityFrameworkCore.Migrations;

namespace LenselinkAsg10.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MakeModel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "ID", "Color", "MakeModel", "Mileage", "Price", "Year" },
                values: new object[] { 1, "Silver", "Nissan Sentra", 84574, 8995, 2013 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "ID", "Color", "MakeModel", "Mileage", "Price", "Year" },
                values: new object[] { 2, "Blue", "Chevrolet Spark LS", 35304, 8995, 2014 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
