using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_NET_18_EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class AddAttendeeBadgeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AttendeeId",
                table: "Badges",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Badges_AttendeeId",
                table: "Badges",
                column: "AttendeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Badges_Attendees_AttendeeId",
                table: "Badges",
                column: "AttendeeId",
                principalTable: "Attendees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Badges_Attendees_AttendeeId",
                table: "Badges");

            migrationBuilder.DropIndex(
                name: "IX_Badges_AttendeeId",
                table: "Badges");

            migrationBuilder.DropColumn(
                name: "AttendeeId",
                table: "Badges");
        }
    }
}
