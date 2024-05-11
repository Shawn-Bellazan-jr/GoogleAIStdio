using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GoogleAIStudio.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStructuredPromptDesign : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_FreeformPrompts_ChatPromptId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_PromptField_FreeformPrompts_StructuredPromptId",
                table: "PromptField");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "PromptField");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "FreeformPrompts");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "FreeformPrompts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ChatMessage",
                newName: "Name");

            migrationBuilder.AlterColumn<string>(
                name: "StructuredPromptId",
                table: "PromptField",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "ChatMessage",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "ChatPrompts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatPrompts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StructuredPrompts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StructuredPrompts", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_ChatPrompts_ChatPromptId",
                table: "ChatMessage",
                column: "ChatPromptId",
                principalTable: "ChatPrompts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PromptField_StructuredPrompts_StructuredPromptId",
                table: "PromptField",
                column: "StructuredPromptId",
                principalTable: "StructuredPrompts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChatMessage_ChatPrompts_ChatPromptId",
                table: "ChatMessage");

            migrationBuilder.DropForeignKey(
                name: "FK_PromptField_StructuredPrompts_StructuredPromptId",
                table: "PromptField");

            migrationBuilder.DropTable(
                name: "ChatPrompts");

            migrationBuilder.DropTable(
                name: "StructuredPrompts");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "ChatMessage");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "FreeformPrompts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ChatMessage",
                newName: "Title");

            migrationBuilder.AlterColumn<string>(
                name: "StructuredPromptId",
                table: "PromptField",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "PromptField",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "FreeformPrompts",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_ChatMessage_FreeformPrompts_ChatPromptId",
                table: "ChatMessage",
                column: "ChatPromptId",
                principalTable: "FreeformPrompts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PromptField_FreeformPrompts_StructuredPromptId",
                table: "PromptField",
                column: "StructuredPromptId",
                principalTable: "FreeformPrompts",
                principalColumn: "Id");
        }
    }
}
