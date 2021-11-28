using Microsoft.EntityFrameworkCore.Migrations;

namespace E_Migrant.App.Persistencia.Migrations
{
    public partial class bd1mp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AlojoPermanenteid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AlojoTemporalid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AyudaLegalid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Educacionid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Empleoid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Usuario",
                table: "Migrantes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "alimentacionid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "clave",
                table: "Migrantes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "saludid",
                table: "Migrantes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Alimentacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alimentacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AlojamientoPermanent",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlojamientoPermanent", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AlojamientoTemp",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlojamientoTemp", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "AyudaLegal",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AyudaLegal", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Educacion",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educacion", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Empleo",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidades = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleo", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Salud",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrioridadNecesidad = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salud", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_alimentacionid",
                table: "Migrantes",
                column: "alimentacionid");

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_AlojoPermanenteid",
                table: "Migrantes",
                column: "AlojoPermanenteid");

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_AlojoTemporalid",
                table: "Migrantes",
                column: "AlojoTemporalid");

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_AyudaLegalid",
                table: "Migrantes",
                column: "AyudaLegalid");

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_Educacionid",
                table: "Migrantes",
                column: "Educacionid");

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_Empleoid",
                table: "Migrantes",
                column: "Empleoid");

            migrationBuilder.CreateIndex(
                name: "IX_Migrantes_saludid",
                table: "Migrantes",
                column: "saludid");

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_Alimentacion_alimentacionid",
                table: "Migrantes",
                column: "alimentacionid",
                principalTable: "Alimentacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_AlojamientoPermanent_AlojoPermanenteid",
                table: "Migrantes",
                column: "AlojoPermanenteid",
                principalTable: "AlojamientoPermanent",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_AlojamientoTemp_AlojoTemporalid",
                table: "Migrantes",
                column: "AlojoTemporalid",
                principalTable: "AlojamientoTemp",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_AyudaLegal_AyudaLegalid",
                table: "Migrantes",
                column: "AyudaLegalid",
                principalTable: "AyudaLegal",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_Educacion_Educacionid",
                table: "Migrantes",
                column: "Educacionid",
                principalTable: "Educacion",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_Empleo_Empleoid",
                table: "Migrantes",
                column: "Empleoid",
                principalTable: "Empleo",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Migrantes_Salud_saludid",
                table: "Migrantes",
                column: "saludid",
                principalTable: "Salud",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_Alimentacion_alimentacionid",
                table: "Migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_AlojamientoPermanent_AlojoPermanenteid",
                table: "Migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_AlojamientoTemp_AlojoTemporalid",
                table: "Migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_AyudaLegal_AyudaLegalid",
                table: "Migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_Educacion_Educacionid",
                table: "Migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_Empleo_Empleoid",
                table: "Migrantes");

            migrationBuilder.DropForeignKey(
                name: "FK_Migrantes_Salud_saludid",
                table: "Migrantes");

            migrationBuilder.DropTable(
                name: "Alimentacion");

            migrationBuilder.DropTable(
                name: "AlojamientoPermanent");

            migrationBuilder.DropTable(
                name: "AlojamientoTemp");

            migrationBuilder.DropTable(
                name: "AyudaLegal");

            migrationBuilder.DropTable(
                name: "Educacion");

            migrationBuilder.DropTable(
                name: "Empleo");

            migrationBuilder.DropTable(
                name: "Salud");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_alimentacionid",
                table: "Migrantes");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_AlojoPermanenteid",
                table: "Migrantes");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_AlojoTemporalid",
                table: "Migrantes");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_AyudaLegalid",
                table: "Migrantes");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_Educacionid",
                table: "Migrantes");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_Empleoid",
                table: "Migrantes");

            migrationBuilder.DropIndex(
                name: "IX_Migrantes_saludid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "AlojoPermanenteid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "AlojoTemporalid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "AyudaLegalid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "Educacionid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "Empleoid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "Usuario",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "alimentacionid",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "clave",
                table: "Migrantes");

            migrationBuilder.DropColumn(
                name: "saludid",
                table: "Migrantes");
        }
    }
}
