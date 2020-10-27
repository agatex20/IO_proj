﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace IOWpf.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Balances",
                columns: table => new
                {
                    BalanceId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    curr_balance = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Balances", x => x.BalanceId);
                });

            migrationBuilder.CreateTable(
                name: "Piggy_Banks",
                columns: table => new
                {
                    Piggy_bankId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    creator_name = table.Column<string>(nullable: true),
                    goal = table.Column<float>(nullable: false),
                    goal_date = table.Column<string>(nullable: true),
                    goal_namel = table.Column<string>(nullable: true),
                    if_childs = table.Column<bool>(nullable: false),
                    monthly_income = table.Column<float>(nullable: false),
                    start_day = table.Column<int>(nullable: false),
                    treasured_amount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Piggy_Banks", x => x.Piggy_bankId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    BalanceId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Balances_BalanceId",
                        column: x => x.BalanceId,
                        principalTable: "Balances",
                        principalColumn: "BalanceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Expenses",
                columns: table => new
                {
                    ExpenseId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    amount = table.Column<float>(nullable: false),
                    creator_name = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    if_childs = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true),
                    category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Expenses", x => x.ExpenseId);
                    table.ForeignKey(
                        name: "FK_Expenses_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Incomes",
                columns: table => new
                {
                    IncomeId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    amount = table.Column<float>(nullable: false),
                    creator_name = table.Column<string>(nullable: true),
                    date = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    if_childs = table.Column<bool>(nullable: false),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incomes", x => x.IncomeId);
                    table.ForeignKey(
                        name: "FK_Incomes_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User_Piggy_banks",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    Piggy_bankId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Piggy_banks", x => new { x.UserId, x.Piggy_bankId });
                    table.ForeignKey(
                        name: "FK_User_Piggy_banks_Piggy_Banks_Piggy_bankId",
                        column: x => x.Piggy_bankId,
                        principalTable: "Piggy_Banks",
                        principalColumn: "Piggy_bankId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Piggy_banks_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Expenses_UserId",
                table: "Expenses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Incomes_UserId",
                table: "Incomes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_User_BalanceId",
                table: "User",
                column: "BalanceId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Piggy_banks_Piggy_bankId",
                table: "User_Piggy_banks",
                column: "Piggy_bankId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Expenses");

            migrationBuilder.DropTable(
                name: "Incomes");

            migrationBuilder.DropTable(
                name: "User_Piggy_banks");

            migrationBuilder.DropTable(
                name: "Piggy_Banks");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Balances");
        }
    }
}