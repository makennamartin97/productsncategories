using Microsoft.EntityFrameworkCore.Migrations;

namespace productsncategories.Migrations
{
    public partial class migrations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Products_ProductID",
                table: "Associations");

            migrationBuilder.DropForeignKey(
                name: "FK_Associations_Categories_categoryID",
                table: "Associations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Associations",
                table: "Associations");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "products");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.RenameTable(
                name: "Associations",
                newName: "associations");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "associations",
                newName: "productID");

            migrationBuilder.RenameIndex(
                name: "IX_Associations_categoryID",
                table: "associations",
                newName: "IX_associations_categoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Associations_ProductID",
                table: "associations",
                newName: "IX_associations_productID");

            migrationBuilder.AlterColumn<string>(
                name: "productname",
                table: "products",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "categoryname",
                table: "categories",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddPrimaryKey(
                name: "PK_products",
                table: "products",
                column: "productID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "categoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_associations",
                table: "associations",
                column: "associationID");

            migrationBuilder.AddForeignKey(
                name: "FK_associations_categories_categoryID",
                table: "associations",
                column: "categoryID",
                principalTable: "categories",
                principalColumn: "categoryID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_associations_products_productID",
                table: "associations",
                column: "productID",
                principalTable: "products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_associations_categories_categoryID",
                table: "associations");

            migrationBuilder.DropForeignKey(
                name: "FK_associations_products_productID",
                table: "associations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_products",
                table: "products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_associations",
                table: "associations");

            migrationBuilder.RenameTable(
                name: "products",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "associations",
                newName: "Associations");

            migrationBuilder.RenameColumn(
                name: "productID",
                table: "Associations",
                newName: "ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_associations_productID",
                table: "Associations",
                newName: "IX_Associations_ProductID");

            migrationBuilder.RenameIndex(
                name: "IX_associations_categoryID",
                table: "Associations",
                newName: "IX_Associations_categoryID");

            migrationBuilder.AlterColumn<string>(
                name: "productname",
                table: "Products",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "categoryname",
                table: "Categories",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "productID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "categoryID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Associations",
                table: "Associations",
                column: "associationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Products_ProductID",
                table: "Associations",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "productID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Associations_Categories_categoryID",
                table: "Associations",
                column: "categoryID",
                principalTable: "Categories",
                principalColumn: "categoryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
