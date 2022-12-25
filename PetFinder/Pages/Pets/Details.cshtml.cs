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
    public class DetailsModel : PageModel
    {
        private readonly PetFinder.Data.PetFinderContext _context;

        public DetailsModel(PetFinder.Data.PetFinderContext context)
        {
            _context = context;
        }

      public Pet Pet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Pet == null)
            {
                return NotFound();
            }

            var pet = await _context.Pet.FirstOrDefaultAsync(m => m.Id == id);
            if (pet == null)
            {
                return NotFound();
            }
            else 
            {
                Pet = pet;
            }
            return Page();
        }
    }
}
