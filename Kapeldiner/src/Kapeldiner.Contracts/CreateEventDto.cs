namespace Kapeldiner.Contracts;

public record CreateEventDto(string Title, DateTime Date, DateTime Time, Guid[] DepartmentIds);