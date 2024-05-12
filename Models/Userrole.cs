﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace RecipeBlogProject.Models;

public partial class Userrole
{
    public int Roleid { get; set; }
    [DisplayName("Role Name")]
    public string RoleName { get; set; } = null!;

    public virtual ICollection<Systemuser> Systemusers { get; set; } = new List<Systemuser>();
}
