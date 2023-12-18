using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace cinema.Migrations
{
    /// <inheritdoc />
    public partial class Customer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    cus_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    cus_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    cus_phone = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    cus_gender = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    cus_email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    cus_dob = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    cus_type = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    cus_point = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.cus_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    dis_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    dis_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    dis_start = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dis_end = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    dis_percent = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.dis_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    mv_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    mv_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    mv_start = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    mv_end = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    mv_duration = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    mv_restrict = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    mv_cap = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    mv_link_poster = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    mv_link_trailer = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    mv_detail = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.mv_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "MovieTypes",
                columns: table => new
                {
                    type_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    type_name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieTypes", x => x.type_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    r_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    r_capacity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.r_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Years",
                columns: table => new
                {
                    yre_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    yre_year = table.Column<int>(type: "int", nullable: false),
                    yre_count = table.Column<int>(type: "int", nullable: false),
                    yre_value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Years", x => x.yre_id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    cus_email = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    c_pass = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    c_role = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.cus_email);
                    table.ForeignKey(
                        name: "FK_Accounts_Customers_cus_email",
                        column: x => x.cus_email,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bills",
                columns: table => new
                {
                    bi_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    cus_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    bi_date = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    tk_count = table.Column<int>(type: "int", nullable: false),
                    bi_value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bills", x => x.bi_id);
                    table.ForeignKey(
                        name: "FK_Bills_Customers_cus_id",
                        column: x => x.cus_id,
                        principalTable: "Customers",
                        principalColumn: "cus_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ChooseTypes",
                columns: table => new
                {
                    type_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    mv_id = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChooseTypes", x => new { x.type_id, x.mv_id });
                    table.ForeignKey(
                        name: "FK_ChooseTypes_MovieTypes_type_id",
                        column: x => x.type_id,
                        principalTable: "MovieTypes",
                        principalColumn: "type_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChooseTypes_Movies_mv_id",
                        column: x => x.mv_id,
                        principalTable: "Movies",
                        principalColumn: "mv_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    st_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    r_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    st_type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => new { x.st_id, x.r_id });
                    table.ForeignKey(
                        name: "FK_Seats_Rooms_r_id",
                        column: x => x.r_id,
                        principalTable: "Rooms",
                        principalColumn: "r_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Slots",
                columns: table => new
                {
                    sl_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    r_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    mv_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sl_duration = table.Column<TimeSpan>(type: "time(6)", nullable: false),
                    sl_start = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    sl_end = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    sl_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Slots", x => new { x.sl_id, x.r_id, x.mv_id });
                    table.ForeignKey(
                        name: "FK_Slots_Movies_mv_id",
                        column: x => x.mv_id,
                        principalTable: "Movies",
                        principalColumn: "mv_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Slots_Rooms_r_id",
                        column: x => x.r_id,
                        principalTable: "Rooms",
                        principalColumn: "r_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Months",
                columns: table => new
                {
                    mre_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    mre_yre_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    mre_month = table.Column<int>(type: "int", nullable: false),
                    mre_count = table.Column<int>(type: "int", nullable: false),
                    mre_value = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Months", x => new { x.mre_id, x.mre_yre_id });
                    table.ForeignKey(
                        name: "FK_Months_Years_mre_yre_id",
                        column: x => x.mre_yre_id,
                        principalTable: "Years",
                        principalColumn: "yre_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ApplyDiscounts",
                columns: table => new
                {
                    dis_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    bi_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplyDiscounts", x => new { x.dis_id, x.bi_id });
                    table.ForeignKey(
                        name: "FK_ApplyDiscounts_Bills_bi_id",
                        column: x => x.bi_id,
                        principalTable: "Bills",
                        principalColumn: "bi_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplyDiscounts_Discounts_dis_id",
                        column: x => x.dis_id,
                        principalTable: "Discounts",
                        principalColumn: "dis_id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    tk_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    sl_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    st_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    mv_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    r_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    tk_value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    tk_type = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    bi_id = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    tk_available = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => new { x.tk_id, x.sl_id, x.st_id });
                    table.ForeignKey(
                        name: "FK_Tickets_Bills_bi_id",
                        column: x => x.bi_id,
                        principalTable: "Bills",
                        principalColumn: "bi_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Seats_st_id_r_id",
                        columns: x => new { x.st_id, x.r_id },
                        principalTable: "Seats",
                        principalColumns: new[] { "st_id", "r_id" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Slots_sl_id_r_id_mv_id",
                        columns: x => new { x.sl_id, x.r_id, x.mv_id },
                        principalTable: "Slots",
                        principalColumns: new[] { "sl_id", "r_id", "mv_id" },
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ApplyDiscounts_bi_id",
                table: "ApplyDiscounts",
                column: "bi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Bills_cus_id",
                table: "Bills",
                column: "cus_id");

            migrationBuilder.CreateIndex(
                name: "IX_ChooseTypes_mv_id",
                table: "ChooseTypes",
                column: "mv_id");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_cus_email",
                table: "Customers",
                column: "cus_email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_cus_phone",
                table: "Customers",
                column: "cus_phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Months_mre_yre_id",
                table: "Months",
                column: "mre_yre_id");

            migrationBuilder.CreateIndex(
                name: "IX_MovieTypes_type_name",
                table: "MovieTypes",
                column: "type_name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_r_id",
                table: "Seats",
                column: "r_id");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_mv_id",
                table: "Slots",
                column: "mv_id");

            migrationBuilder.CreateIndex(
                name: "IX_Slots_r_id",
                table: "Slots",
                column: "r_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_bi_id",
                table: "Tickets",
                column: "bi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_sl_id_r_id_mv_id",
                table: "Tickets",
                columns: new[] { "sl_id", "r_id", "mv_id" });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_st_id_r_id",
                table: "Tickets",
                columns: new[] { "st_id", "r_id" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "ApplyDiscounts");

            migrationBuilder.DropTable(
                name: "ChooseTypes");

            migrationBuilder.DropTable(
                name: "Months");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "MovieTypes");

            migrationBuilder.DropTable(
                name: "Years");

            migrationBuilder.DropTable(
                name: "Bills");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Slots");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
