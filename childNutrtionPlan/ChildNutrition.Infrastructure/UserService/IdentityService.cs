using ChildNutrition.Application.Interfaces;
using ChildNutrition.Application.Models.Users;
using ChildNutrition.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace ChildNutrition.Infrastructure.UserService
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<User> _userManager;
        public IdentityService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task<string> CreateAsync(CreateUserVM user, User password)
        {
            throw new NotImplementedException();
            var dbUser = new User();
            dbUser.FirstName = user.FirstName;
            dbUser.LastName= user.LastName; ;
            dbUser.Email= user.Email;
            dbUser.UserName = user.UserName;
            var result=await _userManager.CreateAsync(dbUser);
            if (result.Succeeded)
            {
                return dbUser.Id;
                
            }
            throw new Exception("error_occured while creating user!!!");
        }

        public Task<List<UserVM>> DeleteAsync(int id, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> GetAsync(int id, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> ListAsync(CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserVM>> UpdateAsync(int id, UpdateUserVM user, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }

        Task<List<UserVM>> IIdentityService.CreateAsync(CreateUserVM user, CancellationToken CancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

