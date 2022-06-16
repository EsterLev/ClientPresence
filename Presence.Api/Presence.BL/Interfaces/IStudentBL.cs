using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IStudentBL
    {
        void AddStudent(StudentDTO student);
        void DeleteStudent(int id);
        List<StudentDTO> GetAllStudents();
        StudentDTO GetStudentById(int id);
        void UpdateStudent(StudentDTO student, int id);
    }
}