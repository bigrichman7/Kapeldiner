using Kapeldiner.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapeldiner.Domain.Departments;

public class Department
{
    public Guid Id { get; set; }

    public required string Name { get; set; }

    public required string Type = DepartType.Department.ToString();

    public List<Event> Events { get; set; } = [];

}

enum DepartType
{
    VIP,
    Center,
    Department
}
