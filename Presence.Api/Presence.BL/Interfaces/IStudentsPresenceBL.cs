using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IStudentsPresenceBL
    {
        void AddStudentsPresence(StudentsPresenceDTO studentsPresence);
        void DeleteStudentsPresence(int id);
        List<StudentsPresenceDTO> GetAllStudentsPresences();
        StudentsPresenceDTO GetStudentsPresenceById(int id);
        void UpdateStudentsPresence(StudentsPresenceDTO studentsPresence, int id);
    }
}