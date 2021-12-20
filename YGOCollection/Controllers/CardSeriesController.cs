using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using YGOCollection.DTO;
using YGOCollection.Models;
using YGOCollection.Service.Interface;

namespace YGOCollection.Controllers
{
    public class CardSeriesController : Controller
    {
        private readonly IGenericService<CardSeriesDTO> _genericService;
        private readonly IMapper _mapper;

        public CardSeriesController(IGenericService<CardSeriesDTO> genericService, IMapper mapper) 
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var cardSeriesList = await _genericService.GetList();
            return View(_mapper.Map<List<CardSeriesViewModel>>(cardSeriesList));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SeriesName,SeriesCode")] CardSeriesViewModel cardSeriesViewModel)
        {
            if (ModelState.IsValid)
            {
                var cardSeriesDTO = _mapper.Map<CardSeriesDTO>(cardSeriesViewModel);
                await _genericService.AddData(cardSeriesDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(cardSeriesViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardSeries = await _genericService.GetDataById(id);
            if (cardSeries == null)
            {
                return NotFound();
            }
            return View(_mapper.Map<CardSeriesViewModel>(cardSeries));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SeriesName,SeriesCode")] CardSeriesViewModel cardSeriesViewModel)
        {
            if (id != cardSeriesViewModel.Id)
            {   
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var cardSeries = _mapper.Map<CardSeriesDTO>(cardSeriesViewModel);
                await _genericService.UpdateData(cardSeries);
                return RedirectToAction(nameof(Index));
            }

            return View(cardSeriesViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cardSeries = await _genericService.GetDataById(id);
            if (cardSeries == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<CardSeriesViewModel>(cardSeries));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _genericService.DeleteData(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
