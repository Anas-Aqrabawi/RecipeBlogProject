using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Recipe
{
    public decimal Recipeid { get; set; }
    [DisplayName("Recipe Name")]
    public string Receipename { get; set; } = null!;

    public decimal? Price { get; set; }

    public string Ingredients { get; set; } = null!;
    [DisplayName("Is Approved?")]
    public bool Isapproved { get; set; }

    public decimal? ChefId { get; set; }

    public virtual Chef? Chef { get; set; }

    public virtual ICollection<Recipecategory> Recipecategories { get; set; } = new List<Recipecategory>();

    public virtual ICollection<Recipepayment> Recipepayments { get; set; } = new List<Recipepayment>();
}
