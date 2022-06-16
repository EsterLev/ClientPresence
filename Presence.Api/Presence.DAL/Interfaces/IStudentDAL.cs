using System.Collections.Generic;
using Presence.DAL.Models;

namespace Presence.DAL.Classes
{
    public interface IStudentDAL
    {
        void AddStudent(Student student);
        void DeleteStudent(int id);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
        void UpdateStudent(Student student, int id);
    }
}