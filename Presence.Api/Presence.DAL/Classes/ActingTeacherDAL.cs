using Microsoft.EntityFrameworkCore;
using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presence.DAL.Classes
{
    public class ActingTeacherDAL : IActingTeacherDAL
    {
        private readonly PRESENCEContext _context;
        public ActingTeacherDAL(PRESENCEContext c)
        {
            this._context = c;
        }
        public async Task<List<ActingTeacher>> GetAllActingTeachers()
        {
            return await _context.ActingTeachers.ToListAsync();
        }

        public async Task<ActingTeacher> GetActngTeacherById(int id)
        {
            ActingTeacher actingTeacher = await _context.ActingTeachers.FirstOrDefaultAsync(p => p.Id == id);
            return actingTeacher;
        }
        public async Task AddActingTeacher(ActingTeacher actingTeacher)
        {
            await _context.ActingTeachers.AddAsync(actingTeacher);
            _context.SaveChanges();
        }
        public async Task UpdateActingTeacher(ActingTeacher actingTeacher, int id)
        {

            ActingTeacher currentActingTeacher = await _context.ActingTeachers.FirstOrDefaultAsync(x => x.Id == id);
            //יש לזכור למחוק
            actingTeacher.Id = id;
            _context.Entry(currentActingTeacher).CurrentValues.SetValues(actingTeacher);
            _context.SaveChanges();

        }
        public async Task DeleteActingTeacher(int id)
        {
            ActingTeacher actingTeacher = await _context.ActingTeachers.FirstOrDefaultAsync(x => x.Id == id);
            _context.ActingTeachers.Remove(actingTeacher);
            _context.SaveChanges();
        }
    }
}
