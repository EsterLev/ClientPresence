using AutoMapper;
using DTO;
using Presence.DAL.Classes;
using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presence.BL.Classes
{
    public class SchoolBusBL : ISchoolBusBL
    {
        private readonly ISchoolBusDAL _schoolBusDl;
        IMapper mapper;
        public SchoolBusBL(ISchoolBusDAL schoolBusDAL)
        {
            _schoolBusDl = schoolBusDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<SchoolBusDTO> GetAllSchoolBuses()
        {
            List<SchoolBuse> schoolBuses = _schoolBusDl.GetAllSchoolBuses();
            return mapper.Map<List<SchoolBuse>, List<SchoolBusDTO>>(schoolBuses);
        }

        public SchoolBusDTO GetSchoolBusById(int id)
        {
            SchoolBuse schoolBus = _schoolBusDl.GetSchoolBusById(id);
            return mapper.Map<SchoolBuse, SchoolBusDTO>(schoolBus);
        }
        public void AddSchoolBus(SchoolBusDTO schoolBus)
        {
            _schoolBusDl.AddSchoolBus(mapper.Map<SchoolBusDTO, SchoolBuse>(schoolBus));
        }
        public void UpdateSchoolBus(SchoolBusDTO schoolBus, int id)
        {
            _schoolBusDl.UpdateSchoolBus(mapper.Map<SchoolBusDTO, SchoolBuse>(schoolBus), id);
        }
        public void DeleteParent(int id)
        {
            _schoolBusDl.DeleteSchoolBus(id);
        }
    }
}
