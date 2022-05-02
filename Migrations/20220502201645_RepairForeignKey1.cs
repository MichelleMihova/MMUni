using Microsoft.EntityFrameworkCore.Migrations;

namespace MMUni.Migrations
{
    public partial class RepairForeignKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SkippingAssignments_LearningObjectId",
                table: "SkippingAssignments");

            migrationBuilder.CreateIndex(
                name: "IX_SkippingAssignments_LearningObjectId",
                table: "SkippingAssignments",
                column: "LearningObjectId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_SkippingAssignments_LearningObjectId",
                table: "SkippingAssignments");

            migrationBuilder.CreateIndex(
                name: "IX_SkippingAssignments_LearningObjectId",
                table: "SkippingAssignments",
                column: "LearningObjectId");
        }
    }
}
