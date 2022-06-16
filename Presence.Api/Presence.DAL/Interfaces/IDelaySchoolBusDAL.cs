using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL
{
    public interface IDelaySchoolBusDAL
    {
        void AddDelaySchoolBus(DelaySchoolBuse delaySchoolBus);
        void DeleteDelaySchoolBus(int id);
        List<DelaySchoolBuse> GetAllDelaySchoolBuses();
        DelaySchoolBuse GetDelaySchoolBusById(int id);
        void UpdateDelaySchoolBus(DelaySchoolBuse delaySchoolBus, int id);
    }
}