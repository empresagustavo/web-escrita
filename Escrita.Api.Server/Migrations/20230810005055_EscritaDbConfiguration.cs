using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Escrita.Api.Server.Migrations
{
    public partial class EscritaDbConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateSequence<int>(
                name: "EscritaDbConfiguration");

            migrationBuilder.CreateTable(
                name: "MonthlyCustomers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tenant = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonthlyCustomers", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MonthlyCustomers");

            migrationBuilder.DropSequence(
                name: "EscritaDbConfiguration");
        }
    }
}
