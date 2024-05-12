using System;
using System.Collections.Generic;

namespace RecipeBlogProject.Models;

public partial class Chef
{
    public decimal Chefid { get; set; }

    public decimal? UserId { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual Systemuser? User { get; set; }
}
