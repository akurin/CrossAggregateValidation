using System;
using System.Threading.Tasks;
using Optional;

namespace CrossAggregateConstraints.Domain
{
    public interface IUserRegistrationProcessRepository
    {
        Task SaveAsync(UserRegistrationProcess registrationProcess);
        Task<Option<UserRegistrationProcess>> GetAsync(Guid userId);
    }
}