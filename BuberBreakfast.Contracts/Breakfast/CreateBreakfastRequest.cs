namespace BuberBreakfast.Contracts.Breakfast;

public record CreateBreakfastRequest(
    string Name,
    string Description,
    DateTime StartedDateTime,
    DateTime EndedDateTime,
    List<string> Savory,
    List <string> Sweet
);
