using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Presence.DAL.Models;

namespace Presence.DAL.Classes
{
    public class StudentDAL : IStudentDAL
    {
        private readonly PRESENCEContext _context;
        public StudentDAL(PRESENCEContext context)
        {
            _context = context;
        }
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            Student student = _context.Students.FirstOrDefault(p => p.Id == id);
            return student;
        }
        public void AddStudent(Student student)
        {
            if (!IsValid(student))
                throw new Exception("you must fill at least one from parents details");
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void UpdateStudent(Student student, int id)
        {
            if (!IsValid(student))
                throw new Exception("you must fill at least one from parents details");
            Student currentStudent = _context.Students.Where(x => x.Id == id).FirstOrDefault();
            //למחוק!
            student.Id = id;
            _context.Entry(currentStudent).CurrentValues.SetValues(student);
            _context.SaveChanges();

        }
        public void DeleteStudent(int id)
        {
            Student student = _context.Students.Where(x => x.Id == id).FirstOrDefault();
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        public bool IsValid(Student student)
        {
            if (student.FatherId != null||student.MotherId != null)
                return true;
            return false;
        }
    }
}
