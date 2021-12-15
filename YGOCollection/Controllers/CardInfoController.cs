using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Service.Interface;

namespace YGOCollection.Controllers
{
    public class CardInfoController : Controller
    {
        private readonly IGenericService<CardInfoDTO> _genericService;
        private readonly IMapper _mapper;
        public CardInfoController(IGenericService<CardInfoDTO> genericService, IMapper mapper) 
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
