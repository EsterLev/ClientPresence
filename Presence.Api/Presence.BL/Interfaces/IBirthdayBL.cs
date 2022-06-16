using Presence.DTO.Models;
using System.Collections.Generic;

namespace Presence.BL.Classes
{
    public interface IBirthdayBL
    {
        void AddBirthday(BirthdayDTO birthday);
        void DeleteBirthday(int id);
        List<BirthdayDTO> GetAllBirthday();
        BirthdayDTO GetBirthdayById(int id);
        void UpdateBirthday(BirthdayDTO birthday, int id);
    }
}