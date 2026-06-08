using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace G_NET_18_EFCore02.Migrations
{
    /// <inheritdoc />
    public partial class AddEventSessionsRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentEventId",
                table: "Events",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Events_ParentEventId",
                table: "Events",
                column: "ParentEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_Events_ParentEventId",
                table: "Events",
                column: "ParentEventId",
                principalTable: "Events",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_Events_ParentEventId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_ParentEventId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "ParentEventId",
                table: "Events");
        }
    }
}
