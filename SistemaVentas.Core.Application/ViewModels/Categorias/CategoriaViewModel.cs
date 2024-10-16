﻿using SistemaVentas.Core.Application.ViewModels.Products;

namespace StockApp.Core.Application.ViewModels.Categories
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public ICollection<ProductoViewModel> Productos { get; set; }

    }
}