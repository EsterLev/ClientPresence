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
    public class ConnectionBL : IConnectionBL
    {
        private readonly IConnectionDAL _connectionDl;
        IMapper mapper;
        public ConnectionBL(IConnectionDAL connectionDAL)
        {
            _connectionDl = connectionDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<ConnectionDTO> GetAllConnections()
        {
            List<Connection> connections = _connectionDl.GetAllConnections();
            return mapper.Map<List<Connection>, List<ConnectionDTO>>(connections);
        }

        public ConnectionDTO GetConnectionById(int id)
        {
            Connection connection = _connectionDl.GetConnectionById(id);
            return mapper.Map<Connection, ConnectionDTO>(connection);
        }
    }
}
