using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Panel.DAL.Migrations
{
    public partial class DbAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acquaintances",
                columns: table => new
                {
                    AcquaintanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcquaintanceDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acquaintances", x => x.AcquaintanceId);
                });

            migrationBuilder.CreateTable(
                name: "Conditions",
                columns: table => new
                {
                    ConditionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ConDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conditions", x => x.ConditionId);
                });

            migrationBuilder.CreateTable(
                name: "Terms",
                columns: table => new
                {
                    TermsAcceptanceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TermsAcceptanceDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Terms", x => x.TermsAcceptanceId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserPanelId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserPanelDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserPanelId);
                });

            migrationBuilder.CreateTable(
                name: "Panels",
                columns: table => new
                {
                    PanelSimorghId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    FName = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<int>(nullable: false),
                    PhoneCall = table.Column<int>(nullable: false),
                    NationalCode = table.Column<int>(nullable: false),
                    BirthNo = table.Column<int>(nullable: false),
                    PostalCode = table.Column<int>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    UserPanelId = table.Column<int>(nullable: true),
                    ConditionId = table.Column<int>(nullable: true),
                    acquaintanceTypeAcquaintanceId = table.Column<int>(nullable: true),
                    TermsAcceptanceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Panels", x => x.PanelSimorghId);
                    table.ForeignKey(
                        name: "FK_Panels_Conditions_ConditionId",
                        column: x => x.ConditionId,
                        principalTable: "Conditions",
                        principalColumn: "ConditionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panels_Terms_TermsAcceptanceId",
                        column: x => x.TermsAcceptanceId,
                        principalTable: "Terms",
                        principalColumn: "TermsAcceptanceId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panels_users_UserPanelId",
                        column: x => x.UserPanelId,
                        principalTable: "users",
                        principalColumn: "UserPanelId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Panels_Acquaintances_acquaintanceTypeAcquaintanceId",
                        column: x => x.acquaintanceTypeAcquaintanceId,
                        principalTable: "Acquaintances",
                        principalColumn: "AcquaintanceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Panels_ConditionId",
                table: "Panels",
                column: "ConditionId");

            migrationBuilder.CreateIndex(
                name: "IX_Panels_TermsAcceptanceId",
                table: "Panels",
                column: "TermsAcceptanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Panels_UserPanelId",
                table: "Panels",
                column: "UserPanelId");

            migrationBuilder.CreateIndex(
                name: "IX_Panels_acquaintanceTypeAcquaintanceId",
                table: "Panels",
                column: "acquaintanceTypeAcquaintanceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Panels");

            migrationBuilder.DropTable(
                name: "Conditions");

            migrationBuilder.DropTable(
                name: "Terms");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "Acquaintances");
        }
    }
}
