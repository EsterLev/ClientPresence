using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IDelaySchoolBusBL
    {
        void AddDelaySchoolBus(DelaySchoolBusDTO delaySchoolBus);
        void DeleteDelaySchoolBus(int id);
        List<DelaySchoolBusDTO> GetAllDelaySchoolBuses();
        DelaySchoolBusDTO GetDelaySchoolBusById(int id);
        void UpdateDelaySchoolBus(DelaySchoolBusDTO delaySchoolBus, int id);
    }
}