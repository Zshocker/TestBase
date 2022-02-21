using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestAuth.Data;
using TestBase.Models;

namespace TestAuth.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly TestAuth.Data.AllContext _context;

        public CreateModel(TestAuth.Data.AllContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");
            return Page();
        }

        [BindProperty]
        public Etudiant Etudiant { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.etudiants.Add(Etudiant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
