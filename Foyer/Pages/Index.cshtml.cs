using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Foyer.Data;
using Foyer.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Foyer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly FoyerContext _context;

        public IndexModel(ILogger<IndexModel> logger, FoyerContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IEnumerable<Category> Categories { get; set; }

        public void OnGet()
        {
            Categories = GetCategories();
        }

        private IEnumerable<Category> GetCategories()
        {
            var categories = _context.Categories.OrderBy(c => c.Name);

            return categories.ToList();
        }

        public IEnumerable<Tile> GetTiles(int categoryId)
        {
            var tiles = _context.Tiles.Where(t => t.Category.Id == categoryId).OrderBy(t => t.Title);

            return tiles.ToList();
        }

        public string GetImageUrl(string url)
        {
            Uri uri = new Uri(url);
            return uri.GetLeftPart(UriPartial.Authority) + "/favicon.ico";
        }
    }
}
