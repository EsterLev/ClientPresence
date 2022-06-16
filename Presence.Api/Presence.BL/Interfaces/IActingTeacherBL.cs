using Presence.DTO.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Presence.BL.Classes
{
    public interface IActingTeacherBL
    {
        Task AddActingTeacher(ActingTeacherDTO actingTeacher);
        Task DeleteActingTeacher(int id);
        Task<ActingTeacherDTO> GetActingTeacherById(int id);
        Task<List<ActingTeacherDTO>> GetAllActingTeachers();
        Task UpdateActingTeacher(ActingTeacherDTO actingTeacher, int id);
    }
}