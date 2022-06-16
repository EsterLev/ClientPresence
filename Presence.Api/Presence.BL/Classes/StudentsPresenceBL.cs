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
    public class StudentsPresenceBL : IStudentsPresenceBL
    {
        private readonly IStudentsPresenceDAL _studentsPresenceDl;
        IMapper mapper;
        public StudentsPresenceBL(IStudentsPresenceDAL studentsPresenceDl)
        {
            _studentsPresenceDl = studentsPresenceDl;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<StudentsPresenceDTO> GetAllStudentsPresences()
        {
            List<StudentsPresence> studentsPresences = _studentsPresenceDl.GetAllStudentsPresences();
            return mapper.Map<List<StudentsPresence>, List<StudentsPresenceDTO>>(studentsPresences);
        }

        public StudentsPresenceDTO GetStudentsPresenceById(int id)
        {
            StudentsPresence studentsPresence = _studentsPresenceDl.GetStudentsPresenceById(id);
            return mapper.Map<StudentsPresence, StudentsPresenceDTO>(studentsPresence);
        }
        public void AddStudentsPresence(StudentsPresenceDTO studentsPresence)
        {
            _studentsPresenceDl.AddStudentsPresence(mapper.Map<StudentsPresenceDTO, StudentsPresence>(studentsPresence));
        }
        public void UpdateStudentsPresence(StudentsPresenceDTO studentsPresence, int id)
        {
            _studentsPresenceDl.UpdateStudentsPresence(mapper.Map<StudentsPresenceDTO, StudentsPresence>(studentsPresence), id);
        }
        public void DeleteStudentsPresence(int id)
        {
            _studentsPresenceDl.DeleteStudentsPresence(id);
        }
    }
}
