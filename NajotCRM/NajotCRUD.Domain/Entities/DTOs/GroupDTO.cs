using NajotCRUD.Domain.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Domain.Entities.DTOs
{
    public class GroupDTO
    {
        public string Route { get; set; }
        public GroupType GrType { get; set; }
        public string Duration { get; set; }
    }
}
