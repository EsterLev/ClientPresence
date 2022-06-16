using Presence.DAL.Models;
using System.Collections.Generic;

namespace Presence.DAL.Classes
{
    public interface IBirthdayDAL
    {
        void AddBirthday(Birthday birthday);
        void DeleteBirthday(int id);
        List<Birthday> GetAllBirthdays();
        Birthday GetBirthdayById(int id);
        void UpdateBirthday(Birthday birthday, int id);
    }
}