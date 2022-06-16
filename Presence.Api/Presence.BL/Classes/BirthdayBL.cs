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
    public class BirthdayBL : IBirthdayBL
    {
        private readonly IBirthdayDAL _birthday;
        IMapper mapper;
        public BirthdayBL(IBirthdayDAL birthday)
        {
            _birthday = birthday;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<BirthdayDTO> GetAllBirthday()
        {
            List<Birthday> birthdays = _birthday.GetAllBirthdays();
            return mapper.Map<List<Birthday>, List<BirthdayDTO>>(birthdays);
        }

        public BirthdayDTO GetBirthdayById(int id)
        {
            Birthday birthday = _birthday.GetBirthdayById(id);
            return mapper.Map<Birthday, BirthdayDTO>(birthday);
        }
        public void AddBirthday(BirthdayDTO birthday)
        {
            _birthday.AddBirthday(mapper.Map<BirthdayDTO, Birthday>(birthday));
        }
        public void UpdateBirthday(BirthdayDTO birthday, int id)
        {
            _birthday.UpdateBirthday(mapper.Map<BirthdayDTO, Birthday>(birthday), id);
        }
        public void DeleteBirthday(int id)
        {
            _birthday.DeleteBirthday(id);
        }
    }
}
