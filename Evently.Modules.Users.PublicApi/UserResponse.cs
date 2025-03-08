namespace Evently.Modules.Userts.PublicApi;

public sealed record UserResponse(Guid Id, string Email, string FirstName, string LastName);
