using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface ISchoolBusDAL
    {
        void AddSchoolBus(SchoolBuse schoolBus);
        void DeleteSchoolBus(int id);
        List<SchoolBuse> GetAllSchoolBuses();
        SchoolBuse GetSchoolBusById(int id);
        void UpdateSchoolBus(SchoolBuse schoolBus, int id);
    }
}