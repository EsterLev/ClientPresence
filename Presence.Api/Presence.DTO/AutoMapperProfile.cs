using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Presence.DAL.Models;

namespace DTO
{
    public class AutoMapperProfile : AutoMapper.Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
            CreateMap<UsersType, UsersTypeDTO>();
            //CreateMap<UsersTypeDTO, UsersType>();
            CreateMap<Parent, ParentDTO>();
            CreateMap<ParentDTO, Parent>();
            CreateMap<Connection, ConnectionDTO>();
            //CreateMap<ConnectionDTO, Connection>();
            CreateMap<PresenceType, PresenceTypeDTO>();
            //CreateMap<PresenceTypeDTO ,PresenceType > ();
            CreateMap<DelaySchoolBus, DelaySchoolBusDTO>();
            CreateMap<DelaySchoolBusDTO ,DelaySchoolBus > ();
            CreateMap<Student, StudentDTO>();
            CreateMap<StudentDTO, Student>();
            CreateMap<KindergartenPresence, KindergartenPresenceDTO>();
            CreateMap<KindergartenPresenceDTO, KindergartenPresence>();
            CreateMap<StudentsPresence, StudentsPresenceDTO>();
            CreateMap<StudentsPresenceDTO, StudentsPresence>();
            CreateMap<Kindergarten, KindergartenDTO>();
            CreateMap<KindergartenDTO, Kindergarten>();
            CreateMap<Reminder, ReminderDTO>();
            CreateMap<ReminderDTO, Reminder>();
            CreateMap<ActingTeacher, ActingTeacherDTO>();
            CreateMap<ActingTeacherDTO, ActingTeacher>();
            CreateMap<Birthday, BirthdayDTO>();
            CreateMap<BirthdayDTO, Birthday>();
        }
    }
}
