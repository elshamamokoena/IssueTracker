using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace IssueTracker.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Issues",
                columns: table => new
                {
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnerId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Resolved = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IssueType = table.Column<int>(type: "int", nullable: false),
                    Severity = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftwareId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoftwareComponentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SoftwarePackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Issues", x => x.IssueId);
                });

            migrationBuilder.CreateTable(
                name: "AffectedPlatforms",
                columns: table => new
                {
                    AffectedPlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssuePlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlatformId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AffectedPlatforms", x => x.AffectedPlatformId);
                    table.ForeignKey(
                        name: "FK_AffectedPlatforms_Issues_IssueId",
                        column: x => x.IssueId,
                        principalTable: "Issues",
                        principalColumn: "IssueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    AttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attachments", x => x.AttachmentId);
                    table.ForeignKey(
                        name: "FK_Attachments_Issues_IssueId",
                        column: x => x.IssueId,
                        principalTable: "Issues",
                        principalColumn: "IssueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IssueSymptomRecords",
                columns: table => new
                {
                    IssueSymptomRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SymptomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IssueSymptomRecords", x => x.IssueSymptomRecordId);
                    table.ForeignKey(
                        name: "FK_IssueSymptomRecords_Issues_IssueId",
                        column: x => x.IssueId,
                        principalTable: "Issues",
                        principalColumn: "IssueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RelatedIssueRecords",
                columns: table => new
                {
                    RelatedIssueRecordId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RelatedIssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelatedIssueRecords", x => x.RelatedIssueRecordId);
                    table.ForeignKey(
                        name: "FK_RelatedIssueRecords_Issues_IssueId",
                        column: x => x.IssueId,
                        principalTable: "Issues",
                        principalColumn: "IssueId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Issues",
                columns: new[] { "IssueId", "AuthorId", "Created", "CreatedBy", "Description", "IssueType", "LastModified", "LastModifiedBy", "OwnerId", "Priority", "Resolved", "Severity", "SoftwareComponentId", "SoftwareId", "SoftwarePackageId", "Status", "Summary" },
                values: new object[,]
                {
                    { new Guid("a1788d2f-8003-43c1-92a4-edc76a7c5dde"), "A2788D2F-8003-43C1-92A4-EDC76A7C5DDE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "The clients app has crashed. The issue is with the EC2 instance that keeps stopping for no clear reason.", 3, null, null, "A30788D2F-8003-43C1-92A4-EDC76A7C5DDE", 2, null, 1, null, null, null, 0, "The EC2 instance just stopped." },
                    { new Guid("a4788d2f-8003-43c1-92a4-edc76a7c5dde"), "A5788D2F-8003-43C1-92A4-EDC76A7C5DDE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Add shopping cart feature to the app for Mariams's biscuits", 2, null, null, "A6788D2F-8003-43C1-92A4-EDC76A7C5DDE", 0, new DateTime(2025, 4, 19, 23, 43, 31, 271, DateTimeKind.Local).AddTicks(1821), 3, null, null, null, 2, "Call the client." },
                    { new Guid("b0788d2f-8003-43c1-92a4-edc76a7c5dde"), "A0788D2F-8003-43C1-92A4-EDC76A7C5DDE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Add shopping cart feature to the app for Mariams's biscuits.", 1, null, null, "C0788D2F-8003-43C1-92A4-EDC76A7C5DDE", 1, new DateTime(2025, 4, 19, 23, 43, 31, 271, DateTimeKind.Local).AddTicks(1751), 3, null, null, null, 2, "The feature has been added." },
                    { new Guid("d0788d2f-8003-43c1-92a4-edc76a7c5dde"), "E0788D2F-8003-43C1-92A4-EDC76A7C5DDE", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Add documentation for the new shopping cart feature.", 6, null, null, "F0788D2F-8003-43C1-92A4-EDC76A7C5DDE", 1, null, 3, null, null, null, 1, "Docs almost complete." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AffectedPlatforms_IssueId",
                table: "AffectedPlatforms",
                column: "IssueId");

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_IssueId",
                table: "Attachments",
                column: "IssueId");

            migrationBuilder.CreateIndex(
                name: "IX_IssueSymptomRecords_IssueId",
                table: "IssueSymptomRecords",
                column: "IssueId");

            migrationBuilder.CreateIndex(
                name: "IX_RelatedIssueRecords_IssueId",
                table: "RelatedIssueRecords",
                column: "IssueId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AffectedPlatforms");

            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DropTable(
                name: "IssueSymptomRecords");

            migrationBuilder.DropTable(
                name: "RelatedIssueRecords");

            migrationBuilder.DropTable(
                name: "Issues");
        }
    }
}
