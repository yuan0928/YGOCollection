using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Repository.DataModels;

namespace YGOCollection.Models.AutoMapper
{
    public class UseProfile : Profile
    {
        public UseProfile()
        {
            //View to Service
            CreateMap<CardInfoViewModel, CardInfoDTO>();
            CreateMap<CardSeriesViewModel, CardSeriesDTO>();

            //Service to View
            CreateMap<CardInfoDTO, CardInfoViewModel>();
            CreateMap<CardSeriesDTO, CardSeriesViewModel>();

            //Entity To Service
            CreateMap<CardInfo, CardInfoDTO>();
            CreateMap<CardSeries, CardSeriesDTO>();

            //Service To Entity
            CreateMap<CardInfoDTO, CardInfo>();
            CreateMap<CardSeriesDTO, CardSeries>();
        }
           
    }
}
