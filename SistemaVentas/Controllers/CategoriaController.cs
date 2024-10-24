using Microsoft.AspNetCore.Mvc;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Categories;
using WebApp.SistemaVentas.Helpers;

namespace WebApp.SistemaVentas.Controllers
{
    public class CategoriaController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoriaController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return View(await categoryService.GetAllAsync());
        }

        public IActionResult Create()
        {
            return View("SaveCategoria", new SaveCategoriaViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Create(SaveCategoriaViewModel saveCategoriaVM)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveCategoria", saveCategoriaVM);
            }
            await categoryService.AddAsync(saveCategoriaVM);

            return RedirectionRoutes.CategoryIndex;
        }

        public async Task<IActionResult> Edit(int id)
        {
            var categoria= await  categoryService.GetById(id);
            return View("SaveCategoria", categoria);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SaveCategoriaViewModel saveCategoriaVM)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveCategoria", saveCategoriaVM);
            }
            await categoryService.UpdateAsync(saveCategoriaVM,saveCategoriaVM.Id);

            return RedirectionRoutes.CategoryIndex;
        }

        public async Task<IActionResult> Delete(int id)
        {
            var categoria = await categoryService.GetById(id);
            return View(categoria);
        }

        [HttpPost]
        public async Task<IActionResult> DeletePost(int id)
        {

            await categoryService.DeleteAsync(id);

            return RedirectionRoutes.CategoryIndex;
        }
    }
}
