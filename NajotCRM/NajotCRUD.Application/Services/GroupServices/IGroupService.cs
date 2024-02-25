using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Application.Services.GroupServices
{
    public interface IGroupService
    {
        public Task<string> CreateGroup(GroupDTO gr);
        public Task<string> UpdateGroup(int id, GroupDTO gr);
        public Task<string> DeleteGroup(int id);
        public Task<Group> GetGroup(int id);
        public Task<IEnumerable<Group>> GetAllGroups();
    }
}
