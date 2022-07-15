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
    public class CardSeriesService : IGenericService<CardSeriesDTO>
    {
        private readonly IUnitOfWork<CardSeries> _unitOfWork;
        private readonly IMapper _mapper;
        public CardSeriesService(IMapper mapper, IUnitOfWork<CardSeries> unitOfWork) 
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public async Task AddData(CardSeriesDTO model)
        {
            var cardSeriesEntity = _mapper.Map<CardSeries>(model);
            //await _genericRepository.Add(cardSeriesEntity);
            await _unitOfWork.GenericRepository.Add(cardSeriesEntity);
            await _unitOfWork.SaveChanges();
        }

        public async Task DeleteData(int? id)
        {
            var cardSeriesEntity = await _unitOfWork.GenericRepository.GetById(id);
            _unitOfWork.GenericRepository.Delete(cardSeriesEntity);
            await _unitOfWork.SaveChanges();
        }
        public async Task SoftDeleteData(int? id)
        {
            var cardSeriesEntity = await _unitOfWork.GenericRepository.GetById(id);
            cardSeriesEntity.IsDelete = true;
            _unitOfWork.GenericRepository.SoftDelete(cardSeriesEntity);
            await _unitOfWork.SaveChanges();
        }

        public async Task<CardSeriesDTO> GetDataById(int? id)
        {
            var CardSeries = await _unitOfWork.GenericRepository.GetById(id);
            return _mapper.Map<CardSeriesDTO>(CardSeries);
        }

        public async Task<IEnumerable<CardSeriesDTO>> GetList()
        {
            var cardSeriesList = await _unitOfWork.GenericRepository.GetList();
            return _mapper.Map<List<CardSeriesDTO>>(cardSeriesList.Where(x => x.IsDelete == false));
        }
        public Task<IEnumerable<CardSeriesDTO>> GetListBy(int condition)
        {
            throw new NotImplementedException();
        }
        public async Task UpdateData(CardSeriesDTO model)
        {
            var cardSeriesEntity = _mapper.Map<CardSeries>(model);
            _unitOfWork.GenericRepository.Update(cardSeriesEntity);
            await _unitOfWork.SaveChanges();
        }


    }
}
