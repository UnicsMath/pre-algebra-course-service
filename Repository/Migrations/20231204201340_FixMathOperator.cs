using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    /// <inheritdoc />
    public partial class FixMathOperator : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChapterModelOperatorModel_Operators_OperatorsMathOperator",
                table: "ChapterModelOperatorModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operators",
                table: "Operators");

            migrationBuilder.RenameColumn(
                name: "OperatorsMathOperator",
                table: "ChapterModelOperatorModel",
                newName: "OperatorsMathOperatorId");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterModelOperatorModel_OperatorsMathOperator",
                table: "ChapterModelOperatorModel",
                newName: "IX_ChapterModelOperatorModel_OperatorsMathOperatorId");

            migrationBuilder.AlterColumn<string>(
                name: "MathOperator",
                table: "Operators",
                type: "text",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AddColumn<byte>(
                name: "MathOperatorId",
                table: "Operators",
                type: "smallint",
                nullable: false,
                defaultValue: (byte)0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operators",
                table: "Operators",
                column: "MathOperatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterModelOperatorModel_Operators_OperatorsMathOperatorId",
                table: "ChapterModelOperatorModel",
                column: "OperatorsMathOperatorId",
                principalTable: "Operators",
                principalColumn: "MathOperatorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ChapterModelOperatorModel_Operators_OperatorsMathOperatorId",
                table: "ChapterModelOperatorModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Operators",
                table: "Operators");

            migrationBuilder.DropColumn(
                name: "MathOperatorId",
                table: "Operators");

            migrationBuilder.RenameColumn(
                name: "OperatorsMathOperatorId",
                table: "ChapterModelOperatorModel",
                newName: "OperatorsMathOperator");

            migrationBuilder.RenameIndex(
                name: "IX_ChapterModelOperatorModel_OperatorsMathOperatorId",
                table: "ChapterModelOperatorModel",
                newName: "IX_ChapterModelOperatorModel_OperatorsMathOperator");

            migrationBuilder.AlterColumn<byte>(
                name: "MathOperator",
                table: "Operators",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Operators",
                table: "Operators",
                column: "MathOperator");

            migrationBuilder.AddForeignKey(
                name: "FK_ChapterModelOperatorModel_Operators_OperatorsMathOperator",
                table: "ChapterModelOperatorModel",
                column: "OperatorsMathOperator",
                principalTable: "Operators",
                principalColumn: "MathOperator",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
