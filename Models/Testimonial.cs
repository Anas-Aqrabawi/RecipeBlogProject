using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Testimonial
{
    public decimal Testimonialid { get; set; }
    [DisplayName("User Comment")]
    public string Usercomment { get; set; } = null!;
    [DisplayName("Is Shown?")]
    public bool IsShown { get; set; }

    public decimal? UserId { get; set; }

    public virtual Systemuser? User { get; set; }
}
