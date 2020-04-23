using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FundooRepository.Migrations
{
    public partial class Fundoo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accountregister",
                columns: table => new
                {
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accountregister", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Collaborators",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SenderEmail = table.Column<string>(nullable: true),
                    ReceiverEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Collaborators", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "labels",
                columns: table => new
                {
                    LabelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NoteId = table.Column<int>(nullable: false),
                    LabelName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_labels", x => x.LabelId);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Trash = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Createdate1 = table.Column<DateTime>(nullable: true),
                    Modifieddate = table.Column<DateTime>(nullable: true),
                    Archeive = table.Column<bool>(nullable: false),
                    Pin = table.Column<bool>(nullable: false),
                    ChangeColor = table.Column<string>(nullable: true),
                    AddImg = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Reminder = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accountregister");

            migrationBuilder.DropTable(
                name: "Collaborators");

            migrationBuilder.DropTable(
                name: "labels");

            migrationBuilder.DropTable(
                name: "Notes");
        }
    }
}
