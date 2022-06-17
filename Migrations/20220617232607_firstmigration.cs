using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace hospitalinformationsystem.Migrations
{
    public partial class firstmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "patientInfoModels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    patientNo = table.Column<int>(type: "int", nullable: false),
                    patientName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patientSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patientMotherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patientFatherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    patientHeight = table.Column<float>(type: "real", nullable: false),
                    patientWeight = table.Column<float>(type: "real", nullable: false),
                    bloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    birthType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    motherBloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fatherBloodType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InsertedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_patientInfoModels", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "staffModels",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    doctorNo = table.Column<int>(type: "int", nullable: false),
                    doctorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    doctorSurname = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_staffModels", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "patientInfoModels");

            migrationBuilder.DropTable(
                name: "staffModels");
        }
    }
}
