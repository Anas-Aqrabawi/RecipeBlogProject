using System;
using System.Collections.Generic;

namespace RecipeBlogProject.Models;

public partial class Recipecategory
{
    public decimal Recipecategoryid { get; set; }

    public decimal? RecipeId { get; set; }

    public decimal? CategoryId { get; set; }

    public virtual Category? Category { get; set; }

    public virtual Recipe? Recipe { get; set; }
}
