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
    public class KindergartenBL : IKindergartenBL
    {
        private readonly IKindergartenDAL _kindergarten;
        IMapper mapper;
        public KindergartenBL(IKindergartenDAL kindergarten)
        {
            _kindergarten = kindergarten;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<KindergartenDTO> GetAllKindergartens()
        {
            List<Kindergarten> kindergartens = _kindergarten.GetAllKindergarten();
            return mapper.Map<List<Kindergarten>, List<KindergartenDTO>>(kindergartens);
        }

        public KindergartenDTO GetKindergartenById(int id)
        {
            Kindergarten kindergarten = _kindergarten.GetKindergartenById(id);
            return mapper.Map<Kindergarten, KindergartenDTO>(kindergarten);
        }
        public void AddKindergarten(KindergartenDTO kindergarten)
        {
            _kindergarten.AddKindergarten(mapper.Map<KindergartenDTO, Kindergarten>(kindergarten));
        }
        public void UpdateKindergarten(KindergartenDTO kindergarten, int id)
        {
            _kindergarten.UpdateKindergarten(mapper.Map<KindergartenDTO, Kindergarten>(kindergarten), id);
        }
        public void DeleteKindergarten(int id)
        {
            _kindergarten.DeleteKindergarten(id);
        }
    }
}
