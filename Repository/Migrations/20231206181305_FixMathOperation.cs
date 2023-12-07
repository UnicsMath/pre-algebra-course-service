#nullable disable

using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class FixMathOperation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChapterModelOperatorModel");

            migrationBuilder.DropTable(
                name: "Operators");

            migrationBuilder.CreateTable(
                name: "Operations",
                columns: table => new
                {
                    MathOperationId = table.Column<byte>(type: "smallint", nullable: false),
                    MathOperation = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operations", x => x.MathOperationId);
                });

            migrationBuilder.CreateTable(
                name: "ChapterModelOperationModel",
                columns: table => new
                {
                    ChapterModelChapterId = table.Column<int>(type: "integer", nullable: false),
                    OperationsMathOperationId = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterModelOperationModel", x => new { x.ChapterModelChapterId, x.OperationsMathOperationId });
                    table.ForeignKey(
                        name: "FK_ChapterModelOperationModel_Chapters_ChapterModelChapterId",
                        column: x => x.ChapterModelChapterId,
                        principalTable: "Chapters",
                        principalColumn: "ChapterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChapterModelOperationModel_Operations_OperationsMathOperati~",
                        column: x => x.OperationsMathOperationId,
                        principalTable: "Operations",
                        principalColumn: "MathOperationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChapterModelOperationModel_OperationsMathOperationId",
                table: "ChapterModelOperationModel",
                column: "OperationsMathOperationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChapterModelOperationModel");

            migrationBuilder.DropTable(
                name: "Operations");

            migrationBuilder.CreateTable(
                name: "Operators",
                columns: table => new
                {
                    MathOperatorId = table.Column<byte>(type: "smallint", nullable: false),
                    MathOperator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operators", x => x.MathOperatorId);
                });

            migrationBuilder.CreateTable(
                name: "ChapterModelOperatorModel",
                columns: table => new
                {
                    ChapterModelChapterId = table.Column<int>(type: "integer", nullable: false),
                    OperatorsMathOperatorId = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChapterModelOperatorModel", x => new { x.ChapterModelChapterId, x.OperatorsMathOperatorId });
                    table.ForeignKey(
                        name: "FK_ChapterModelOperatorModel_Chapters_ChapterModelChapterId",
                        column: x => x.ChapterModelChapterId,
                        principalTable: "Chapters",
                        principalColumn: "ChapterId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChapterModelOperatorModel_Operators_OperatorsMathOperatorId",
                        column: x => x.OperatorsMathOperatorId,
                        principalTable: "Operators",
                        principalColumn: "MathOperatorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChapterModelOperatorModel_OperatorsMathOperatorId",
                table: "ChapterModelOperatorModel",
                column: "OperatorsMathOperatorId");
        }
    }
}
