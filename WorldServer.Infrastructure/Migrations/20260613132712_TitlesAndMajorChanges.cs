using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using WorldServer.Domain.Entities.AbstractEntities;

#nullable disable

namespace WorldServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TitlesAndMajorChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ActiveTitleId",
                table: "players",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "titles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Title = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    Rank = table.Column<int>(type: "integer", nullable: false),
                    Modifiers = table.Column<List<EntityModifier>>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "player_titles",
                columns: table => new
                {
                    PlayerId = table.Column<long>(type: "bigint", nullable: false),
                    TitleId = table.Column<Guid>(type: "uuid", nullable: false),
                    AchievedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_player_titles", x => new { x.PlayerId, x.TitleId });
                    table.ForeignKey(
                        name: "FK_player_titles_players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_player_titles_titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_players_ActiveTitleId",
                table: "players",
                column: "ActiveTitleId");

            migrationBuilder.CreateIndex(
                name: "IX_players_ChunkX_ChunkY",
                table: "players",
                columns: new[] { "ChunkX", "ChunkY" });

            migrationBuilder.CreateIndex(
                name: "IX_player_titles_TitleId",
                table: "player_titles",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_titles_Code",
                table: "titles",
                column: "Code",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_players_titles_ActiveTitleId",
                table: "players",
                column: "ActiveTitleId",
                principalTable: "titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_players_titles_ActiveTitleId",
                table: "players");

            migrationBuilder.DropTable(
                name: "player_titles");

            migrationBuilder.DropTable(
                name: "titles");

            migrationBuilder.DropIndex(
                name: "IX_players_ActiveTitleId",
                table: "players");

            migrationBuilder.DropIndex(
                name: "IX_players_ChunkX_ChunkY",
                table: "players");

            migrationBuilder.DropColumn(
                name: "ActiveTitleId",
                table: "players");
        }
    }
}
