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
    public class CardTypeController : Controller
    {
        private readonly IGenericService<CardTypeDTO> _genericService;
        private readonly IMapper _mapper;

        public CardTypeController(IGenericService<CardTypeDTO> genericService, IMapper mapper)
        {
            _genericService = genericService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var cardTypeList = await _genericService.GetList();
            return View(_mapper.Map<List<CardTypeViewModel>>(cardTypeList));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TypeName")] CardTypeViewModel cardTypeViewModel)
        {
            if (ModelState.IsValid)
            {
                var cardTypeDTO = _mapper.Map<CardTypeDTO>(cardTypeViewModel);
                await _genericService.AddData(cardTypeDTO);
                return RedirectToAction(nameof(Index));
            }
            return View(cardTypeViewModel);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cardType = await _genericService.GetDataById(id);
            if (cardType == null)
            {
                return NotFound();
            }
            return View(_mapper.Map<CardTypeViewModel>(cardType));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TypeName")] CardTypeViewModel cardTypeViewModel)
        {
            if (id != cardTypeViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                var cardType = _mapper.Map<CardTypeDTO>(cardTypeViewModel);
                await _genericService.UpdateData(cardType);
                return RedirectToAction(nameof(Index));
            }

            return View(cardTypeViewModel);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var cardType = await _genericService.GetDataById(id);
            if (cardType == null)
            {
                return NotFound();
            }

            return View(_mapper.Map<CardTypeViewModel>(cardType));
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cardType = await _genericService.GetDataById(id);
            await _genericService.DeleteData(cardType);
            return RedirectToAction(nameof(Index));
        }
    }
}
