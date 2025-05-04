using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IssueTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryId",
                table: "Issues",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Created", "CreatedBy", "Description", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { new Guid("b0788d2f-8003-43c1-92a4-edc7617c5dde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, null, "Helpdesk" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, null, "General Issue" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76c7c5dde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, null, "Maintenance" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76d7c5dde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, null, "Engineering" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76e7c5dde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, null, "Accounts" },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76f7c5dde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "", null, null, "Feedback" }
                });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a1788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "CategoryId",
                value: new Guid("b0788d2f-8003-43c1-92a4-edc76b7c5dde"));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "CategoryId", "Resolved" },
                values: new object[] { new Guid("b0788d2f-8003-43c1-92a4-edc76c7c5dde"), new DateTime(2025, 4, 28, 13, 53, 29, 941, DateTimeKind.Local).AddTicks(9933) });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                columns: new[] { "CategoryId", "Resolved" },
                values: new object[] { new Guid("b0788d2f-8003-43c1-92a4-edc76c7c5dde"), new DateTime(2025, 4, 28, 13, 53, 29, 941, DateTimeKind.Local).AddTicks(9827) });

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("d0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "CategoryId",
                value: new Guid("b0788d2f-8003-43c1-92a4-edc76d7c5dde"));

            migrationBuilder.CreateIndex(
                name: "IX_Issues_CategoryId",
                table: "Issues",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Issues_Categories_CategoryId",
                table: "Issues",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Issues_Categories_CategoryId",
                table: "Issues");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Issues_CategoryId",
                table: "Issues");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Issues");

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 23, 0, 11, 51, 495, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 23, 0, 11, 51, 495, DateTimeKind.Local).AddTicks(2631));
        }
    }
}
