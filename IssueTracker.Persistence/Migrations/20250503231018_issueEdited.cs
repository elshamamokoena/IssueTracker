using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IssueTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class issueEdited : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 5, 4, 1, 10, 17, 739, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 5, 4, 1, 10, 17, 739, DateTimeKind.Local).AddTicks(1265));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 28, 13, 53, 29, 941, DateTimeKind.Local).AddTicks(9933));

            migrationBuilder.UpdateData(
                table: "Issues",
                keyColumn: "IssueId",
                keyValue: new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"),
                column: "Resolved",
                value: new DateTime(2025, 4, 28, 13, 53, 29, 941, DateTimeKind.Local).AddTicks(9827));
        }
    }
}
