using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NajotCRUD.Application.Services.TeacherServices;
using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;

namespace NajotCRUD.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public ITeacherService _tch;
        public TeacherController(ITeacherService tch)
        {
            _tch = tch;
        }

        [HttpPost]
        public async Task<string> CreateTeacher([FromForm] TeacherDTO td)
        {
            return await _tch.CreateTeacher(td);
        }
        [HttpGet]
        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            return await _tch.GetAllTeachers();
        }
        [HttpGet]
        public async Task<Teacher> GetTeacherById(int id)
        {
            return await _tch.GetTeacher(id);
        }
        [HttpDelete]
        public async Task<string> DeleteTeacher(int id)
        {
            return await _tch.DeleteTeacher(id);
        }
        [HttpPut]
        public async Task<string> UpdateTeacher(int id, [FromForm] TeacherDTO td)
        {
            return await _tch.UpdateTeacher(id, td);
        }
    }
}
