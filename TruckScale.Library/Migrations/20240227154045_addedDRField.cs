using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TruckScale.Library.Migrations
{
    /// <inheritdoc />
    public partial class addedDRField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Drop the existing 'UserName' column if it exists
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Weighers");

            migrationBuilder.AlterColumn<int>(
                name: "WeigherId",
                table: "WeighingTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TruckId",
                table: "WeighingTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "WeighingTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "WeighingTransactions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DrNumber",
                table: "WeighingTransactions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Weighers",
                type: "nvarchar(max)",
                nullable: true);



            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Products_ProductId",
                table: "WeighingTransactions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Suppliers_SupplierId",
                table: "WeighingTransactions",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Trucks_TruckId",
                table: "WeighingTransactions",
                column: "TruckId",
                principalTable: "Trucks",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Weighers_WeigherId",
                table: "WeighingTransactions",
                column: "WeigherId",
                principalTable: "Weighers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WeighingTransactions_Customers_CustomerId",
                table: "WeighingTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_WeighingTransactions_Products_ProductId",
                table: "WeighingTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_WeighingTransactions_Suppliers_SupplierId",
                table: "WeighingTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_WeighingTransactions_Trucks_TruckId",
                table: "WeighingTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_WeighingTransactions_Weighers_WeigherId",
                table: "WeighingTransactions");

            migrationBuilder.DropColumn(
                name: "DrNumber",
                table: "WeighingTransactions");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Weighers");

            migrationBuilder.AlterColumn<int>(
                name: "WeigherId",
                table: "WeighingTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TruckId",
                table: "WeighingTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SupplierId",
                table: "WeighingTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProductId",
                table: "WeighingTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "WeighingTransactions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Customers_CustomerId",
                table: "WeighingTransactions",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Products_ProductId",
                table: "WeighingTransactions",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Suppliers_SupplierId",
                table: "WeighingTransactions",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Trucks_TruckId",
                table: "WeighingTransactions",
                column: "TruckId",
                principalTable: "Trucks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WeighingTransactions_Weighers_WeigherId",
                table: "WeighingTransactions",
                column: "WeigherId",
                principalTable: "Weighers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
