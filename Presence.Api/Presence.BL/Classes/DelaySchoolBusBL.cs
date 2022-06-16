using AutoMapper;
using DTO;
using Presence.DAL;
using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presence.BL.Classes
{
    public class DelaySchoolBusBL : IDelaySchoolBusBL
    {
        private readonly IDelaySchoolBusDAL _delaySchoolBusDl;
        IMapper mapper;
        public DelaySchoolBusBL(IDelaySchoolBusDAL delaySchoolBusDl)
        {
            _delaySchoolBusDl = delaySchoolBusDl;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<DelaySchoolBusDTO> GetAllDelaySchoolBuses()
        {
            List<DelaySchoolBuse> delaySchoolBuses = _delaySchoolBusDl.GetAllDelaySchoolBuses();
            return mapper.Map<List<DelaySchoolBuse>, List<DelaySchoolBusDTO>>(delaySchoolBuses);
        }

        public DelaySchoolBusDTO GetDelaySchoolBusById(int id)
        {
            DelaySchoolBuse delaySchoolBus = _delaySchoolBusDl.GetDelaySchoolBusById(id);
            return mapper.Map<DelaySchoolBuse, DelaySchoolBusDTO>(delaySchoolBus);
        }
        public void AddDelaySchoolBus(DelaySchoolBusDTO delaySchoolBus)
        {
            _delaySchoolBusDl.AddDelaySchoolBus(mapper.Map<DelaySchoolBusDTO, DelaySchoolBuse>(delaySchoolBus));
        }
        public void UpdateDelaySchoolBus(DelaySchoolBusDTO delaySchoolBus, int id)
        {
            _delaySchoolBusDl.UpdateDelaySchoolBus(mapper.Map<DelaySchoolBusDTO, DelaySchoolBuse>(delaySchoolBus), id);
        }
        public void DeleteDelaySchoolBus(int id)
        {
            _delaySchoolBusDl.DeleteDelaySchoolBus(id);
        }
    }
}
