using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Websitedetail
{
    public decimal Websitedetailsid { get; set; }
    [DisplayName("Website Text")]
    public string Websitetext { get; set; } = null!;
    [DisplayName("Type")]
    public decimal Texttype { get; set; }

    public decimal? AdminId { get; set; }

    public virtual Admin? Admin { get; set; }
}
