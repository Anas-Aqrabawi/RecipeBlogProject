﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RecipeBlogProject.Models;

#nullable disable

namespace RecipeBlogProject.Migrations
{
    [DbContext(typeof(ModelContext))]
    [Migration("20240512205413_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RecipeBlogProject.Models.Admin", b =>
                {
                    b.Property<int>("Adminid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ADMINID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Adminid"));

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Adminid")
                        .HasName("SYS_C008525");

                    b.HasIndex("UserId");

                    b.ToTable("ADMINS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Category", b =>
                {
                    b.Property<int>("Categoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CATEGORYID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Categoryid"));

                    b.Property<string>("Categoryname")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("CATEGORYNAME");

                    b.HasKey("Categoryid")
                        .HasName("SYS_C008532");

                    b.ToTable("CATEGORIES", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Chef", b =>
                {
                    b.Property<int>("Chefid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CHEFID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Chefid"));

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Chefid")
                        .HasName("SYS_C008528");

                    b.HasIndex("UserId");

                    b.ToTable("CHEFS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Person", b =>
                {
                    b.Property<int>("Personid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PERSONID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Personid"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("FIRSTNAME");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)")
                        .HasColumnName("GENDER");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("LASTNAME");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("PHONE");

                    b.HasKey("Personid")
                        .HasName("SYS_C008513");

                    b.HasIndex(new[] { "Email" }, "SYS_C008514")
                        .IsUnique();

                    b.HasIndex(new[] { "Phone" }, "SYS_C008515")
                        .IsUnique();

                    b.ToTable("PERSONS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipe", b =>
                {
                    b.Property<int>("Recipeid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RECIPEID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Recipeid"));

                    b.Property<int?>("ChefId")
                        .HasColumnType("int")
                        .HasColumnName("CHEF_ID");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("INGREDIENTS");

                    b.Property<bool>("Isapproved")
                        .HasPrecision(1)
                        .HasColumnType("bit")
                        .HasColumnName("ISAPPROVED");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("PRICE");

                    b.Property<string>("Receipename")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("RECEIPENAME");

                    b.HasKey("Recipeid")
                        .HasName("SYS_C008538");

                    b.HasIndex("ChefId");

                    b.HasIndex(new[] { "Receipename" }, "SYS_C008539")
                        .IsUnique();

                    b.ToTable("RECIPES", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipecategory", b =>
                {
                    b.Property<int>("Recipecategoryid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RECIPECATEGORYID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Recipecategoryid"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("CATEGORY_ID");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("RECIPE_ID");

                    b.HasKey("Recipecategoryid")
                        .HasName("SYS_C008542");

                    b.HasIndex("CategoryId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RECIPECATEGORIES", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipepayment", b =>
                {
                    b.Property<int>("Recipepaymentid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RECIPEPAYMENTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Recipepaymentid"));

                    b.Property<string>("Paymentfilepath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("PAYMENTFILEPATH");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int")
                        .HasColumnName("RECIPE_ID");

                    b.Property<decimal?>("Totalamount")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("TOTALAMOUNT");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Recipepaymentid")
                        .HasName("SYS_C008547");

                    b.HasIndex("RecipeId");

                    b.HasIndex("UserId");

                    b.ToTable("RECIPEPAYMENTS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Systemuser", b =>
                {
                    b.Property<int>("Userid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("USERID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Userid"));

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("PASSWORD");

                    b.Property<int?>("PersonId")
                        .HasColumnType("int")
                        .HasColumnName("PERSON_ID");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("ROLE_ID");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("USERNAME");

                    b.HasKey("Userid")
                        .HasName("SYS_C008519");

                    b.HasIndex("PersonId");

                    b.HasIndex("RoleId");

                    b.HasIndex(new[] { "Username" }, "SYS_C008520")
                        .IsUnique();

                    b.HasIndex(new[] { "Password" }, "SYS_C008521")
                        .IsUnique();

                    b.ToTable("SYSTEMUSERS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Testimonial", b =>
                {
                    b.Property<int>("Testimonialid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TESTIMONIALID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Testimonialid"));

                    b.Property<bool>("IsShown")
                        .HasPrecision(1)
                        .HasColumnType("bit")
                        .HasColumnName("IS_SHOWN");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.Property<string>("Usercomment")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("USERCOMMENT");

                    b.HasKey("Testimonialid")
                        .HasName("SYS_C008566");

                    b.HasIndex("UserId");

                    b.ToTable("TESTIMONIALS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Userrole", b =>
                {
                    b.Property<int>("Roleid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ROLEID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Roleid"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("ROLE_NAME");

                    b.HasKey("Roleid")
                        .HasName("SYS_C008506");

                    b.ToTable("USERROLES", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Visacard", b =>
                {
                    b.Property<int>("Visacardid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("VISACARDID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Visacardid"));

                    b.Property<long>("Cardnumber")
                        .HasPrecision(16)
                        .HasColumnType("bigint")
                        .HasColumnName("CARDNUMBER");

                    b.Property<byte>("Cvv")
                        .HasPrecision(3)
                        .HasColumnType("tinyint")
                        .HasColumnName("CVV");

                    b.Property<string>("Expirydate")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("EXPIRYDATE");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("FIRSTNAME");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("LASTNAME");

                    b.Property<byte>("Pin")
                        .HasPrecision(4)
                        .HasColumnType("tinyint")
                        .HasColumnName("PIN");

                    b.Property<int?>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("USER_ID");

                    b.HasKey("Visacardid")
                        .HasName("SYS_C008557");

                    b.HasIndex("UserId");

                    b.HasIndex(new[] { "Cardnumber" }, "SYS_C008558")
                        .IsUnique();

                    b.HasIndex(new[] { "Pin" }, "SYS_C008559")
                        .IsUnique();

                    b.HasIndex(new[] { "Cvv" }, "SYS_C008560")
                        .IsUnique();

                    b.ToTable("VISACARDS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Websitedetail", b =>
                {
                    b.Property<int>("Websitedetailsid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WEBSITEDETAILSID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Websitedetailsid"));

                    b.Property<int?>("AdminId")
                        .HasColumnType("int")
                        .HasColumnName("ADMIN_ID");

                    b.Property<int>("Texttype")
                        .HasColumnType("int")
                        .HasColumnName("TEXTTYPE");

                    b.Property<string>("Websitetext")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("WEBSITETEXT");

                    b.HasKey("Websitedetailsid")
                        .HasName("SYS_C008571");

                    b.HasIndex("AdminId");

                    b.ToTable("WEBSITEDETAILS", (string)null);
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Admin", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Systemuser", "User")
                        .WithMany("Admins")
                        .HasForeignKey("UserId")
                        .HasConstraintName("SYS_C008526");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Chef", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Systemuser", "User")
                        .WithMany("Chefs")
                        .HasForeignKey("UserId")
                        .HasConstraintName("SYS_C008529");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipe", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Chef", "Chef")
                        .WithMany("Recipes")
                        .HasForeignKey("ChefId")
                        .HasConstraintName("SYS_C008540");

                    b.Navigation("Chef");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipecategory", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Category", "Category")
                        .WithMany("Recipecategories")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("SYS_C008544");

                    b.HasOne("RecipeBlogProject.Models.Recipe", "Recipe")
                        .WithMany("Recipecategories")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("SYS_C008543");

                    b.Navigation("Category");

                    b.Navigation("Recipe");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipepayment", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Recipe", "Recipe")
                        .WithMany("Recipepayments")
                        .HasForeignKey("RecipeId")
                        .HasConstraintName("SYS_C008548");

                    b.HasOne("RecipeBlogProject.Models.Systemuser", "User")
                        .WithMany("Recipepayments")
                        .HasForeignKey("UserId")
                        .HasConstraintName("SYS_C008549");

                    b.Navigation("Recipe");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Systemuser", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Person", "Person")
                        .WithMany("Systemusers")
                        .HasForeignKey("PersonId")
                        .HasConstraintName("SYS_C008522");

                    b.HasOne("RecipeBlogProject.Models.Userrole", "Role")
                        .WithMany("Systemusers")
                        .HasForeignKey("RoleId")
                        .HasConstraintName("SYS_C008523");

                    b.Navigation("Person");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Testimonial", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Systemuser", "User")
                        .WithMany("Testimonials")
                        .HasForeignKey("UserId")
                        .HasConstraintName("SYS_C008567");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Visacard", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Systemuser", "User")
                        .WithMany("Visacards")
                        .HasForeignKey("UserId")
                        .HasConstraintName("SYS_C008561");

                    b.Navigation("User");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Websitedetail", b =>
                {
                    b.HasOne("RecipeBlogProject.Models.Admin", "Admin")
                        .WithMany("Websitedetails")
                        .HasForeignKey("AdminId")
                        .HasConstraintName("SYS_C008572");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Admin", b =>
                {
                    b.Navigation("Websitedetails");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Category", b =>
                {
                    b.Navigation("Recipecategories");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Chef", b =>
                {
                    b.Navigation("Recipes");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Person", b =>
                {
                    b.Navigation("Systemusers");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Recipe", b =>
                {
                    b.Navigation("Recipecategories");

                    b.Navigation("Recipepayments");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Systemuser", b =>
                {
                    b.Navigation("Admins");

                    b.Navigation("Chefs");

                    b.Navigation("Recipepayments");

                    b.Navigation("Testimonials");

                    b.Navigation("Visacards");
                });

            modelBuilder.Entity("RecipeBlogProject.Models.Userrole", b =>
                {
                    b.Navigation("Systemusers");
                });
#pragma warning restore 612, 618
        }
    }
}
