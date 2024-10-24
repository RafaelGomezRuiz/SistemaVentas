using Microsoft.AspNetCore.Mvc;
using SistemaVentas.Core.Application.Interfaces.Services;
using SistemaVentas.Core.Application.ViewModels.Products;
using WebApp.SistemaVentas.Helpers;

namespace WebApp.SistemaVentas.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService _productoService;

        public ProductoController(IProductoService _productoService)
        {
            this._productoService = _productoService;
        }


        public IActionResult Home()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("SaveProducto", new SaveProductoViewModel());
        }
        public async Task<IActionResult> Create(SaveProductoViewModel productSVM)
        {
            if (!ModelState.IsValid)
            {
                return View("SaveProducto",productSVM);
            }
            await _productoService.AddAsync(productSVM);
            return RedirectionRoutes.ProductHome;
        }

    }
}
