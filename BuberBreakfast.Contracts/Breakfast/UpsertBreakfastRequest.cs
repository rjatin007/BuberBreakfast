namespace BuberBreakfast.Contracts.Breakfast;

public record UpsertBreakfastRequest(
    string Name,
    string Description,
    DateTime StartedDateTime,
    DateTime EndedDateTime,
    List<string> Savory,
    List <string> Sweet
);
