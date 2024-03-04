using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user); 
        Task<bool>SaveAllAsync(); 
        Task<IEnumerable<AppUser>> GetUsersAsync(); 
        Task<AppUser> GetUserByIdASync(int Id);
        Task<AppUser> GetUserByUserNameAsync(string username);  
        Task<IEnumerable<MemberDto>> GetMemebersAsync(); 
        Task<MemberDto> GetMemberAsync(string username);
    }
}