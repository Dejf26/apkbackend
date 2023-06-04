using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using apkbackend.Data;
using apkbackend.Pages.Models;

namespace apkbackend.Pages.Projects
{
    public class IndexModel : PageModel
    {
        private readonly apkbackend.Data.apkbackendContext _context;

        public IndexModel(apkbackend.Data.apkbackendContext context)
        {
            _context = context;
        }

        public IList<Project> Project { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Project != null)
            {
                Project = await _context.Project.ToListAsync();
            }
        }
    }
}
