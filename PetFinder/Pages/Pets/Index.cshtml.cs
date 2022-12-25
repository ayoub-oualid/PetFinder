using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PetFinder.Data;
using PetFinder.Models;

namespace PetFinder.Pages.Pets
{
    public class IndexModel : PageModel
    {
        private readonly PetFinder.Data.PetFinderContext _context;

        public IndexModel(PetFinder.Data.PetFinderContext context)
        {
            _context = context;
        }

        public IList<Pet> Pet { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pet != null)
            {
                Pet = await _context.Pet.ToListAsync();
            }
        }
    }
}
