using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IStudentsPresenceDAL
    {
        void AddStudentsPresence(StudentsPresence studentsPresence);
        void DeleteStudentsPresence(int id);
        List<StudentsPresence> GetAllStudentsPresences();
        StudentsPresence GetStudentsPresenceById(int id);
        void UpdateStudentsPresence(StudentsPresence studentsPresence, int id);
    }
}