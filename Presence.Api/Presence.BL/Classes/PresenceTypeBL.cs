using AutoMapper;
using DTO;
using Presence.DAL.Classes;
using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presence.BL.Classes
{
    public class PresenceTypeBL : IPresenceTypeBL
    {
        private readonly IPresenceTypeDAL _presenceTypeDl;
        IMapper mapper;
        public PresenceTypeBL(IPresenceTypeDAL presenceTypeDl)
        {
            _presenceTypeDl = presenceTypeDl;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<PresenceTypeDTO> GetAllPresenceTypes()
        {
            List<PresenceType> presenceTypes = _presenceTypeDl.GetAllPresenceTypes();
            return mapper.Map<List<PresenceType>, List<PresenceTypeDTO>>(presenceTypes);
        }

        public PresenceTypeDTO GetPresenceTypeById(int id)
        {
            PresenceType presenceType = _presenceTypeDl.GetPresenceTypeById(id);
            return mapper.Map<PresenceType, PresenceTypeDTO>(presenceType);
        }
    }
}
