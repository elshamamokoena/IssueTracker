using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class attachmentModified2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RelatedIssueRecords",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "RelatedIssueRecords");

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
    }
}
