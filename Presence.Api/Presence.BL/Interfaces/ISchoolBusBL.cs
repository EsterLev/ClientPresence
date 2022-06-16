using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface ISchoolBusBL
    {
        void AddSchoolBus(SchoolBusDTO schoolBus);
        void DeleteParent(int id);
        List<SchoolBusDTO> GetAllSchoolBuses();
        SchoolBusDTO GetSchoolBusById(int id);
        void UpdateSchoolBus(SchoolBusDTO schoolBus, int id);
    }
}