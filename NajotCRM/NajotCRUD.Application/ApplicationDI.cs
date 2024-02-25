using Microsoft.Extensions.DependencyInjection;
using NajotCRUD.Application.Services.GroupServices;
using NajotCRUD.Application.Services.StudentServices;
using NajotCRUD.Application.Services.TeacherServices;

namespace NajotCRUD.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddServicees(this IServiceCollection services)
        {
            services.AddScoped<Services.StudentServices.IStudentService, StudentService>();
            services.AddScoped<Services.GroupServices.IGroupService, GroupService>();
            services.AddScoped<ITeacherService, TeacherService>();
            return services;
        }
    }
}
