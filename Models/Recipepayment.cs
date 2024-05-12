using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Recipepayment
{
    public int Recipepaymentid { get; set; }

    public int? RecipeId { get; set; }

    public int? UserId { get; set; }
    [DisplayName("Total Amount")]
    public decimal? Totalamount { get; set; }
    [DisplayName("Payment File Path")]
    public string Paymentfilepath { get; set; } = null!;

    public virtual Recipe? Recipe { get; set; }

    public virtual Systemuser? User { get; set; }
}
