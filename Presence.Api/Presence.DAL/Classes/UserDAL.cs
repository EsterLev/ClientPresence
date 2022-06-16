using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL
{
    public class UserDAL : IUserDAL
    {
        private readonly PRESENCEContext _context;
        public UserDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public User GetUserById(int id)
        {
            User user = _context.Users.FirstOrDefault(u => u.Id == id);
            return user;
        }
        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void UpdateUser(User user, int id)
        {
            User currentUser = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            //יש לזכור למחוק
            user.Id = id;
            _context.Users.Update(currentUser).CurrentValues.SetValues(user);
            _context.SaveChanges();
        }
        public void DeleteUser(int id)
        {
            User user = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            _context.Users.Remove(user);
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}