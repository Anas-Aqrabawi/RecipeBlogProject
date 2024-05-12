using System;
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
                name: "Categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Categoryname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Firstname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Lastname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Gender = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Phone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Userroles",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RoleName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Userroles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Systemusers",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Username = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Password = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PersonId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    RoleId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Systemusers", x => x.id);
                    table.ForeignKey(
                        name: "FK_Systemusers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Systemusers_Userroles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Userroles",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                    table.ForeignKey(
                        name: "FK_Admins_Systemusers_UserId",
                        column: x => x.UserId,
                        principalTable: "Systemusers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Chefs",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chefs", x => x.id);
                    table.ForeignKey(
                        name: "FK_Chefs_Systemusers_UserId",
                        column: x => x.UserId,
                        principalTable: "Systemusers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Testimonials",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Usercomment = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsShown = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Testimonials", x => x.id);
                    table.ForeignKey(
                        name: "FK_Testimonials_Systemusers_UserId",
                        column: x => x.UserId,
                        principalTable: "Systemusers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Visacards",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Firstname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Lastname = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cardnumber = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    Pin = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    Expirydate = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Cvv = table.Column<byte>(type: "NUMBER(3)", nullable: false),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visacards", x => x.id);
                    table.ForeignKey(
                        name: "FK_Visacards_Systemusers_UserId",
                        column: x => x.UserId,
                        principalTable: "Systemusers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Websitedetails",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Websitetext = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Texttype = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    AdminId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Websitedetails", x => x.id);
                    table.ForeignKey(
                        name: "FK_Websitedetails_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Receipename = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Price = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    Ingredients = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Isapproved = table.Column<bool>(type: "NUMBER(1)", nullable: false),
                    ChefId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recipes_Chefs_ChefId",
                        column: x => x.ChefId,
                        principalTable: "Chefs",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Recipecategories",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RecipeId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CategoryId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipecategories", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recipecategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Recipecategories_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Recipepayments",
                columns: table => new
                {
                    id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    RecipeId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: true),
                    Totalamount = table.Column<double>(type: "BINARY_DOUBLE", nullable: true),
                    Paymentfilepath = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: true),
                    CreatedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ModifiedBy = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipepayments", x => x.id);
                    table.ForeignKey(
                        name: "FK_Recipepayments_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Recipepayments_Systemusers_UserId",
                        column: x => x.UserId,
                        principalTable: "Systemusers",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Admins_UserId",
                table: "Admins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chefs_UserId",
                table: "Chefs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipecategories_CategoryId",
                table: "Recipecategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipecategories_RecipeId",
                table: "Recipecategories",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipepayments_RecipeId",
                table: "Recipepayments",
                column: "RecipeId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipepayments_UserId",
                table: "Recipepayments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ChefId",
                table: "Recipes",
                column: "ChefId");

            migrationBuilder.CreateIndex(
                name: "IX_Systemusers_PersonId",
                table: "Systemusers",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Systemusers_RoleId",
                table: "Systemusers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Testimonials_UserId",
                table: "Testimonials",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Visacards_UserId",
                table: "Visacards",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Websitedetails_AdminId",
                table: "Websitedetails",
                column: "AdminId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipecategories");

            migrationBuilder.DropTable(
                name: "Recipepayments");

            migrationBuilder.DropTable(
                name: "Testimonials");

            migrationBuilder.DropTable(
                name: "Visacards");

            migrationBuilder.DropTable(
                name: "Websitedetails");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Chefs");

            migrationBuilder.DropTable(
                name: "Systemusers");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Userroles");
        }
    }
}
