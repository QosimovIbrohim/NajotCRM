using NajotCRUD.Domain.Entities.Models;

namespace NajotCRUD.Domain.Entities.DTOs
{
    public class TeacherDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long Salary { get; set; }
        public List<Group> Groups { get; set; }
    }
}
