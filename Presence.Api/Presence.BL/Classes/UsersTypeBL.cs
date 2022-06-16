using AutoMapper;
using DTO;
using Presence.DAL;
using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presence.BL
{
    public class UsersTypeBL : IUsersTypeBL
    {
        private readonly IUsersTypeDAL _usersTypeDl;
        IMapper mapper;
        public UsersTypeBL(IUsersTypeDAL usersTypeDl)
        {
            _usersTypeDl = usersTypeDl;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<UsersTypeDTO> GetAllUsersTypes()
        {
            List<UsersType> usersTypes = _usersTypeDl.GetAllUsersTypes();
            return mapper.Map<List<UsersType>, List<UsersTypeDTO>>(usersTypes);
        }

        public UsersTypeDTO GetUsersTypeById(int id)
        {
            UsersType usersType = _usersTypeDl.GetUsersTypesById(id);
            return mapper.Map<UsersType, UsersTypeDTO>(usersType);
        }
    }
}
