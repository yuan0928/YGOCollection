using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Repository.DataModels;
using YGOCollection.Repository.Interface;
using YGOCollection.Service.Interface;

namespace YGOCollection.Service
{
    public class CardTypeService : IGenericService<CardTypeDTO>
    {
        private readonly IGenericRepository<CardType> _genericRepository;
        private readonly IMapper _mapper;
        public CardTypeService(IGenericRepository<CardType> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public async Task AddData(CardTypeDTO model)
        {
            var cardTypeEntity = _mapper.Map<CardType>(model);
            await _genericRepository.Add(cardTypeEntity);
        }

        public async Task DeleteData(CardTypeDTO model)
        {
            var cardTypeEntity = _mapper.Map<CardType>(model);
            await _genericRepository.Delete(cardTypeEntity);
        }

        public async Task<CardTypeDTO> GetDataById(int? id)
        {
            var cardType = await _genericRepository.GetById(id);
            return _mapper.Map<CardTypeDTO>(cardType);
        }

        public async Task<IEnumerable<CardTypeDTO>> GetList()
        {
            var cardTypeList = await _genericRepository.GetList();
            return _mapper.Map<List<CardTypeDTO>>(cardTypeList);
        }

        public async Task UpdateData(CardTypeDTO model)
        {
            var cardTypeEntity = _mapper.Map<CardType>(model);
            await _genericRepository.Update(cardTypeEntity);
        }
    }
}
