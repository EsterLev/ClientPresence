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
    public class StudentBL : IStudentBL
    {
        private readonly IStudentDAL _studentDl;
        IMapper mapper;
        public StudentBL(IStudentDAL studentDl)
        {
            _studentDl = studentDl;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<StudentDTO> GetAllStudents()
        {
            List<Student> students = _studentDl.GetAllStudents();
            return mapper.Map<List<Student>, List<StudentDTO>>(students);
        }

        public StudentDTO GetStudentById(int id)
        {
            Student delaySchoolBus = _studentDl.GetStudentById(id);
            return mapper.Map<Student, StudentDTO>(delaySchoolBus);
        }
        public void AddStudent(StudentDTO student)
        {
            _studentDl.AddStudent(mapper.Map<StudentDTO, Student>(student));
        }
        public void UpdateStudent(StudentDTO student, int id)
        {
            _studentDl.UpdateStudent(mapper.Map<StudentDTO, Student>(student), id);
        }
        public void DeleteStudent(int id)
        {
            _studentDl.DeleteStudent(id);
        }
    }
}
