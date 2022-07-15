using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Models;
using YGOCollection.Service.Interface;

namespace YGOCollection.Controllers
{
    public class CardInfoController : Controller
    {
        private readonly IGenericService<CardInfoDTO> _cardInfoService;
        private readonly IGenericService<CardSeriesDTO> _cardSeriesService;
        private readonly IGenericService<CardTypeDTO> _cardTypeService;
        private readonly IMapper _mapper;
        public CardInfoController(IGenericService<CardInfoDTO> cardInfoService, IGenericService<CardSeriesDTO> cardSeriesService, IGenericService<CardTypeDTO> cardTypeService, IMapper mapper) 
        {
            _cardInfoService = cardInfoService;
            _cardSeriesService = cardSeriesService;
            _cardTypeService = cardTypeService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var cardInfoList = await _cardInfoService.GetList();
            return View(_mapper.Map<IEnumerable<CardInfoViewModel>>(cardInfoList));
        }
        public async Task<IActionResult> SeriesInfo(int seriesId)
        {
            var cardInfoList = await _cardInfoService.GetListBy(seriesId);
            ViewData["CardSeriesInfo"] = _mapper.Map<CardSeriesViewModel>(await _cardSeriesService.GetDataById(seriesId));
            return View(_mapper.Map<IEnumerable<CardInfoViewModel>>(cardInfoList));
        }
        public async Task<IActionResult> Create()
        {
            var cardSeriesList = await _cardSeriesService.GetList();
            var cardTypeList = await _cardTypeService.GetList();
            ViewData["CardSeriesId"] = new SelectList(_mapper.Map<IEnumerable<CardSeriesViewModel>>(cardSeriesList), "Id", "SeriesCode");
            ViewData["CardTypeId"] = new SelectList(_mapper.Map<IEnumerable<CardTypeViewModel>>(cardTypeList), "Id", "TypeName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CardTypeId,CardSeriesId,SeriesNum,CardPassword,ImagePath")] CardInfoViewModel cardInfoViewModel)
        {
            if (ModelState.IsValid)
            {
                var cardInfoDTO = _mapper.Map<CardInfoDTO>(cardInfoViewModel);
                await _cardInfoService.AddData(cardInfoDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(cardInfoViewModel);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cardInfo = await _cardInfoService.GetDataById(id);
            if (cardInfo == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<CardInfoViewModel>(cardInfo));
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardInfo = await _cardInfoService.GetDataById(id);
            if (cardInfo == null)
            {
                return NotFound();
            }
            var cardSeriesList = await _cardSeriesService.GetList();
            var cardTypeList = await _cardTypeService.GetList();
            ViewData["CardSeriesId"] = new SelectList(_mapper.Map<IEnumerable<CardSeriesViewModel>>(cardSeriesList), "Id", "SeriesCode",cardInfo.CardSeriesId);
            ViewData["CardTypeId"] = new SelectList(_mapper.Map<IEnumerable<CardTypeViewModel>>(cardTypeList), "Id", "TypeName",cardInfo.CardTypeId);
            return View(_mapper.Map<CardInfoViewModel>(cardInfo));
        }

        // POST: CardInfoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CardTypeId,CardSeriesId,SeriesNum,CardPassword,ImagePath")] CardInfoViewModel cardInfoViewModel)
        {
            if (id != cardInfoViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                var cardInfo = _mapper.Map<CardInfoDTO>(cardInfoViewModel);
                await _cardInfoService.UpdateData(cardInfo);
                return RedirectToAction(nameof(Index));
            }
            var cardSeriesList = await _cardSeriesService.GetList();
            var cardTypeList = await _cardTypeService.GetList();
            ViewData["CardSeriesId"] = new SelectList(_mapper.Map<IEnumerable<CardSeriesViewModel>>(cardSeriesList), "Id", "SeriesName", cardInfoViewModel.CardSeriesId);
            ViewData["CardTypeId"] = new SelectList(_mapper.Map<IEnumerable<CardTypeViewModel>>(cardTypeList), "Id", "TypeName", cardInfoViewModel.CardTypeId);
            return View(cardInfoViewModel);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cardInfo = await _cardInfoService.GetDataById(id);
            if (cardInfo == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<CardInfoViewModel>(cardInfo));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _cardInfoService.DeleteData(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
