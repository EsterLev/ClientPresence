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
    public class UserBL : IUserBL
    {
        private readonly IUserDAL _userDl;
        IMapper mapper;
        public UserBL(IUserDAL userDAL)
        {
            _userDl = userDAL;
            var config = new MapperConfiguration(cfg =>
              {
                  cfg.AddProfile<AutoMapperProfile>();
              });
            mapper = config.CreateMapper();
        }
        public List<UserDTO> GetAllUsers()
        {
            List<User> users = _userDl.GetAllUsers();
            return mapper.Map<List<User>, List<UserDTO>>(users);
        }

        public UserDTO GetUserById(int id)
        {
            User user = _userDl.GetUserById(id);
            return mapper.Map<User, UserDTO>(user);
        }

        public void AddUser(UserDTO user)
        {
            _userDl.AddUser(mapper.Map<UserDTO, User>(user));
        }
        public void UpdateUser(UserDTO user, int id)
        {
            _userDl.UpdateUser(mapper.Map<UserDTO, User>(user), id);
        }
        public void DeleteUser(int id)
        {
            _userDl.DeleteUser(id);
        }
    }
}
