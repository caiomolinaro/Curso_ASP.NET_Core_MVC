﻿using LanchesCM.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LanchesCM.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(C => C.CategoriaNome);
            return View(categorias);
        }
    }
}
