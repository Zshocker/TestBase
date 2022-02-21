using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TestAuth.Data;
using TestBase.Models;

namespace TestAuth.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly TestAuth.Data.AllContext _context;

        public DetailsModel(TestAuth.Data.AllContext context)
        {
            _context = context;
        }

        public Etudiant Etudiant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");
            if (id == null)
            {
                return NotFound();
            }

            Etudiant = await _context.etudiants.FirstOrDefaultAsync(m => m.id == id);

            if (Etudiant == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
