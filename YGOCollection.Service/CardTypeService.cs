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
        private readonly IUnitOfWork<CardType> _unitOfWork;
        private readonly IMapper _mapper;
        public CardTypeService(IUnitOfWork<CardType> unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task AddData(CardTypeDTO model)
        {
            var cardTypeEntity = _mapper.Map<CardType>(model);
            await _unitOfWork.GenericRepository.Add(cardTypeEntity);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteData(int? id)
        {
            var cardTypeEntity = await _unitOfWork.GenericRepository.GetById(id);
            _unitOfWork.GenericRepository.Delete(cardTypeEntity);
            await _unitOfWork.SaveChanges();
        }
        public async Task SoftDeleteData(int? id)
        {
            var cardSeriesEntity = await _unitOfWork.GenericRepository.GetById(id);
            cardSeriesEntity.IsDelete = true;
            _unitOfWork.GenericRepository.SoftDelete(cardSeriesEntity);
            await _unitOfWork.SaveChanges();
        }

        public async Task<CardTypeDTO> GetDataById(int? id)
        {
            var cardType = await _unitOfWork.GenericRepository.GetById(id);
            return _mapper.Map<CardTypeDTO>(cardType);
        }

        public async Task<IEnumerable<CardTypeDTO>> GetList()
        {
            var cardTypeList = await _unitOfWork.GenericRepository.GetList();
            return _mapper.Map<List<CardTypeDTO>>(cardTypeList);
        }

        public Task<IEnumerable<CardTypeDTO>> GetListBy(int condition)
        {
            throw new NotImplementedException();
        }

        public async Task UpdateData(CardTypeDTO model)
        {
            var cardTypeEntity = _mapper.Map<CardType>(model);
            _unitOfWork.GenericRepository.Update(cardTypeEntity);
            await _unitOfWork.SaveChanges();
        }

    }
}
