using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class attachmentModified : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Attachments");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FileUrl",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 22, 19, 51, 16, 855, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 22, 19, 51, 16, 855, DateTimeKind.Local).AddTicks(4369));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "FileUrl",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Attachments");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Attachments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 19, 23, 43, 31, 271, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 19, 23, 43, 31, 271, DateTimeKind.Local).AddTicks(1751));
        }
    }
}
