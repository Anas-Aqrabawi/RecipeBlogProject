using System;
using System.Collections.Generic;

namespace RecipeBlogProject.Models;

public partial class Admin
{
    public decimal Adminid { get; set; }

    public decimal? UserId { get; set; }

    public virtual Systemuser? User { get; set; }

    public virtual ICollection<Websitedetail> Websitedetails { get; set; } = new List<Websitedetail>();
}
