using Kapeldiner.Domain.Departments;
using Kapeldiner.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapeldiner.Domain.Admin;

public class Admin
{
    public List<Department> Departments { get; set; } = [];

    public List<Event> Events { get; set; } = [];
}
