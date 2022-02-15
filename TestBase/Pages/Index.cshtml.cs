using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestBase.Data;
using TestBase.Models;
using Microsoft.EntityFrameworkCore;

namespace TestBase.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DataContext dataContext;

        public IndexModel(ILogger<IndexModel> logger,DataContext db)
        {
            _logger = logger;
            dataContext = db;
        }

        public void OnGet()
        {
            Etudiant etudiant = new Etudiant("Hicham", "R1333");
            dataContext.etudiants.Add(etudiant);
            dataContext.SaveChanges();
        }
    }
}
