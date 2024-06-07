using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace First_API_beta2.Migrations
{
    /// <inheritdoc />
    public partial class Try2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MechaniсWorkTypes",
                table: "MechaniсWorkTypes");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "UserRoles",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "MechaniсWorkTypes",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MechaniсWorkTypes",
                table: "MechaniсWorkTypes",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MechaniсWorkTypes_MechanicId",
                table: "MechaniсWorkTypes",
                column: "MechanicId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles");

            migrationBuilder.DropIndex(
                name: "IX_UserRoles_UserId",
                table: "UserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MechaniсWorkTypes",
                table: "MechaniсWorkTypes");

            migrationBuilder.DropIndex(
                name: "IX_MechaniсWorkTypes_MechanicId",
                table: "MechaniсWorkTypes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "UserRoles");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "MechaniсWorkTypes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserRoles",
                table: "UserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MechaniсWorkTypes",
                table: "MechaniсWorkTypes",
                columns: new[] { "MechanicId", "WorkTypeId" });
        }
    }
}
