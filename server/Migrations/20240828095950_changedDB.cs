using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Migrations
{
    /// <inheritdoc />
    public partial class changedDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Books__author_id__3B75D760",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK__Books__publisher__3C69FB99",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK__Carts__book_id__534D60F1",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK__Carts__user_id__5441852A",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK__Order_ite__book___5812160E",
                table: "Order_items");

            migrationBuilder.DropForeignKey(
                name: "FK__Order_ite__order__571DF1D5",
                table: "Order_items");

            migrationBuilder.DropForeignKey(
                name: "FK__Orders__payment___4BAC3F29",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK__Orders__user_id__4AB81AF0",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BookTag");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Publishers");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Orders__465962298B4F3117",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_payment_id",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Carts__2EF52A27B9CE3939",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Books_author_id",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_publisher_id",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK__Order_it__3764B6BC850F45D3",
                table: "Order_items");

            migrationBuilder.RenameTable(
                name: "Order_items",
                newName: "OrderItems");

            migrationBuilder.RenameColumn(
                name: "total",
                table: "Orders",
                newName: "Total");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Orders",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "payment_id",
                table: "Orders",
                newName: "PaymentId");

            migrationBuilder.RenameColumn(
                name: "order_date",
                table: "Orders",
                newName: "OrderDate");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "Orders",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_user_id",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "Carts",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "Carts",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "Carts",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "cart_id",
                table: "Carts",
                newName: "CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_user_id",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_book_id",
                table: "Carts",
                newName: "IX_Carts_BookId");

            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "OrderItems",
                newName: "Quantity");

            migrationBuilder.RenameColumn(
                name: "order_id",
                table: "OrderItems",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "book_id",
                table: "OrderItems",
                newName: "BookId");

            migrationBuilder.RenameColumn(
                name: "order_item_id",
                table: "OrderItems",
                newName: "OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_items_order_id",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_items_book_id",
                table: "OrderItems",
                newName: "IX_OrderItems_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "CartId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Books_BookId",
                table: "Carts",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Books_BookId",
                table: "OrderItems",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "user_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Books_BookId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Books_BookId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "Order_items");

            migrationBuilder.RenameColumn(
                name: "Total",
                table: "Orders",
                newName: "total");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Orders",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "PaymentId",
                table: "Orders",
                newName: "payment_id");

            migrationBuilder.RenameColumn(
                name: "OrderDate",
                table: "Orders",
                newName: "order_date");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Orders",
                newName: "order_id");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                newName: "IX_Orders_user_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Carts",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Carts",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Carts",
                newName: "book_id");

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "Carts",
                newName: "cart_id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                newName: "IX_Carts_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_BookId",
                table: "Carts",
                newName: "IX_Carts_book_id");

            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Order_items",
                newName: "quantity");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "Order_items",
                newName: "order_id");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "Order_items",
                newName: "book_id");

            migrationBuilder.RenameColumn(
                name: "OrderItemId",
                table: "Order_items",
                newName: "order_item_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "Order_items",
                newName: "IX_Order_items_order_id");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_BookId",
                table: "Order_items",
                newName: "IX_Order_items_book_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Orders__465962298B4F3117",
                table: "Orders",
                column: "order_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Carts__2EF52A27B9CE3939",
                table: "Carts",
                column: "cart_id");

            migrationBuilder.AddPrimaryKey(
                name: "PK__Order_it__3764B6BC850F45D3",
                table: "Order_items",
                column: "order_item_id");

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    author_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    author_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    bio = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Authors__86516BCFA24EBAF7", x => x.author_id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    payment_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    amount = table.Column<decimal>(type: "money", nullable: true),
                    payment_type = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    status = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__ED1FC9EA0B9BA1AD", x => x.payment_id);
                });

            migrationBuilder.CreateTable(
                name: "Publishers",
                columns: table => new
                {
                    publisher_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    publisher_address = table.Column<string>(type: "text", nullable: true),
                    publisher_name = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Publishe__3263F29DAFF3A768", x => x.publisher_id);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    review_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    book_id = table.Column<int>(type: "int", nullable: true),
                    user_id = table.Column<int>(type: "int", nullable: true),
                    rating = table.Column<int>(type: "int", nullable: true),
                    review = table.Column<string>(type: "varchar(300)", unicode: false, maxLength: 300, nullable: true),
                    reviewed_date = table.Column<DateOnly>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__60883D90FB2C6292", x => x.review_id);
                    table.ForeignKey(
                        name: "FK__Reviews__book_id__4E88ABD4",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "book_id");
                    table.ForeignKey(
                        name: "FK__Reviews__user_id__4F7CD00D",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "user_id");
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    tag_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tag = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tags__4296A2B663E5BFA0", x => x.tag_id);
                });

            migrationBuilder.CreateTable(
                name: "BookTag",
                columns: table => new
                {
                    book_id = table.Column<int>(type: "int", nullable: false),
                    tag_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__BookTag__3D2470CACC5A9021", x => new { x.book_id, x.tag_id });
                    table.ForeignKey(
                        name: "FK__BookTag__book_id__440B1D61",
                        column: x => x.book_id,
                        principalTable: "Books",
                        principalColumn: "book_id");
                    table.ForeignKey(
                        name: "FK__BookTag__tag_id__44FF419A",
                        column: x => x.tag_id,
                        principalTable: "Tags",
                        principalColumn: "tag_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_payment_id",
                table: "Orders",
                column: "payment_id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_author_id",
                table: "Books",
                column: "author_id");

            migrationBuilder.CreateIndex(
                name: "IX_Books_publisher_id",
                table: "Books",
                column: "publisher_id");

            migrationBuilder.CreateIndex(
                name: "IX_BookTag_tag_id",
                table: "BookTag",
                column: "tag_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_book_id",
                table: "Reviews",
                column: "book_id");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_user_id",
                table: "Reviews",
                column: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Books__author_id__3B75D760",
                table: "Books",
                column: "author_id",
                principalTable: "Authors",
                principalColumn: "author_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Books__publisher__3C69FB99",
                table: "Books",
                column: "publisher_id",
                principalTable: "Publishers",
                principalColumn: "publisher_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Carts__book_id__534D60F1",
                table: "Carts",
                column: "book_id",
                principalTable: "Books",
                principalColumn: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Carts__user_id__5441852A",
                table: "Carts",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Order_ite__book___5812160E",
                table: "Order_items",
                column: "book_id",
                principalTable: "Books",
                principalColumn: "book_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Order_ite__order__571DF1D5",
                table: "Order_items",
                column: "order_id",
                principalTable: "Orders",
                principalColumn: "order_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Orders__payment___4BAC3F29",
                table: "Orders",
                column: "payment_id",
                principalTable: "Payments",
                principalColumn: "payment_id");

            migrationBuilder.AddForeignKey(
                name: "FK__Orders__user_id__4AB81AF0",
                table: "Orders",
                column: "user_id",
                principalTable: "Users",
                principalColumn: "user_id");
        }
    }
}
