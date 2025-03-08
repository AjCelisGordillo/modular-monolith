namespace Evently.Modules.Userts.PublicApi;

public interface IUsersApi
{
    Task<UserResponse?> GetAsync(Guid userId, CancellationToken cancellationToken = default);
}
