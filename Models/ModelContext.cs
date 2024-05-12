using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RecipeBlogProject.Models;

public partial class ModelContext : DbContext
{
    public ModelContext()
    {
    }

    public ModelContext(DbContextOptions<ModelContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Admin> Admins { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Chef> Chefs { get; set; }

    public virtual DbSet<Person> Persons { get; set; }

    public virtual DbSet<Recipe> Recipes { get; set; }

    public virtual DbSet<Recipecategory> Recipecategories { get; set; }

    public virtual DbSet<Recipepayment> Recipepayments { get; set; }

    public virtual DbSet<Systemuser> Systemusers { get; set; }

    public virtual DbSet<Testimonial> Testimonials { get; set; }

    public virtual DbSet<Userrole> Userroles { get; set; }

    public virtual DbSet<Visacard> Visacards { get; set; }

    public virtual DbSet<Websitedetail> Websitedetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
       => optionsBuilder.UseOracle("USER ID=C##ANAS1;PASSWORD=anas123;DATA SOURCE=localhost:1521/xe");
    //  => optionsBuilder.UseSqlServer();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .HasDefaultSchema("C##ANAS1")
            .UseCollation("USING_NLS_COMP");

        modelBuilder.Entity<Admin>(entity =>
        {
            entity.HasKey(e => e.Adminid).HasName("SYS_C008525");

            entity.ToTable("ADMINS");

            entity.Property(e => e.Adminid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("ADMINID");
            entity.Property(e => e.UserId)
                
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Admins)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("SYS_C008526");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Categoryid).HasName("SYS_C008532");

            entity.ToTable("CATEGORIES");

            entity.Property(e => e.Categoryid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("CATEGORYID");
            entity.Property(e => e.Categoryname)
                .HasMaxLength(25)
                .HasColumnName("CATEGORYNAME");
        });

        modelBuilder.Entity<Chef>(entity =>
        {
            entity.HasKey(e => e.Chefid).HasName("SYS_C008528");

            entity.ToTable("CHEFS");

            entity.Property(e => e.Chefid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("CHEFID");
            entity.Property(e => e.UserId)
                
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Chefs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("SYS_C008529");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Personid).HasName("SYS_C008513");

            entity.ToTable("PERSONS");

            entity.HasIndex(e => e.Email, "SYS_C008514").IsUnique();

            entity.HasIndex(e => e.Phone, "SYS_C008515").IsUnique();

            entity.Property(e => e.Personid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("PERSONID");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Firstname)
                .HasMaxLength(10)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(7)
                .HasColumnName("GENDER");
            entity.Property(e => e.Lastname)
                .HasMaxLength(15)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Phone)
                .HasMaxLength(10)
                .HasColumnName("PHONE");
        });

        modelBuilder.Entity<Recipe>(entity =>
        {
            entity.HasKey(e => e.Recipeid).HasName("SYS_C008538");

            entity.ToTable("RECIPES");

            entity.HasIndex(e => e.Receipename, "SYS_C008539").IsUnique();

            entity.Property(e => e.Recipeid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("RECIPEID");
            entity.Property(e => e.ChefId)
                
                .HasColumnName("CHEF_ID");
            entity.Property(e => e.Ingredients)
                .HasMaxLength(255)
                .HasColumnName("INGREDIENTS");
            entity.Property(e => e.Isapproved)
                .HasPrecision(1)
                .HasColumnName("ISAPPROVED");
            entity.Property(e => e.Price)
                .HasColumnName("PRICE");
            entity.Property(e => e.Receipename)
                .HasMaxLength(20)
                .HasColumnName("RECEIPENAME");

            entity.HasOne(d => d.Chef).WithMany(p => p.Recipes)
                .HasForeignKey(d => d.ChefId)
                .HasConstraintName("SYS_C008540");
        });

        modelBuilder.Entity<Recipecategory>(entity =>
        {
            entity.HasKey(e => e.Recipecategoryid).HasName("SYS_C008542");

            entity.ToTable("RECIPECATEGORIES");

            entity.Property(e => e.Recipecategoryid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("RECIPECATEGORYID");
            entity.Property(e => e.CategoryId)
                
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.RecipeId)
                
                .HasColumnName("RECIPE_ID");

            entity.HasOne(d => d.Category).WithMany(p => p.Recipecategories)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("SYS_C008544");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Recipecategories)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("SYS_C008543");
        });

        modelBuilder.Entity<Recipepayment>(entity =>
        {
            entity.HasKey(e => e.Recipepaymentid).HasName("SYS_C008547");

            entity.ToTable("RECIPEPAYMENTS");

            entity.Property(e => e.Recipepaymentid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("RECIPEPAYMENTID");
            entity.Property(e => e.Paymentfilepath)
                .HasMaxLength(255)
                .HasColumnName("PAYMENTFILEPATH");
            entity.Property(e => e.RecipeId)
                
                .HasColumnName("RECIPE_ID");
            entity.Property(e => e.Totalamount)
                .HasColumnName("TOTALAMOUNT");
            entity.Property(e => e.UserId)
                
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.Recipe).WithMany(p => p.Recipepayments)
                .HasForeignKey(d => d.RecipeId)
                .HasConstraintName("SYS_C008548");

            entity.HasOne(d => d.User).WithMany(p => p.Recipepayments)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("SYS_C008549");
        });

        modelBuilder.Entity<Systemuser>(entity =>
        {
            entity.HasKey(e => e.Userid).HasName("SYS_C008519");

            entity.ToTable("SYSTEMUSERS");

            entity.HasIndex(e => e.Username, "SYS_C008520").IsUnique();

            entity.HasIndex(e => e.Password, "SYS_C008521").IsUnique();

            entity.Property(e => e.Userid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("USERID");
            entity.Property(e => e.Password)
                .HasMaxLength(20)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.PersonId)
                
                .HasColumnName("PERSON_ID");
            entity.Property(e => e.RoleId)
                
                .HasColumnName("ROLE_ID");
            entity.Property(e => e.Username)
                .HasMaxLength(20)
                .HasColumnName("USERNAME");

            entity.HasOne(d => d.Person).WithMany(p => p.Systemusers)
                .HasForeignKey(d => d.PersonId)
                .HasConstraintName("SYS_C008522");

            entity.HasOne(d => d.Role).WithMany(p => p.Systemusers)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("SYS_C008523");
        });

        modelBuilder.Entity<Testimonial>(entity =>
        {
            entity.HasKey(e => e.Testimonialid).HasName("SYS_C008566");

            entity.ToTable("TESTIMONIALS");

            entity.Property(e => e.Testimonialid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("TESTIMONIALID");
            entity.Property(e => e.IsShown)
                .HasPrecision(1)
                .HasColumnName("IS_SHOWN");
            entity.Property(e => e.UserId)
                
                .HasColumnName("USER_ID");
            entity.Property(e => e.Usercomment)
                .HasMaxLength(255)
                .HasColumnName("USERCOMMENT");

            entity.HasOne(d => d.User).WithMany(p => p.Testimonials)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("SYS_C008567");
        });

        modelBuilder.Entity<Userrole>(entity =>
        {
            entity.HasKey(e => e.Roleid).HasName("SYS_C008506");

            entity.ToTable("USERROLES");

            entity.Property(e => e.Roleid)
                .ValueGeneratedOnAdd()
                .HasColumnName("ROLEID");
            entity.Property(e => e.RoleName)
                .HasMaxLength(50)
                .HasColumnName("ROLE_NAME");
        });

        modelBuilder.Entity<Visacard>(entity =>
        {
            entity.HasKey(e => e.Visacardid).HasName("SYS_C008557");

            entity.ToTable("VISACARDS");

            entity.HasIndex(e => e.Cardnumber, "SYS_C008558").IsUnique();

            entity.HasIndex(e => e.Pin, "SYS_C008559").IsUnique();

            entity.HasIndex(e => e.Cvv, "SYS_C008560").IsUnique();

            entity.Property(e => e.Visacardid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("VISACARDID");
            entity.Property(e => e.Cardnumber)
                .HasPrecision(16)
                .HasColumnName("CARDNUMBER");
            entity.Property(e => e.Cvv)
                .HasPrecision(3)
                .HasColumnName("CVV");
            entity.Property(e => e.Expirydate)
                .HasMaxLength(10)
                .HasColumnName("EXPIRYDATE");
            entity.Property(e => e.Firstname)
                .HasMaxLength(10)
                .HasColumnName("FIRSTNAME");
            entity.Property(e => e.Lastname)
                .HasMaxLength(15)
                .HasColumnName("LASTNAME");
            entity.Property(e => e.Pin)
                .HasPrecision(4)
                .HasColumnName("PIN");
            entity.Property(e => e.UserId)
                
                .HasColumnName("USER_ID");

            entity.HasOne(d => d.User).WithMany(p => p.Visacards)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("SYS_C008561");
        });

        modelBuilder.Entity<Websitedetail>(entity =>
        {
            entity.HasKey(e => e.Websitedetailsid).HasName("SYS_C008571");

            entity.ToTable("WEBSITEDETAILS");

            entity.Property(e => e.Websitedetailsid)
                .ValueGeneratedOnAdd()
                
                .HasColumnName("WEBSITEDETAILSID");
            entity.Property(e => e.AdminId)
                
                .HasColumnName("ADMIN_ID");
            entity.Property(e => e.Texttype)
                .HasColumnName("TEXTTYPE");
            entity.Property(e => e.Websitetext)
                .HasMaxLength(255)
                .HasColumnName("WEBSITETEXT");

            entity.HasOne(d => d.Admin).WithMany(p => p.Websitedetails)
                .HasForeignKey(d => d.AdminId)
                .HasConstraintName("SYS_C008572");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
