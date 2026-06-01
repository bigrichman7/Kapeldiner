namespace Kapeldiner.Contracts;

public record UpdateEventDto(string Title, DateTime Date, DateTime Time, Guid[] DepartmentIds);