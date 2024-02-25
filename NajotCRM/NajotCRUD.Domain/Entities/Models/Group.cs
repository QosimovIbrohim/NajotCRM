using NajotCRUD.Domain.Entities.Common;
using NajotCRUD.Domain.Entities.Enums;
namespace NajotCRUD.Domain.Entities.Models
{
    public class Group : BaseEntity
    {
        public string Route { get; set; }
        public GroupType GrType { get; set; }
        public string Duration { get; set; }
    }
}
