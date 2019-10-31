using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RoutingDemo.Migrations
{
    public partial class category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "Vehicles",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    ParentId = table.Column<Guid>(nullable: false),
                    CategoryId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR746", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL445", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ801", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL389", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA359", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX379", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ893", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX481", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA763", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX715", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA930", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL207", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ702", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL877", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL290", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL822", "Volkswagen", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE656", "Opel", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR114", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR297", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA528", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL397", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA532", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA609", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR525", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL582", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX957", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR851", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX602", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA965", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX614", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX888", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR990", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL232", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ841", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR331", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA787", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE789", "Opel", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR739", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL932", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ489", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE157", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX662", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL846", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL534", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW968", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX925", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA973", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR860", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW113", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR100", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA312", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ535", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 53,
                column: "LicenseNumber",
                value: "MAZ790");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL874", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX522", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA391", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ768", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX851", "Lexus", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE809", "Opel", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR424", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL659", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW501", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR997", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE260", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR186", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA296", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA911", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ681", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR116", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE654", "Opel", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ802", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE859", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR262", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX183", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA196", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL573", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ804", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL454", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE763", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX234", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE610", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA489", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA437", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR895", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA287", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW893", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL932", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE661", "Opel", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW484", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA843", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA331", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA926", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL281", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ855", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "FOR287", "Ford" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW293", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR352", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW645", "BMW", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR919", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX450", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX568", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL399", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL535", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA232", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ324", "Mazda", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA908", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE385", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR123", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL597", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ446", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX209", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW896", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA162", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW325", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ181", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA367", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA387", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX405", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA580", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE655", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW932", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA485", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA929", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA519", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW450", "BMW", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA127", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX824", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR455", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA802", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW640", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA393", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE119", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA406", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ127", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA188", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW741", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX134", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE382", "Opel", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW468", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL111", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL868", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA699", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA251", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA618", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ129", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW122", "BMW", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA584", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA514", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL991", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX370", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL391", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA631", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR736", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE578", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL989", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE111", "Opel", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA429", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA592", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE222", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA899", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ515", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW704", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR984", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE599", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA301", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX978", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE785", "Opel", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 168,
                column: "LicenseNumber",
                value: "LEX396");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX359", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW245", "BMW", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE117", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW381", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA596", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "SAA259", "Saab" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA246", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW182", "BMW", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA805", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "FOR445", "Ford" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA209", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA328", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA308", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW589", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL852", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX612", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE656", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL656", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR897", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR203", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA626", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL806", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR523", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA512", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX619", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL365", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "FOR329", "Ford" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR543", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ524", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE582", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA775", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA475", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX579", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA752", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA951", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR522", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA616", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL787", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW357", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA887", "Kia", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA727", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX525", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ538", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR190", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ478", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL401", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 215,
                column: "LicenseNumber",
                value: "VOL665");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX228", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX972", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX108", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA780", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ779", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA928", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE583", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX653", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE518", "Opel", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA794", "Saab", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX991", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR959", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL891", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE366", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE566", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA273", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ709", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE889", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA373", "Kia", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL705", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE687", "Opel", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR141", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ235", "Mazda", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW924", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA511", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR621", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA504", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR598", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA281", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA115", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ290", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR822", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL615", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE478", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA779", "Kia", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ843", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE319", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ175", "Mazda", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR721", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA433", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW981", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA253", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ728", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ987", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX348", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA584", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW900", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA130", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ392", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA542", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA841", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR688", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE497", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL336", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA978", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR577", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW754", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR582", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE715", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX952", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW621", "BMW", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR799", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR748", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL143", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA103", "Kia", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL687", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA942", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW561", "BMW", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ974", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA897", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX346", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE282", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ955", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR672", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW398", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ829", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL951", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA613", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX985", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA375", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW827", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW836", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ281", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW146", "BMW", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ232", "Mazda", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA874", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR667", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR636", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX397", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ472", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR285", "Ford", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL949", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW333", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE261", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 310,
                column: "LicenseNumber",
                value: "VOL669");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW782", "BMW", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE812", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA174", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ860", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR494", "Ford", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE859", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW148", "BMW", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW270", "BMW", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR761", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL912", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE774", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX401", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL547", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "VOL512", "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA526", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA825", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW606", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA885", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL998", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL967", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA947", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR836", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA616", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA563", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA292", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL830", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ625", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX432", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA510", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW749", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA805", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL369", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE525", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ180", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR849", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA443", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ148", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR859", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA518", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL849", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA633", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW674", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ394", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX552", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA841", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE811", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL867", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA213", "Kia", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ887", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX246", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW849", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL560", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE707", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR910", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA667", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL566", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX242", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ342", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX754", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE409", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ448", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "FOR874", "Ford" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ544", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA137", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA733", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX276", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE123", "Opel", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA992", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX669", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL756", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW930", "BMW", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA325", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE454", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ887", "Mazda", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX651", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA478", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL994", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL810", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA638", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA680", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR787", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ724", "Mazda", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA671", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE870", "Opel", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW966", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR942", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA393", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR422", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ805", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA777", "Kia", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ509", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ550", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA913", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX552", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW383", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA974", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW815", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ997", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA849", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE104", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX545", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW141", "BMW", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE916", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE821", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA651", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW651", "BMW", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA321", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW615", "BMW", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX845", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE328", "Opel", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ958", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX767", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX132", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR462", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA867", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX351", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA382", "Saab", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR242", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ462", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX583", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR416", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ156", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW262", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW323", "BMW", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL627", "Volkswagen", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW702", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ176", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL691", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX159", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW669", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA734", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE566", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA364", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW303", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA466", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA384", "Kia", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL170", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ717", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE637", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ166", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX742", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL510", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL503", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA157", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA589", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW356", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR576", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ957", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL647", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX198", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX478", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR837", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE736", "Opel", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX361", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW863", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX100", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA948", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA608", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL597", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ686", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW782", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA244", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL873", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ661", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL169", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR500", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA975", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL260", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR674", "Ford", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW345", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR357", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA752", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL175", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ936", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA974", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA883", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE182", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA258", "Kia", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ436", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL337", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE282", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL389", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA928", "Saab", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA172", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA904", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA263", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR638", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ188", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR838", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA630", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA171", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW380", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ719", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ945", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX390", "Lexus", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX969", "Lexus", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA546", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR149", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ231", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA121", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE881", "Opel", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA534", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX975", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL678", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE630", "Opel", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ960", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW223", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW523", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA370", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA226", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR884", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ531", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA874", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW937", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX137", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW591", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE695", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR964", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW212", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA610", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR202", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW478", "BMW", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ218", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA930", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA897", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR869", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE268", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ883", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE118", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX305", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA198", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA782", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW105", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL636", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE231", "Opel", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ206", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA561", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR748", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA229", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR251", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE797", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX677", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW105", "BMW", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA481", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW896", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL935", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ647", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX839", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ485", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA957", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL579", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW951", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW393", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE116", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA118", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA898", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW834", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR405", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "VOL774", "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX455", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR651", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA582", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW382", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX595", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL587", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL655", "Volkswagen", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW452", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL865", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA806", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR501", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR146", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX301", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE241", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE220", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL769", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR118", "Ford", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW493", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA359", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX638", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ855", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ513", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW665", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE691", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA507", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE237", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR445", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA562", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ130", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX497", "Lexus", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ409", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL883", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA304", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ890", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA699", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA559", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX601", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA487", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR794", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA126", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE463", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR523", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA341", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL381", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX988", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE845", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW675", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE206", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW914", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX741", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA525", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR615", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE780", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR562", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR330", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR900", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE450", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX376", "Lexus", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA603", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA849", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL106", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL888", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW155", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE809", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA173", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA413", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW231", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 637,
                column: "LicenseNumber",
                value: "LEX483");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA314", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR164", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX416", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX435", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE681", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA285", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW464", "BMW", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL597", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR412", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR450", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ692", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL146", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL679", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX610", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE770", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ387", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ962", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX250", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX111", "Lexus", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ345", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ541", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX827", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ264", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL512", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL416", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW502", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW432", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA700", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE178", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE310", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA513", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA392", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA674", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX476", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA519", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE167", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW356", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL233", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX117", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW292", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ182", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX563", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX370", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA472", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW323", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX215", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 684,
                column: "LicenseNumber",
                value: "FOR187");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX193", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX819", "Lexus", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA363", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA702", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE547", "Opel", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA349", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX920", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW232", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW759", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX580", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW394", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA346", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX826", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ503", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX310", "Lexus", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ443", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ483", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW239", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR651", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX499", "Lexus", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA316", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ420", "Mazda", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA306", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR923", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE583", "Opel", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE814", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX189", "Lexus", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA150", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA189", "Kia", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR278", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ682", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA103", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR127", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW819", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR109", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE765", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL277", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW707", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA989", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR193", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR192", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA129", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR381", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL320", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ507", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA410", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA443", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA942", "Saab", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX743", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX693", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX390", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX960", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ723", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX102", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE273", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX759", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR318", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL801", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ406", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR500", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA830", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ959", "Mazda", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX226", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE822", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ172", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA278", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ562", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX729", "Lexus", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE650", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL504", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL835", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR705", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR359", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR946", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL253", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE817", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ719", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA734", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX345", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA888", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA424", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ813", "Mazda", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX217", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE896", "Opel", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX769", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL772", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "VOL192", "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW627", "BMW", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ855", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA148", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE337", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE440", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL617", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA383", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ892", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW673", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX703", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL984", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW335", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW216", "BMW", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX830", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA851", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL406", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA290", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR324", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW349", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ970", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR716", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA299", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA180", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA729", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE377", "Opel", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE109", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA513", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA182", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE240", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ199", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX727", "Lexus", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR502", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA872", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL628", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR919", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE509", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX352", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR550", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE353", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL322", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA437", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX518", "Lexus", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX458", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW660", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR609", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW164", "BMW", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR416", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ486", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW219", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR613", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR547", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL570", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR858", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE252", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA669", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ960", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX628", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR731", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW528", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX227", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA420", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW613", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA646", "Kia", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA547", "Kia", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR245", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR496", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW393", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR768", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX858", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW917", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA863", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ489", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW198", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA371", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA731", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA465", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL502", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA732", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW341", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL520", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ595", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ205", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL411", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ225", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA429", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA187", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA727", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE756", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE860", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA714", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR201", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL935", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ656", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL263", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA160", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA225", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA150", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR709", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ818", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW741", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR430", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ908", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA214", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE911", "Opel", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE258", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE254", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ129", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ838", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL415", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE790", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA226", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX698", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW973", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR766", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX318", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR859", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE675", "Opel", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL827", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ478", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL368", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL588", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA162", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ879", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE736", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR637", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA669", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL123", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE409", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA548", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA527", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR176", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ474", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR388", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR862", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX351", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX449", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR636", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW360", "BMW", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR444", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR575", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL165", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA242", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL641", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR789", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA826", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR702", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA822", "Kia", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA605", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW123", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW372", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA232", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW716", "BMW", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW505", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA661", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW119", "BMW", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW361", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE315", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ785", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ135", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE580", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA867", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA838", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL571", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA701", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR650", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR831", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL737", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ127", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA629", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA883", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL817", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX286", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ647", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR711", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ476", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL926", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR873", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR271", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW316", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW598", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR262", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ876", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW711", "BMW", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE607", "Opel", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR608", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA712", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL595", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ320", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX118", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL385", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX978", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA731", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE647", "Opel", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL926", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR877", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA420", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL239", "Volkswagen", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL521", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX751", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX801", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW941", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA267", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL189", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW623", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA567", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL296", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA215", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ119", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR516", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE216", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX276", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW245", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX128", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ634", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR992", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL890", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX872", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE688", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ108", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX782", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ843", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX722", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA164", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA350", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR756", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL949", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA678", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL462", "Volkswagen", "9-3" });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryId",
                table: "Categories",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "Model",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Make",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LicenseNumber",
                table: "Vehicles",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW122", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX367", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL564", "Volkswagen", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW224", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ393", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA213", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX126", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA944", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA428", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL612", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA278", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE682", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL937", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL136", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA991", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX450", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ929", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ896", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL499", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA506", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX811", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX591", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX908", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ720", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR126", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX793", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX656", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX869", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL583", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA675", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR972", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE856", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR180", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE733", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE523", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR637", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW200", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ436", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW879", "BMW", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX134", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX126", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR165", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ375", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR514", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ895", "Mazda", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX649", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA561", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX949", "Lexus", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL155", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL522", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX800", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA189", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 53,
                column: "LicenseNumber",
                value: "MAZ324");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA619", "Saab", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA668", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ424", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE277", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR651", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL905", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA701", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX815", "Lexus", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW237", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ811", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW981", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA662", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX562", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA339", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ507", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR539", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR185", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR302", "Ford", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL204", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW262", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE178", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL464", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR362", "Ford", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX231", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA623", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE767", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "SAA300", "Saab" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ844", "Mazda", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ437", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ391", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE927", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA668", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR216", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA594", "Kia", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR697", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX591", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL823", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA653", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX262", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR863", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA854", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX246", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR695", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX912", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL312", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ157", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR535", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW396", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE493", "Opel", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA770", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE985", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA387", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ482", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE549", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW710", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX885", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA165", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA865", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA167", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE162", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ458", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX128", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX100", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX968", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL774", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX232", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ190", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL834", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ593", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA588", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR553", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA574", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA926", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL239", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW144", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA245", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA984", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX600", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX750", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL900", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE228", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE538", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE647", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR733", "Ford", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR427", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX269", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ623", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA336", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL162", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX407", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW502", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA926", "Kia", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX564", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL929", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL300", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA621", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR277", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL465", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA533", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW173", "BMW", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE658", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR181", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR611", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE100", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ681", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ891", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA410", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE180", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA486", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA811", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE319", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE870", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA266", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA301", "Kia", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 168,
                column: "LicenseNumber",
                value: "LEX835");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR402", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ990", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL408", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ536", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL886", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ284", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW572", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ807", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW346", "BMW", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ985", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA758", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "FOR220", "Ford" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA818", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW118", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX946", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA899", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA578", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX520", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA415", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL114", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ690", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA258", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ911", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ693", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE906", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE337", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW381", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA247", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE972", "Opel", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR308", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW135", "BMW", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW688", "BMW", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA827", "Saab", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ312", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX665", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW984", "BMW", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL381", "Volkswagen", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA348", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ323", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE316", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR106", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ774", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL655", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR134", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE574", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA587", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 215,
                column: "LicenseNumber",
                value: "VOL291");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX924", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX609", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ530", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE427", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL868", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR402", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW745", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA434", "Saab", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA413", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ692", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ144", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA569", "Kia", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA988", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR340", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA996", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ324", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ826", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR151", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE180", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL810", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR262", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW674", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA157", "Saab", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA361", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA207", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE297", "Opel", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA524", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA554", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW125", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX393", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE849", "Opel", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR611", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA874", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA162", "Saab", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR490", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE717", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX206", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW792", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA699", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ932", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL762", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ388", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE510", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL671", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA970", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE513", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA431", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA292", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR188", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA614", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX167", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX784", "Lexus", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA251", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA490", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR464", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE894", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW937", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR424", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL995", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE156", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR995", "Ford", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW711", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL992", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR273", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA100", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX452", "Lexus", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW799", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR721", "Ford", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL578", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ284", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ677", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA451", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE518", "Opel", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ833", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW613", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ436", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA894", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL579", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA872", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA710", "Saab", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA791", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW985", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL812", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL542", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX573", "Lexus", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX453", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA555", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR534", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA839", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA646", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL844", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW822", "BMW", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA890", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL509", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 310,
                column: "LicenseNumber",
                value: "VOL864");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA422", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX469", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE162", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR296", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA105", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR181", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR182", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ306", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ952", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE495", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA395", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL289", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE302", "Opel", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "FOR705", "Ford" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ382", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL426", "Volkswagen", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW524", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA458", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ336", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA219", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE439", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL227", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW335", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW157", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW764", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE326", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "LEX892", "Lexus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL852", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX913", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX934", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX592", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA854", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA297", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR850", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA506", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE221", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ593", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX881", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR134", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL243", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR553", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA179", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE981", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX551", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA252", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA360", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA922", "Saab", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ333", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA864", "Saab", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ623", "Mazda", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW275", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA515", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA958", "Saab", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA505", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR949", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA275", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ209", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ844", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR472", "Ford", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR674", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR691", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "SAA184", "Saab" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA579", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ496", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA453", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE312", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA713", "Saab", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ427", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE391", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA276", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA586", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA801", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW449", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW759", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ292", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ874", "Mazda", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE619", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR411", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX625", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA792", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ893", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA420", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX658", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL625", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW386", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX741", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR430", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE784", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL893", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR342", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR590", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL573", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW151", "BMW", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW206", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR851", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX273", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA384", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW895", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE759", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA565", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE447", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA906", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA196", "Kia", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW454", "BMW", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ751", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR853", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX337", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ169", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX174", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ551", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW398", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL820", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ216", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX845", "Lexus", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA672", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX617", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR828", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW838", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR338", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA836", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW765", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL183", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA672", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX153", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ455", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE691", "Opel", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE851", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE807", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ334", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE391", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL295", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA371", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA965", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL840", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX428", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ941", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE916", "Opel", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL183", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX644", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX842", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW601", "BMW", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA835", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW629", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA863", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ907", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX988", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE494", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA272", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE353", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA587", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ364", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA129", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR619", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL562", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA279", "Saab", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA727", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR519", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL727", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA275", "Saab", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA264", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL816", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA941", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL917", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW700", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE783", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX530", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX767", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL173", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA396", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL938", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW508", "BMW", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA924", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ693", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR173", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW955", "BMW", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW444", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX329", "Lexus", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ339", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE560", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ139", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL580", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX613", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR631", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW462", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW620", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ395", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA640", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX111", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ328", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR804", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE150", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL344", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL123", "Volkswagen", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA922", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW982", "BMW", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW432", "BMW", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ895", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR477", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE123", "Opel", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE669", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA809", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW937", "BMW", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA817", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA735", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA476", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ360", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA953", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW908", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW228", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "VOL751", "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR315", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA356", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA442", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA479", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL454", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR605", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX306", "Lexus", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ281", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ325", "Mazda", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW949", "BMW", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW779", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA830", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE469", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA905", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX139", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL861", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE159", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL228", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE334", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA421", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA821", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE568", "Opel", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ140", "Mazda", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL726", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR929", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA313", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR862", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE922", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW821", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL350", "Volkswagen", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL934", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA144", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA498", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE582", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW762", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA544", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR466", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX349", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE620", "Opel", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW802", "BMW", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ683", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ104", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ543", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW173", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW120", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA266", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR554", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA227", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "BMW351", "BMW" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ275", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE675", "Opel", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ580", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW658", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ150", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX681", "Lexus", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA970", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR777", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA796", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA447", "Saab", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE305", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ354", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA784", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE602", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE364", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL670", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE794", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE121", "Opel", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA162", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE298", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW206", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA877", "Kia", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA288", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "MAZ702", "Mazda" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW841", "BMW", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE552", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE991", "Opel", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA845", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL169", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR502", "Ford", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR147", "Ford", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL523", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE790", "Opel", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE247", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE398", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA447", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR420", "Ford", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL974", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR357", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA184", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW386", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ613", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL131", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA235", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ445", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW888", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE216", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ316", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA640", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA618", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR580", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ737", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW857", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ991", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA690", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR710", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL761", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE770", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX918", "Lexus", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA673", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX780", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE590", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL200", "Volkswagen", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ799", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA779", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA896", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL587", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 637,
                column: "LicenseNumber",
                value: "LEX673");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW176", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW346", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW745", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR704", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR460", "Ford", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA546", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL231", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX802", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX532", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA560", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA795", "Kia", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA209", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE169", "Opel", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW944", "BMW", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA703", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA256", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE120", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA372", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE213", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA648", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW100", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR521", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW100", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA536", "Saab", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE787", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR344", "Ford", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA681", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA771", "Saab", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE477", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE514", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX781", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE844", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX501", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR563", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR593", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL415", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL739", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW654", "BMW", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX964", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR804", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA293", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL297", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ469", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX791", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW502", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA153", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 684,
                column: "LicenseNumber",
                value: "FOR235");

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA161", "Kia", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ720", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA356", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW877", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ534", "Mazda", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA681", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA460", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX766", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX110", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR168", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX540", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL300", "Volkswagen", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA881", "Kia", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL255", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA379", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX532", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX305", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE880", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ149", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA854", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ458", "Mazda", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR419", "Ford", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "SAA908", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR612", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW955", "BMW", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR332", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE633", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL753", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW920", "BMW", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL620", "Volkswagen", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR736", "Ford", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA404", "Kia", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW847", "BMW", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX870", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL463", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ815", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX134", "Lexus", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW546", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR546", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ281", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE885", "Opel", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA152", "Saab", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW706", "BMW", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL662", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE309", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ301", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA622", "Saab", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA179", "Kia", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL686", "Volkswagen", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR487", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW352", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL553", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX405", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA649", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA813", "Kia", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE230", "Opel", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR930", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR906", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL794", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW501", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE722", "Opel", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR170", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "SAA720", "Saab" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ471", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW207", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX215", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA755", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE997", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE530", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA919", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ287", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW883", "BMW", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX332", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ366", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE535", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE187", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW151", "BMW", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL439", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ486", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ933", "Mazda", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL565", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW351", "BMW", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR786", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR858", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW807", "BMW", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE225", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "OPE917", "Opel" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA174", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW490", "BMW", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW789", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE879", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA847", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW336", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR209", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA392", "Saab", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR671", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL614", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA520", "Saab", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX174", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE671", "Opel", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW587", "BMW", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX597", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX272", "Lexus", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX193", "Lexus", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW473", "BMW", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW821", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ136", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW655", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR792", "Ford", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE659", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ527", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL692", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL502", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ962", "Mazda", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE419", "Opel", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE636", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA906", "Kia", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA110", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL871", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX444", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW956", "BMW", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL133", "Volkswagen", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL708", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ492", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA217", "Saab", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA398", "Kia", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR515", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR828", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ451", "Mazda", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE134", "Opel", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW335", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA445", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX238", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA902", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX770", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE477", "Opel", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW475", "BMW", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL819", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX960", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA519", "Kia", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL946", "Volkswagen", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL354", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR748", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ287", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR651", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL799", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA340", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX320", "Lexus", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL743", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE195", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE778", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ461", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX159", "Lexus", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE426", "Opel", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ249", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR501", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR173", "Ford", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR375", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR376", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ466", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL882", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL940", "Volkswagen", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE996", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR728", "Ford", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ734", "Mazda", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX255", "Lexus", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA686", "Kia", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR568", "Ford", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA561", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE750", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA988", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ368", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE589", "Opel", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR625", "Ford", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE510", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA281", "Saab", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL214", "Volkswagen", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA401", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ246", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA814", "Saab", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE754", "Opel", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR182", "Ford", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ488", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE923", "Opel", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL441", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA124", "Kia", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA557", "Kia", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA927", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL426", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ390", "Mazda", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA296", "Kia", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ527", "Mazda", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW626", "BMW", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA226", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ646", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR546", "Ford", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX284", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "KIA706", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA896", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW891", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ887", "Mazda", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA995", "Kia", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ785", "Mazda", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX432", "Lexus", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE726", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "SAA440", "Saab" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA264", "Saab", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW946", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA623", "Kia", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL485", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL302", "Volkswagen", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ404", "Mazda", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR682", "Ford", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL416", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ281", "Mazda", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW381", "BMW", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX364", "Lexus", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE116", "Opel", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "MAZ179", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX998", "Lexus", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE228", "Opel", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA900", "Saab", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA808", "Kia", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA645", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ637", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW433", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ127", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR342", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA351", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR551", "Ford", "i8" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR456", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ177", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR516", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA714", "Saab", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL587", "Volkswagen", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ567", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE508", "Opel", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ489", "Mazda", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX382", "Lexus", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW961", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL510", "Volkswagen", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA547", "Saab", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR307", "Ford", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "OPE512", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX388", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA703", "Saab", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ127", "Mazda", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ878", "Mazda", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA876", "Kia", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX798", "Lexus", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ934", "Mazda", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE529", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "FOR315", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA479", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA972", "Saab", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX541", "Lexus", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA216", "Kia", "Ascona" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL529", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX888", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL369", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL213", "Volkswagen", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE111", "Opel", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL508", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW306", "BMW", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE725", "Opel", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL643", "Volkswagen", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW504", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA806", "Saab", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL924", "Volkswagen", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE618", "Opel", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL754", "Volkswagen", "Kadett" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX961", "Lexus", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA904", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX220", "Lexus", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "KIA304", "Kia" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "LEX267", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW194", "BMW", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR918", "Ford", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW208", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA403", "Saab", "Up" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA595", "Kia", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW288", "BMW", "Fiesta" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE102", "Opel", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ426", "Mazda", "V90" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ383", "Mazda", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA376", "Saab", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL677", "Volkswagen", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ985", "Mazda", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "OPE699", "Opel", "XC60" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW883", "BMW", "Rio" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "BMW777", "M3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL199", "Volkswagen", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL777", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX503", "Lexus", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR758", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ536", "Mazda", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL688", "Volkswagen", "9000" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "BMW806", "BMW", "Polo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ224", "Mazda", "C30" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL676", "Volkswagen", "740" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "VOL212", "Volkswagen", "Passat" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA173", "Kia", "M5" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "LicenseNumber", "Model" },
                values: new object[] { "VOL819", "Mondeo" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR909", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "LicenseNumber", "Make" },
                values: new object[] { "VOL166", "Volkswagen" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR414", "Ford", "9-3" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR542", "Ford", "Golf" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR355", "Ford", "Egde" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "FOR910", "Ford", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX301", "Lexus", "Touareg" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "LEX531", "Lexus", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "KIA497", "Kia", "900" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "SAA882", "Saab", "Ceed" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ222", "Mazda", "Focus" });

            migrationBuilder.UpdateData(
                table: "Vehicles",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "LicenseNumber", "Make", "Model" },
                values: new object[] { "MAZ572", "Mazda", "C30" });
        }
    }
}
