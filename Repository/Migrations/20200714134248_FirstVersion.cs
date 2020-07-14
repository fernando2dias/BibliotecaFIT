using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class FirstVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookLoans",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookLoans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(maxLength: 100, nullable: false),
                    QuantityPages = table.Column<int>(nullable: false),
                    Published = table.Column<DateTime>(nullable: false),
                    BarCode = table.Column<string>(maxLength: 100, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Site = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookBookLoan",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false),
                    BookLoanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBookLoan", x => new { x.BookId, x.BookLoanId });
                    table.ForeignKey(
                        name: "FK_BookBookLoan_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBookLoan_BookLoans_BookLoanId",
                        column: x => x.BookLoanId,
                        principalTable: "BookLoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBookLoan",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    BookLoanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBookLoan", x => new { x.UserId, x.BookLoanId });
                    table.ForeignKey(
                        name: "FK_UserBookLoan_BookLoans_BookLoanId",
                        column: x => x.BookLoanId,
                        principalTable: "BookLoans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBookLoan_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBookLoan_BookLoanId",
                table: "BookBookLoan",
                column: "BookLoanId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBookLoan_BookLoanId",
                table: "UserBookLoan",
                column: "BookLoanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBookLoan");

            migrationBuilder.DropTable(
                name: "UserBookLoan");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "BookLoans");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
