using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Service.Interface;
using AutoMapper;
using YGOCollection.Repository.Interface;
using YGOCollection.Repository.DataModels;

namespace YGOCollection.Service
{
    public class CardInfoService : IGenericService<CardInfoDTO>
    {
        private readonly IGenericRepository<CardInfo> _genericRepository;
        private readonly IMapper _mapper;

        public CardInfoService(IGenericRepository<CardInfo> genericRepository, IMapper mapper) 
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task AddData(CardInfoDTO model)
        {
            var cardInfoEntity = _mapper.Map<CardInfo>(model);
            await _genericRepository.Add(cardInfoEntity);
        }

        public async Task DeleteData(int? id)
        {
            var cardInfoEntity = await _genericRepository.GetById(id);
            await _genericRepository.Delete(cardInfoEntity);
        }
        public async Task SoftDeleteData(int? id)
        {
            var cardInfoEntity = await _genericRepository.GetById(id);
            cardInfoEntity.IsDelete = true;
            await _genericRepository.Delete(cardInfoEntity);
        }

        public async Task<CardInfoDTO>  GetDataById(int? id)
        {
            var cardInfo = await _genericRepository.GetById(id);
            return _mapper.Map<CardInfoDTO>(cardInfo);
        }

        public async Task<IEnumerable<CardInfoDTO>> GetList()
        {
            var CardInfoList = await _genericRepository.GetList();
            return _mapper.Map<List<CardInfoDTO>>(CardInfoList);
        }

        public async Task UpdateData(CardInfoDTO model)
        {
            var cardInfoEntity = _mapper.Map<CardInfo>(model);
            await _genericRepository.Update(cardInfoEntity);
        }
    }
}
