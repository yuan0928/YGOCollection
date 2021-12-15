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
        private readonly IGenericRepository<CardSeries> _genericRepository;
        private readonly IMapper _mapper;
        public CardSeriesService(IGenericRepository<CardSeries> genericRepository, IMapper mapper) 
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }
        public async Task AddData(CardSeriesDTO model)
        {
            var cardSeriesEntity = _mapper.Map<CardSeries>(model);
            await _genericRepository.Add(cardSeriesEntity);
        }

        public async Task DeleteData(CardSeriesDTO model)
        {
            var cardSeriesEntity = _mapper.Map<CardSeries>(model);
            await _genericRepository.Delete(cardSeriesEntity);
        }

        public async Task<CardSeriesDTO> GetDataById(int? id)
        {
            var CardSeries = await _genericRepository.GetById(id);
            return _mapper.Map<CardSeriesDTO>(CardSeries);
        }

        public async Task<IEnumerable<CardSeriesDTO>> GetList()
        {
            var cardSeriesList = await _genericRepository.GetList();
            return _mapper.Map<List<CardSeriesDTO>>(cardSeriesList);
        }

        public async Task UpdateData(CardSeriesDTO model)
        {
            var cardSeriesEntity = _mapper.Map<CardSeries>(model);
            await _genericRepository.Update(cardSeriesEntity);
        }
    }
}
