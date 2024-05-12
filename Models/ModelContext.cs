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

   

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
