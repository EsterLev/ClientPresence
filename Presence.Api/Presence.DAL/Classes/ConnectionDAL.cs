using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class ConnectionDAL : IConnectionDAL
    {
        private readonly PRESENCEContext _context;
        public ConnectionDAL(PRESENCEContext presenceContext)
        {
            _context = presenceContext;
        }
        public List<Connection> GetAllConnections()
        {
            return _context.Connections.ToList();
        }

        public Connection GetConnectionById(int id)
        {
            Connection connection = _context.Connections.FirstOrDefault(c => c.Id == id);
            return connection;
        }
    }
}
