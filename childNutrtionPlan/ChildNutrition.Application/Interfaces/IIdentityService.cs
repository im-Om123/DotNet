using ChildNutrition.Application.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Interfaces
{
    public interface IIdentityService
    {
        Task<List<UserVM>> ListAsync(CancellationToken CancellationToken);
        Task<List<UserVM>> GetAsync(int id, CancellationToken CancellationToken);
        Task<List<UserVM>> CreateAsync(CreateUserVM user, CancellationToken CancellationToken);
        Task<List<UserVM>> UpdateAsync(int id, UpdateUserVM user, CancellationToken CancellationToken);
        Task<List<UserVM>> DeleteAsync(int id, CancellationToken CancellationToken);
    }
}
