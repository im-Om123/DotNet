using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Users;
using ChildNutrition.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ChildNutrition.Application.Services
{
    public class UserService : IUserService

    {
        private readonly IIdentityService _identityService;
        public UserService(IIdentityService identityService)
        {
            _identityService = identityService;
        }


        public async Task<string> CreateAsync(CreateUserVM user, CancellationToken cancellationToken)
        {
            var result = await _identityService.CreateAsync(user, cancellationToken);
            return result;
            throw new NotImplementedException();
        }

        public Task<int> CreateAsync(CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserVM> GetAsync(int id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> ListAsync(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAsync(int id, UpdateUserVM user, CancellationToken cancellation)
        {
            throw new NotImplementedException();
        }

        Task<string> IUserService.CreateAsync(CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

