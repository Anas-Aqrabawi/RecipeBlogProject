using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Recipepayment
{
    public decimal Recipepaymentid { get; set; }

    public decimal? RecipeId { get; set; }

    public decimal? UserId { get; set; }
    [DisplayName("Total Amount")]
    public decimal? Totalamount { get; set; }
    [DisplayName("Payment File Path")]
    public string Paymentfilepath { get; set; } = null!;

    public virtual Recipe? Recipe { get; set; }

    public virtual Systemuser? User { get; set; }
}
