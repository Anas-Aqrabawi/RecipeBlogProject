using System;
using System.Collections.Generic;

namespace RecipeBlogProject.Models;

public partial class Systemuser
{
    public int Userid { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int? PersonId { get; set; }

    public int? RoleId { get; set; }

    public virtual ICollection<Admin> Admins { get; set; } = new List<Admin>();

    public virtual ICollection<Chef> Chefs { get; set; } = new List<Chef>();

    public virtual Person? Person { get; set; }

    public virtual ICollection<Recipepayment> Recipepayments { get; set; } = new List<Recipepayment>();

    public virtual Userrole? Role { get; set; }

    public virtual ICollection<Testimonial> Testimonials { get; set; } = new List<Testimonial>();

    public virtual ICollection<Visacard> Visacards { get; set; } = new List<Visacard>();
}
