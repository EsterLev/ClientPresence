using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL
{
    public class UsersTypeDAL : IUsersTypeDAL
    {
        private readonly PRESENCEContext _context;
        public UsersTypeDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<UsersType> GetAllUsersTypes()
        {
            return _context.UsersTypes.ToList();
        }

        public UsersType GetUsersTypesById(int id)
        {
            UsersType usersType = _context.UsersTypes.FirstOrDefault(u => u.Id == id);
            return usersType;
        }
    }
}
