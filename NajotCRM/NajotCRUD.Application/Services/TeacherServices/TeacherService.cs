using Microsoft.EntityFrameworkCore;
using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;
using NajotCRUD.Infrastruct.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Application.Services.TeacherServices
{
    public class TeacherService : ITeacherService
    {
        public ApplicationDbContext _context;
        public TeacherService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> CreateTeacher(TeacherDTO tr)
        {
            try
            {
                var model = new Teacher()
                {
                    Salary = tr.Salary,
                    FirstName = tr.FirstName,
                    LastName = tr.LastName,
                    Groups = tr.Groups,

                };
                await _context.Teachers.AddAsync(model);
                await _context.SaveChangesAsync();
                return "Successfully";
            }
            catch
            {
                return "Bad Request";
            }
        }

        public async Task<string> DeleteTeacher(int id)
        {
            try
            {
                var model = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    _context.Teachers.Remove(model);
                    await _context.SaveChangesAsync();
                    return "Successfully";
                }
                else
                {
                    return "Not found";
                }
            }
            catch
            {
                return "Error";
            }
        }

        public async Task<IEnumerable<Teacher>> GetAllTeachers()
        {
            try
            {
                var models = await _context.Teachers.ToListAsync();
                if (models is not null)
                {
                    return models;
                }
                else
                {
                    return Enumerable.Empty<Teacher>();
                }
            }
            catch
            {
                return Enumerable.Empty<Teacher>();
            }
        }

        public async Task<Teacher> GetTeacher(int id)
        {
            try
            {

                var model = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    return model;
                }
                else
                {
                    return new Teacher();
                }
            }
            catch
            {
                return new Teacher();
            }
        }

        public async Task<string> UpdateTeacher(int id, TeacherDTO tr)
        {
            try
            {
                var model = await _context.Teachers.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    model.FirstName = tr.FirstName;
                    model.LastName = tr.LastName;
                    model.Groups = tr.Groups;
                    model.Salary = tr.Salary;

                    await _context.SaveChangesAsync();
                    return "Succesfully update";
                }
                else
                {
                    return "Not found";
                }
            }
            catch
            {
                return "Error";
            }
        }
    }
}
