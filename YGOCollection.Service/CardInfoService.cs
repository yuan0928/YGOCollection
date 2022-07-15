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
        private readonly IUnitOfWork<CardInfo> _unitOfWork;
        private readonly IMapper _mapper;

        public CardInfoService(IUnitOfWork<CardInfo> unitOfWork, IMapper mapper) 
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task AddData(CardInfoDTO model)
        {
            var cardInfoEntity = _mapper.Map<CardInfo>(model);
            await _unitOfWork.GenericRepository.Add(cardInfoEntity);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteData(int? id)
        {
            var cardInfoEntity = await _unitOfWork.GenericRepository.GetById(id);
            _unitOfWork.GenericRepository.Delete(cardInfoEntity);
            await _unitOfWork.SaveChanges();
        }
        public async Task SoftDeleteData(int? id)
        {
            var cardInfoEntity = await _unitOfWork.GenericRepository.GetById(id);
            cardInfoEntity.IsDelete = true;
            _unitOfWork.GenericRepository.Delete(cardInfoEntity);
            await _unitOfWork.SaveChanges();
        }

        public async Task<CardInfoDTO>  GetDataById(int? id)
        {
            var cardInfo = await _unitOfWork.GenericRepository.GetById(id);
            return _mapper.Map<CardInfoDTO>(cardInfo);
        }

        public async Task<IEnumerable<CardInfoDTO>> GetList()
        {
            var CardInfoList = await _unitOfWork.GenericRepository.GetList();
            return _mapper.Map<List<CardInfoDTO>>(CardInfoList);
        }

        public async Task<IEnumerable<CardInfoDTO>> GetListBy(int condition)
        {
            var CardInfoList = await _unitOfWork.GenericRepository.GetListBy(condition);
            return _mapper.Map<List<CardInfoDTO>>(CardInfoList);
        }

        public async Task UpdateData(CardInfoDTO model)
        {
            var cardInfoEntity = _mapper.Map<CardInfo>(model);
            _unitOfWork.GenericRepository.Update(cardInfoEntity);
            await _unitOfWork.SaveChanges();
        }

    }
}
