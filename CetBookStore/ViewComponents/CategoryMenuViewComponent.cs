using CetBookStore.Data;
using CetBookStore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.ViewComponents
{
    public partial class CategoryMenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext context;

        public CategoryMenuViewComponent(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(bool forSearch = false)
        {
            var cats = await context.Categories.ToListAsync();
            if (forSearch)
            {
                return View("categorysearch", cats);
            }
            else
            {
                return View(cats);
            }

        }
    }
}