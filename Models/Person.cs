using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Person
{
    public int Personid { get; set; }
    [DisplayName("First Name")]
    public string Firstname { get; set; } = null!;
    [DisplayName("Last Name")]
    public string Lastname { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public virtual ICollection<Systemuser> Systemusers { get; set; } = new List<Systemuser>();
}
