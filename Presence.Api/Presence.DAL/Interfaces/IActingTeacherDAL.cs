using Presence.DAL.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presence.DAL.Classes
{
    public interface IActingTeacherDAL
    {
        Task AddActingTeacher(ActingTeacher actingTeacher);
        Task DeleteActingTeacher(int id);
        Task<ActingTeacher> GetActngTeacherById(int id);
        Task<List<ActingTeacher>> GetAllActingTeachers();
        Task UpdateActingTeacher(ActingTeacher actingTeacher, int id);
    }
}