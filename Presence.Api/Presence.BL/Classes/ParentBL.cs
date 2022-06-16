using AutoMapper;
using DTO;
using Presence.DAL;
using Presence.DAL.Models;
using Presence.DTO.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Presence.BL
{
    public class ParentBL : IParentBL
    {
        private readonly IParentDAL _parentDl;
        IMapper mapper;
        public ParentBL(IParentDAL parentDAL)
        {
            _parentDl = parentDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();
            });
            mapper = config.CreateMapper();
        }
        public List<ParentDTO> GetAllParents()
        {
            List<Parent> parents = _parentDl.GetAllParents();
            return mapper.Map<List<Parent>, List<ParentDTO>>(parents);
        }

        public ParentDTO GetParentById(int id)
        {
            Parent parent = _parentDl.GetParentById(id);
            return mapper.Map<Parent, ParentDTO>(parent);
        }
        public void AddParent(ParentDTO parent)
        {
            _parentDl.AddParent(mapper.Map<ParentDTO, Parent>(parent));
        }
        public void UpdateParent(ParentDTO parent, int id)
        {
            _parentDl.UpdateParent(mapper.Map<ParentDTO, Parent>(parent),id);
        }
        public void DeleteParent(int id)
        {
            _parentDl.DeleteParent(id);
        }
    }
}
