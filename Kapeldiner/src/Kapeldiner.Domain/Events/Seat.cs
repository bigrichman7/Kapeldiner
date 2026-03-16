using Kapeldiner.Domain.Departments;

namespace Kapeldiner.Domain.Events;

public class Seat
{
    public Guid Id { get; set; }

    public required Event EventId { get; set; }

    public required Department DepartmentId { get; set; }

    public required string ColorType = Color.White.ToString();
}

enum Color
{
    Grey,
    Blue,
    Red,
    White
}