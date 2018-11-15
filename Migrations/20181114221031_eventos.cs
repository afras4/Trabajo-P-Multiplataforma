using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Trabajo.Migrations
{
    public partial class eventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "Eventos",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.UpdateData(
                table: "Alumnos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "Nombre", "Password" },
                values: new object[] { 1811586, "Andres Frias", "666" });

            migrationBuilder.UpdateData(
                table: "Alumnos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "Nombre", "Password" },
                values: new object[] { 123443, "Denis castillo", "999" });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "Id", "Descripcion", "Direccion", "Fecha", "Foto", "Nombre" },
                values: new object[] { 1, "Ayudar a recibir alimentos y bebidas y empaquetarlas para ser llevadas a puno", "Av Los frutales 666 La molina", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "https://api.netnoticias.mx/im/2017/09/10/770x490-tMlnQSNblV09w.JPG", "Trabajo comunitario" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Eventos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "Eventos",
                nullable: false,
                oldClrType: typeof(DateTime));

            migrationBuilder.UpdateData(
                table: "Alumnos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Codigo", "Nombre", "Password" },
                values: new object[] { 0, "Link in Park", "https://i.kym-cdn.com/photos/images/newsfeed/000/937/730/e9a.jpg" });

            migrationBuilder.UpdateData(
                table: "Alumnos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Codigo", "Nombre", "Password" },
                values: new object[] { 0, "BTS", "https://multimedia.larepublica.pe/720x405/larepublica/imagen/2018/10/16/noticia-peli-bts-burn-stage.jpg" });
        }
    }
}
