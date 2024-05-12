using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecipeBlogProject.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIES",
                columns: table => new
                {
                    CATEGORYID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CATEGORYNAME = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008532", x => x.CATEGORYID);
                });

            migrationBuilder.CreateTable(
                name: "PERSONS",
                columns: table => new
                {
                    PERSONID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    GENDER = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    EMAIL = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PHONE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008513", x => x.PERSONID);
                });

            migrationBuilder.CreateTable(
                name: "USERROLES",
                columns: table => new
                {
                    ROLEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ROLE_NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008506", x => x.ROLEID);
                });

            migrationBuilder.CreateTable(
                name: "SYSTEMUSERS",
                columns: table => new
                {
                    USERID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERNAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PASSWORD = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PERSON_ID = table.Column<int>(type: "int", nullable: true),
                    ROLE_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008519", x => x.USERID);
                    table.ForeignKey(
                        name: "SYS_C008522",
                        column: x => x.PERSON_ID,
                        principalTable: "PERSONS",
                        principalColumn: "PERSONID");
                    table.ForeignKey(
                        name: "SYS_C008523",
                        column: x => x.ROLE_ID,
                        principalTable: "USERROLES",
                        principalColumn: "ROLEID");
                });

            migrationBuilder.CreateTable(
                name: "ADMINS",
                columns: table => new
                {
                    ADMINID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008525", x => x.ADMINID);
                    table.ForeignKey(
                        name: "SYS_C008526",
                        column: x => x.USER_ID,
                        principalTable: "SYSTEMUSERS",
                        principalColumn: "USERID");
                });

            migrationBuilder.CreateTable(
                name: "CHEFS",
                columns: table => new
                {
                    CHEFID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USER_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008528", x => x.CHEFID);
                    table.ForeignKey(
                        name: "SYS_C008529",
                        column: x => x.USER_ID,
                        principalTable: "SYSTEMUSERS",
                        principalColumn: "USERID");
                });

            migrationBuilder.CreateTable(
                name: "TESTIMONIALS",
                columns: table => new
                {
                    TESTIMONIALID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    USERCOMMENT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IS_SHOWN = table.Column<bool>(type: "bit", precision: 1, nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008566", x => x.TESTIMONIALID);
                    table.ForeignKey(
                        name: "SYS_C008567",
                        column: x => x.USER_ID,
                        principalTable: "SYSTEMUSERS",
                        principalColumn: "USERID");
                });

            migrationBuilder.CreateTable(
                name: "VISACARDS",
                columns: table => new
                {
                    VISACARDID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FIRSTNAME = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    LASTNAME = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CARDNUMBER = table.Column<long>(type: "bigint", precision: 16, nullable: false),
                    PIN = table.Column<byte>(type: "tinyint", precision: 4, nullable: false),
                    EXPIRYDATE = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CVV = table.Column<byte>(type: "tinyint", precision: 3, nullable: false),
                    USER_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008557", x => x.VISACARDID);
                    table.ForeignKey(
                        name: "SYS_C008561",
                        column: x => x.USER_ID,
                        principalTable: "SYSTEMUSERS",
                        principalColumn: "USERID");
                });

            migrationBuilder.CreateTable(
                name: "WEBSITEDETAILS",
                columns: table => new
                {
                    WEBSITEDETAILSID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WEBSITETEXT = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TEXTTYPE = table.Column<int>(type: "int", nullable: false),
                    ADMIN_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008571", x => x.WEBSITEDETAILSID);
                    table.ForeignKey(
                        name: "SYS_C008572",
                        column: x => x.ADMIN_ID,
                        principalTable: "ADMINS",
                        principalColumn: "ADMINID");
                });

            migrationBuilder.CreateTable(
                name: "RECIPES",
                columns: table => new
                {
                    RECIPEID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RECEIPENAME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PRICE = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    INGREDIENTS = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ISAPPROVED = table.Column<bool>(type: "bit", precision: 1, nullable: false),
                    CHEF_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008538", x => x.RECIPEID);
                    table.ForeignKey(
                        name: "SYS_C008540",
                        column: x => x.CHEF_ID,
                        principalTable: "CHEFS",
                        principalColumn: "CHEFID");
                });

            migrationBuilder.CreateTable(
                name: "RECIPECATEGORIES",
                columns: table => new
                {
                    RECIPECATEGORYID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RECIPE_ID = table.Column<int>(type: "int", nullable: true),
                    CATEGORY_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008542", x => x.RECIPECATEGORYID);
                    table.ForeignKey(
                        name: "SYS_C008543",
                        column: x => x.RECIPE_ID,
                        principalTable: "RECIPES",
                        principalColumn: "RECIPEID");
                    table.ForeignKey(
                        name: "SYS_C008544",
                        column: x => x.CATEGORY_ID,
                        principalTable: "CATEGORIES",
                        principalColumn: "CATEGORYID");
                });

            migrationBuilder.CreateTable(
                name: "RECIPEPAYMENTS",
                columns: table => new
                {
                    RECIPEPAYMENTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RECIPE_ID = table.Column<int>(type: "int", nullable: true),
                    USER_ID = table.Column<int>(type: "int", nullable: true),
                    TOTALAMOUNT = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PAYMENTFILEPATH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("SYS_C008547", x => x.RECIPEPAYMENTID);
                    table.ForeignKey(
                        name: "SYS_C008548",
                        column: x => x.RECIPE_ID,
                        principalTable: "RECIPES",
                        principalColumn: "RECIPEID");
                    table.ForeignKey(
                        name: "SYS_C008549",
                        column: x => x.USER_ID,
                        principalTable: "SYSTEMUSERS",
                        principalColumn: "USERID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ADMINS_USER_ID",
                table: "ADMINS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_CHEFS_USER_ID",
                table: "CHEFS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "SYS_C008514",
                table: "PERSONS",
                column: "EMAIL",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SYS_C008515",
                table: "PERSONS",
                column: "PHONE",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RECIPECATEGORIES_CATEGORY_ID",
                table: "RECIPECATEGORIES",
                column: "CATEGORY_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RECIPECATEGORIES_RECIPE_ID",
                table: "RECIPECATEGORIES",
                column: "RECIPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RECIPEPAYMENTS_RECIPE_ID",
                table: "RECIPEPAYMENTS",
                column: "RECIPE_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RECIPEPAYMENTS_USER_ID",
                table: "RECIPEPAYMENTS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_RECIPES_CHEF_ID",
                table: "RECIPES",
                column: "CHEF_ID");

            migrationBuilder.CreateIndex(
                name: "SYS_C008539",
                table: "RECIPES",
                column: "RECEIPENAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SYSTEMUSERS_PERSON_ID",
                table: "SYSTEMUSERS",
                column: "PERSON_ID");

            migrationBuilder.CreateIndex(
                name: "IX_SYSTEMUSERS_ROLE_ID",
                table: "SYSTEMUSERS",
                column: "ROLE_ID");

            migrationBuilder.CreateIndex(
                name: "SYS_C008520",
                table: "SYSTEMUSERS",
                column: "USERNAME",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SYS_C008521",
                table: "SYSTEMUSERS",
                column: "PASSWORD",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TESTIMONIALS_USER_ID",
                table: "TESTIMONIALS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "IX_VISACARDS_USER_ID",
                table: "VISACARDS",
                column: "USER_ID");

            migrationBuilder.CreateIndex(
                name: "SYS_C008558",
                table: "VISACARDS",
                column: "CARDNUMBER",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SYS_C008559",
                table: "VISACARDS",
                column: "PIN",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "SYS_C008560",
                table: "VISACARDS",
                column: "CVV",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WEBSITEDETAILS_ADMIN_ID",
                table: "WEBSITEDETAILS",
                column: "ADMIN_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RECIPECATEGORIES");

            migrationBuilder.DropTable(
                name: "RECIPEPAYMENTS");

            migrationBuilder.DropTable(
                name: "TESTIMONIALS");

            migrationBuilder.DropTable(
                name: "VISACARDS");

            migrationBuilder.DropTable(
                name: "WEBSITEDETAILS");

            migrationBuilder.DropTable(
                name: "CATEGORIES");

            migrationBuilder.DropTable(
                name: "RECIPES");

            migrationBuilder.DropTable(
                name: "ADMINS");

            migrationBuilder.DropTable(
                name: "CHEFS");

            migrationBuilder.DropTable(
                name: "SYSTEMUSERS");

            migrationBuilder.DropTable(
                name: "PERSONS");

            migrationBuilder.DropTable(
                name: "USERROLES");
        }
    }
}
