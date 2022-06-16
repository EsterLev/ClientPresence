using Presence.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Presence.DAL.Classes
{
    public class BirthdayDAL : IBirthdayDAL
    {
        private readonly PRESENCEContext _context;
        public BirthdayDAL(PRESENCEContext c)
        {
            this._context = c;
        }
        public List<Birthday> GetAllBirthdays()
        {
            return _context.Birthdays.ToList();
        }

        public Birthday GetBirthdayById(int id)
        {
            Birthday birthday = _context.Birthdays.FirstOrDefault(p => p.Id == id);
            return birthday;
        }
        public void AddBirthday(Birthday birthday)
        {
            if (!IsValid(birthday))
                throw new Exception("the field 'IsPossible' equals true, so you need to fill all the fields that dependencies him");
            _context.Birthdays.Add(birthday);
            _context.SaveChanges();
        }
        public void UpdateBirthday(Birthday birthday, int id)
        {
            if (!IsValid(birthday))
                throw new Exception("the field 'IsPossible' equals true, so you need to fill all the fields that dependencies him");
            Birthday currentBirthday = _context.Birthdays.Where(x => x.Id == id).FirstOrDefault();
            //יש לזכור למחוק
            birthday.Id = id;
            _context.Entry(currentBirthday).CurrentValues.SetValues(birthday);
            _context.SaveChanges();

        }
        public void DeleteBirthday(int id)
        {
            Birthday birthday = _context.Birthdays.Where(x => x.Id == id).FirstOrDefault();
            _context.Birthdays.Remove(birthday);
            _context.SaveChanges();
        }
        //function that checks validations if IsPossible field equals true (does like required fields)
        public bool IsValid(Birthday birthday)
        {
            if (birthday.IsPossible)
            {
                if (birthday.HebrewDate == null || birthday.BirthdayPerMonth == null)
                {
                    return false;
                }
                else
                {
                    if (birthday.BirthdayPerMonth == true)
                    {
                        if ((birthday.DayByMonth != null && birthday.DayByWeek == null) || (birthday.DayByMonth == null && birthday.DayByWeek != null))
                        {
                            return true;
                        }
                        return false;
                    }
                    else
                    {
                        if ((birthday.DayByMonth != null && birthday.DayByWeek == null && birthday.NumDaysBefore == null) || (birthday.DayByMonth == null && birthday.DayByWeek != null && birthday.NumDaysBefore == null) || (birthday.DayByMonth == null && birthday.DayByWeek == null && birthday.NumDaysBefore != null))
                            return true;
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
