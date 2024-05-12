using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Visacard
{
    public decimal Visacardid { get; set; }
    [DisplayName("First Name")]
    public string Firstname { get; set; } = null!;
    [DisplayName("Last Name")]
    public string Lastname { get; set; } = null!;
    [DisplayName("Card Number")]
    public long Cardnumber { get; set; }

    public byte Pin { get; set; }
    [DisplayName("Expiration Date")]
    public string Expirydate { get; set; } = null!;

    public byte Cvv { get; set; }

    public decimal? UserId { get; set; }

    public virtual Systemuser? User { get; set; }
}
