using Microsoft.EntityFrameworkCore;
using NajotCRUD.Domain.Entities.DTOs;
using NajotCRUD.Domain.Entities.Models;
using NajotCRUD.Infrastruct.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Application.Services.GroupServices
{
    public class GroupService : IGroupService
    {
        public ApplicationDbContext _context;
        public GroupService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateGroup(GroupDTO gr)
        {
            try
            {

                var model = new Group()
                {
                    GrType = gr.GrType,
                    Duration = gr.Duration,
                    Route = gr.Route,
                };
                await _context.Groups.AddAsync(model);
                await _context.SaveChangesAsync();
                return "Successfully";
            }
            catch
            {
                return "Bad Request";
            }
        }

        public async Task<string> DeleteGroup(int id)
        {
            try
            {
                var model = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    _context.Groups.Remove(model);
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

        public async Task<IEnumerable<Group>> GetAllGroups()
        {
            try
            {
                var models = await _context.Groups.ToListAsync();
                if (models is not null)
                {
                    return models;
                }
                else
                {
                    return Enumerable.Empty<Group>();
                }
            }
            catch
            {
                return Enumerable.Empty<Group>();
            }
        }

        public async Task<Group> GetGroup(int id)
        {
            try
            {

                var model = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    return model;
                }
                else
                {
                    return new Group();
                }
            }
            catch
            {
                return new Group();
            }
        }

        public async Task<string> UpdateGroup(int id, GroupDTO gr)
        {
            try
            {
                var model = await _context.Groups.FirstOrDefaultAsync(x => x.Id == id);
                if (model is not null)
                {
                    model.Route = gr.Route;
                    model.Duration = gr.Route;
                    model.GrType = gr.GrType;

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
