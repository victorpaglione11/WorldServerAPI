using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using WorldServer.Domain.Entities.AbstractEntities;

#nullable disable

namespace WorldServer.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AtivePassiveEffects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "titles",
                newName: "TitleName");

            migrationBuilder.RenameColumn(
                name: "Modifiers",
                table: "titles",
                newName: "StatusEffectIds");

            migrationBuilder.CreateTable(
                name: "status_effects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    HasVisualEffect = table.Column<bool>(type: "boolean", nullable: false),
                    Modifiers = table.Column<List<EntityModifier>>(type: "jsonb", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_status_effects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "active_effects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TargetId = table.Column<long>(type: "bigint", nullable: false),
                    StatusEffectId = table.Column<Guid>(type: "uuid", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_active_effects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_active_effects_status_effects_StatusEffectId",
                        column: x => x.StatusEffectId,
                        principalTable: "status_effects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_active_effects_ExpiresAt",
                table: "active_effects",
                column: "ExpiresAt");

            migrationBuilder.CreateIndex(
                name: "IX_active_effects_StatusEffectId",
                table: "active_effects",
                column: "StatusEffectId");

            migrationBuilder.CreateIndex(
                name: "IX_active_effects_TargetId",
                table: "active_effects",
                column: "TargetId");

            migrationBuilder.CreateIndex(
                name: "IX_status_effects_Code",
                table: "status_effects",
                column: "Code",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "active_effects");

            migrationBuilder.DropTable(
                name: "status_effects");

            migrationBuilder.RenameColumn(
                name: "TitleName",
                table: "titles",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "StatusEffectIds",
                table: "titles",
                newName: "Modifiers");
        }
    }
}
