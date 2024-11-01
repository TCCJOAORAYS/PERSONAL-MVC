using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Personal.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NomeAux = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Titulo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tipo = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Imagem = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImagemAux = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Icon = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Info = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tabela = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Exercises",
                columns: new[] { "Id", "Descricao", "Icon", "Imagem", "ImagemAux", "Info", "Nome", "NomeAux", "Tabela", "Tipo", "Titulo" },
                values: new object[,]
                {
                    { 1, "Um Dos Principais Problemas Associados Ao Envelhecimento Humano É A Redução Da Habilidade Para Controlar A Postura E A Marcha, Podendo Levar À Ocorrência De Quedas, Diminuindo, Assim, A Capacidade Funcional Dos Idosos.", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/alongamentoicone.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/freemann.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/alongamento.jpg", "[\"Sem Oscilar\",\"Em Apoio Unipodal\",\"Olhos Fechados\",\"As M\\u00E3os Para Baixo\"]", "Teste de Freeman-Romberg Apoio Unipodal Com Olhos Fechados", "Teste De Freeman-Romberg", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/tabelas/1.png", "Primeiro Teste Rápido", "Cronometrar Quanto Tempo O Indivíduo Permanece" },
                    { 2, "Para realizar o teste como descrito na versão original, o Testado é cronometrado enquanto se levanta de uma cadeira (aproximadamente 46cm), caminha em uma linha reta de 3metros de distância (em um ritmo confortável e seguro), vira, caminha de volta e senta-se sobre a cadeira novamente.", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/doricone.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/tug.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/doreslocais.jpg", "[\"\\u00C9 aconselhado que o individuo fa\\u00E7a o percurso para se familiarizar com o teste antes de inici\\u00E1-lo.\",\"Usar o cal\\u00E7ado habitual e apoio para caminhar (bengala, andador) se necess\\u00E1rio.\"]", "Teste de tug: Timed up and Go Test", "Teste De Tug", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/tabelas/2.png", "Segundo Teste Rápido", "Avaliação funcional: Timed Up and Go test" },
                    { 3, "Instrumentos: cadeira com braços, fita métrica, 2 cones e cronômetro. Organização do teste: cadeira em local demarcado e local para os pés tocarem o solo. Dois cones posicionados a 1,50m para trás e 1,80m para cada lado (Figura). Posição do avaliado: sentado na cadeira com os pés (calcanhares) tocando o solo. Posição do avaliador: próximo ao avaliado.", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/musculacaoicone.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/equilibrio.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/massamuscular.jpg", "[\"Determinar um programa de treinamento especifico de equil\\u00EDbrio para reduzir quedas.\",\"Examinar os efeitos de exerc\\u00EDcios de equil\\u00EDbrio na propriocep\\u00E7\\u00E3o de idosos.\",\"Verificar o efeito de um programa de treinamento de equil\\u00EDbrio, de curto e longo per\\u00EDodo, em idosos.\",\"Estudar a efic\\u00E1cia dos exerc\\u00EDcios de equil\\u00EDbrio, realizadas em casa.\"]", "Teste de agilidade e equilíbrio dinâmico", "Agilidade E Equilíbrio Dinâmico", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/tabelas/3.png", "Terceiro Teste Rápido", "Quais os objetivos dos testes?" },
                    { 4, "Caminhar de maneira normal entre os cones que formam a base do quadrado. Caminhe até o outro cone posicionado na diagonal, conseguindo passar pelos 4 cones e finalizando o percurso. Os testes devem ser realizados quatro vezes sendo uma como reconhecimento e as outras três válidas ,tentando fazer no menor tempo.", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/alongamentoicone.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/deslocamento.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/deslocamento.jpg", "[\"Posicione os 4 cones em dist\\u00E2ncia de aproximadamente de 3 a 4 metros formando um quadrado.\"]", "Deslocamento em quadrado", "Agilidade E Equilíbrio Dinâmico", null, "Quarto Teste Rápido", "Quais os objetivos dos testes?" },
                    { 5, "Organização do teste: cadeira em local demarcado e local para os pés tocarem o solo. Dois cones posicionados a 1,50m para trás e 1,80m para cada lado (Figura). Posição do avaliado: sentado na cadeira com os pés (calcanhares) tocando o solo. Posição do avaliador: próximo ao avaliado.", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/icons/doricone.png", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/testes/agachamento.jpeg", "https://raw.githubusercontent.com/TCCJOAORAYS/IMAGENS/main/img/exercicios/agachamentomulher.jpg", "[\"Instrumentos: cadeira com bra\\u00E7os, fita m\\u00E9trica, 2 cones e cron\\u00F4metro.\"]", "Agachamento com cadeira", "Força e resistencia", null, "Quinto Teste Rápido", "Quais os objetivos dos testes?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Exercises");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
