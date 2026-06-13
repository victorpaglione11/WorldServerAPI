using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace WorldServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PlayerAndMinorChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_entity_races",
                table: "entity_races");

            migrationBuilder.DropColumn(
                name: "agility",
                table: "entity_races");

            migrationBuilder.RenameTable(
                name: "entity_races",
                newName: "races");

            migrationBuilder.RenameColumn(
                name: "vitality",
                table: "races",
                newName: "charm");

            migrationBuilder.RenameIndex(
                name: "IX_entity_races_Name",
                table: "races",
                newName: "IX_races_Name");

            migrationBuilder.AddPrimaryKey(
                name: "PK_races",
                table: "races",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "players",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    charm = table.Column<int>(type: "integer", nullable: false),
                    dexterity = table.Column<int>(type: "integer", nullable: false),
                    intelligence = table.Column<int>(type: "integer", nullable: false),
                    luck = table.Column<int>(type: "integer", nullable: false),
                    perception = table.Column<int>(type: "integer", nullable: false),
                    strength = table.Column<int>(type: "integer", nullable: false),
                    current_health = table.Column<int>(type: "integer", nullable: false),
                    current_mana = table.Column<int>(type: "integer", nullable: false),
                    max_health = table.Column<int>(type: "integer", nullable: false),
                    max_mana = table.Column<int>(type: "integer", nullable: false),
                    Prefab = table.Column<string>(type: "text", nullable: false),
                    ChunkX = table.Column<int>(type: "integer", nullable: false),
                    ChunkY = table.Column<int>(type: "integer", nullable: false),
                    LocalX = table.Column<float>(type: "real", nullable: false),
                    LocalY = table.Column<float>(type: "real", nullable: false),
                    LocalZ = table.Column<float>(type: "real", nullable: false),
                    BaseName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Tier = table.Column<int>(type: "integer", nullable: false),
                    RaceID = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_players_races_RaceID",
                        column: x => x.RaceID,
                        principalTable: "races",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_players_RaceID",
                table: "players",
                column: "RaceID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_races",
                table: "races");

            migrationBuilder.RenameTable(
                name: "races",
                newName: "entity_races");

            migrationBuilder.RenameColumn(
                name: "charm",
                table: "entity_races",
                newName: "vitality");

            migrationBuilder.RenameIndex(
                name: "IX_races_Name",
                table: "entity_races",
                newName: "IX_entity_races_Name");

            migrationBuilder.AddColumn<int>(
                name: "agility",
                table: "entity_races",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_entity_races",
                table: "entity_races",
                column: "Id");
        }
    }
}
