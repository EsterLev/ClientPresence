using AutoMapper;
using DTO;
using Presence.DAL.Classes;
using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Presence.BL.Classes
{
    public class ActingTeacherBL : IActingTeacherBL
    {
        private readonly IActingTeacherDAL _actingTeacher;
        IMapper mapper;
        public ActingTeacherBL(IActingTeacherDAL actingTeacher)
        {
            _actingTeacher = actingTeacher;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public async Task<List<ActingTeacherDTO>> GetAllActingTeachers()
        {
            List<ActingTeacher> actingTeachers = await _actingTeacher.GetAllActingTeachers();
            return mapper.Map<List<ActingTeacher>, List<ActingTeacherDTO>>(actingTeachers);
        }

        public async Task<ActingTeacherDTO> GetActingTeacherById(int id)
        {
            ActingTeacher actingTeacher = await _actingTeacher.GetActngTeacherById(id);
            return mapper.Map<ActingTeacher, ActingTeacherDTO>(actingTeacher);
        }
        public async Task AddActingTeacher(ActingTeacherDTO actingTeacher)
        {
            await _actingTeacher.AddActingTeacher(mapper.Map<ActingTeacherDTO, ActingTeacher>(actingTeacher));
        }
        public async Task UpdateActingTeacher(ActingTeacherDTO actingTeacher, int id)
        {
            await _actingTeacher.UpdateActingTeacher(mapper.Map<ActingTeacherDTO, ActingTeacher>(actingTeacher), id);
        }
        public async Task DeleteActingTeacher(int id)
        {
            await _actingTeacher.DeleteActingTeacher(id);
        }
    }
}
