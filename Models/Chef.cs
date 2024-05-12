using System;
using System.Collections.Generic;

namespace RecipeBlogProject.Models;

public partial class Chef: BaseEntity
{


    public int? UserId { get; set; }

    public virtual ICollection<Recipe> Recipes { get; set; } = new List<Recipe>();

    public virtual Systemuser? User { get; set; }
}
