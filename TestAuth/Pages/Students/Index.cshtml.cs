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
    public class IndexModel : PageModel
    {
        private readonly TestAuth.Data.AllContext _context;

        public IndexModel(TestAuth.Data.AllContext context)
        {
            _context = context;

        }

        public IList<Etudiant> Etudiant { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (!User.Identity.IsAuthenticated) return Redirect("/Identity/Account/Login");
            Etudiant = await _context.etudiants.ToListAsync();
            return Page();
        }
    }
}
