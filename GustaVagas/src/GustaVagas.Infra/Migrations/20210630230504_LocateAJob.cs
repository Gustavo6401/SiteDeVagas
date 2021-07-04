using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GustaVagas.Infra.Migrations
{
    public partial class LocateAJob : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Area",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameArea = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Area", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdArea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cargo_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AreaUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AreaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    AreaId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AreaUser_Area_AreaId1",
                        column: x => x.AreaId1,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AreaUser_Usuario_UserId1",
                        column: x => x.UserId1,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidate",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(90)", maxLength: 90, nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TelefoneFixo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    Instagram = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Github = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YouTube = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RG = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstáContratado = table.Column<bool>(type: "bit", nullable: false),
                    DescricaoCandidato = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empresa = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Escolaridade = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstadoCivil = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Sexo = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Senioridade = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: false),
                    PretencaoSalarialMinima = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PretencaoSalarialMaxima = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidate_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Enterprise",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Telefone = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    Celular = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CNPJ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rua = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    País = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Enterprise", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Enterprise_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CargoUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CargoUser_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CargoUser_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Formacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TipoEnsino = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Grau = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Insituicao = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: true),
                    IdCandidato = table.Column<int>(type: "int", nullable: false),
                    CandidateId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Formacao_Candidate_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: true),
                    PessoaJuridica = table.Column<bool>(type: "bit", nullable: false),
                    TemCliente = table.Column<bool>(type: "bit", nullable: false),
                    Cliente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comeco = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Fim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EmpresaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUsuario = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Candidate_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Project_Enterprise_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vaga",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumeroVagas = table.Column<int>(type: "int", nullable: false),
                    Senioridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Escolaridade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoVaga = table.Column<int>(type: "int", nullable: false),
                    LocalEntrevista = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remoto = table.Column<bool>(type: "bit", nullable: false),
                    Temporario = table.Column<bool>(type: "bit", nullable: false),
                    Freelance = table.Column<bool>(type: "bit", nullable: false),
                    PessoaJuridica = table.Column<bool>(type: "bit", nullable: false),
                    EnterpriseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CargoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AreaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdEnterprise = table.Column<int>(type: "int", nullable: false),
                    IdCargo = table.Column<int>(type: "int", nullable: false),
                    IdArea = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaga", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vaga_Area_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Area",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vaga_Cargo_CargoId",
                        column: x => x.CargoId,
                        principalTable: "Cargo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Vaga_Enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "Enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Candidatura",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdVaga = table.Column<int>(type: "int", nullable: false),
                    IdOferecedor = table.Column<int>(type: "int", nullable: false),
                    IdCandidato = table.Column<int>(type: "int", nullable: false),
                    ParaPJ = table.Column<bool>(type: "bit", nullable: false),
                    DePJ = table.Column<bool>(type: "bit", nullable: false),
                    VagaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CandidatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OferecedorPFId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EnterpriseId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CandidatoPJId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidatura", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Candidatura_Candidate_CandidatoId",
                        column: x => x.CandidatoId,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Candidate_OferecedorPFId",
                        column: x => x.OferecedorPFId,
                        principalTable: "Candidate",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Enterprise_CandidatoPJId",
                        column: x => x.CandidatoPJId,
                        principalTable: "Enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Enterprise_EnterpriseId",
                        column: x => x.EnterpriseId,
                        principalTable: "Enterprise",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Candidatura_Vaga_VagaId",
                        column: x => x.VagaId,
                        principalTable: "Vaga",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AreaUser_AreaId1",
                table: "AreaUser",
                column: "AreaId1");

            migrationBuilder.CreateIndex(
                name: "IX_AreaUser_UserId1",
                table: "AreaUser",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "IX_Candidate_UsuarioId",
                table: "Candidate",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_CandidatoId",
                table: "Candidatura",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_CandidatoPJId",
                table: "Candidatura",
                column: "CandidatoPJId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_EnterpriseId",
                table: "Candidatura",
                column: "EnterpriseId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_OferecedorPFId",
                table: "Candidatura",
                column: "OferecedorPFId");

            migrationBuilder.CreateIndex(
                name: "IX_Candidatura_VagaId",
                table: "Candidatura",
                column: "VagaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cargo_AreaId",
                table: "Cargo",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoUser_CandidateId",
                table: "CargoUser",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_CargoUser_CargoId",
                table: "CargoUser",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Enterprise_UsuarioId",
                table: "Enterprise",
                column: "UsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Formacao_CandidateId",
                table: "Formacao",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_AreaId",
                table: "Project",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_CandidatoId",
                table: "Project",
                column: "CandidatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_EmpresaId",
                table: "Project",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_AreaId",
                table: "Vaga",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_CargoId",
                table: "Vaga",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Vaga_EnterpriseId",
                table: "Vaga",
                column: "EnterpriseId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaUser");

            migrationBuilder.DropTable(
                name: "Candidatura");

            migrationBuilder.DropTable(
                name: "CargoUser");

            migrationBuilder.DropTable(
                name: "Formacao");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Vaga");

            migrationBuilder.DropTable(
                name: "Candidate");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Enterprise");

            migrationBuilder.DropTable(
                name: "Area");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
