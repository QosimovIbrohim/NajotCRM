using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajotCRUD.Application.Services.GroupServices;
using NajotCRUD.Application.Services.StudentServices;
using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;

namespace NajotCRUD.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        public IGroupService _gr;
        public GroupController(IGroupService gr)
        {
            _gr = gr;
        }

        [HttpPost]
        public async Task<string> CreateGruop([FromForm] GroupDTO gr)
        {
            return await _gr.CreateGroup(gr);
        }
        [HttpGet]
        public async Task<IEnumerable<Group>> GetAllGroup()
        {
            return await _gr.GetAllGroups();
        }
        [HttpGet]
        public async Task<Group> GetGroupById(int id)
        {
            return await _gr.GetGroup(id);
        }
        [HttpDelete]
        public async Task<string> Deletegroup(int id)
        {
            return await _gr.DeleteGroup(id);
        }
        [HttpPut]
        public async Task<string> UpdateGroup(int id, [FromForm] GroupDTO gr)
        {
            return await _gr.UpdateGroup(id, gr);
        }
    }
}
