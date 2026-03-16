using Kapeldiner.Domain.Departments;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kapeldiner.Domain.Events;

public class Event
{
    public Guid Id { get; set; }

    public required string Title { get; set; } = string.Empty;

    public required DateTime Time { get; set; }

    public required List<Department> Departments { get; set; } = [];

    public required List<Seat> Seats { get; set; }

}
