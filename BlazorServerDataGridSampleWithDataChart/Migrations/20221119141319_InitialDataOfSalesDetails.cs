using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServerDataGridSampleWithDataChart.Migrations
{
    public partial class InitialDataOfSalesDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "Id", "Amount", "ItemCode", "ItemName", "Quantity", "RowNumber", "SalesTax", "SlipNumber", "UnitPrice" },
                values: new object[] { 1, 990m, "S001", "商品1", 3m, 1, 99m, 10001, 330m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SalesDetails",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
