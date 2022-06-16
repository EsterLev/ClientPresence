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
    public class KindergartenPresenceBL : IKindergartenPresenceBL
    {
        private readonly IKindergartenPresenceDAL _kindergartenPresenceDl;
        IMapper mapper;
        public KindergartenPresenceBL(IKindergartenPresenceDAL kindergartenPresenceDl)
        {
            _kindergartenPresenceDl = kindergartenPresenceDl;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<KindergartenPresenceDTO> GetAllKindergartenPresences()
        {
            List<KindergartenPresence> kindergartenPresences = _kindergartenPresenceDl.GetAllKindergartenPresences();
            return mapper.Map<List<KindergartenPresence>, List<KindergartenPresenceDTO>>(kindergartenPresences);
        }

        public KindergartenPresenceDTO GetKindergartenPresenceById(int id)
        {
            KindergartenPresence kindergartenPresence = _kindergartenPresenceDl.GetKindergartenPresenceById(id);
            return mapper.Map<KindergartenPresence, KindergartenPresenceDTO>(kindergartenPresence);
        }
        public void AddKindergartenPresence(KindergartenPresenceDTO kindergartenPresence)
        {
            _kindergartenPresenceDl.AddKindergartenPresence(mapper.Map<KindergartenPresenceDTO, KindergartenPresence>(kindergartenPresence));
        }
        public void UpdateKindergartenPresence(KindergartenPresenceDTO kindergartenPresence, int id)
        {
            _kindergartenPresenceDl.UpdateKindergartenPresence(mapper.Map<KindergartenPresenceDTO, KindergartenPresence>(kindergartenPresence), id);
        }
        public void DeleteKindergartenPresence(int id)
        {
            _kindergartenPresenceDl.DeleteKindergartenPresence(id);
        }
    }
}
