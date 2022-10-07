using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Do_an_TMDT.Models;

namespace Do_an_TMDT.Controllers
{
    public class SanphamsController : Controller
    {
        private readonly BANGIAYContext _context;

        public SanphamsController(BANGIAYContext context)
        {
            _context = context;
        }

        // GET: Sanphams
        public async Task<IActionResult> Load_SP()
        {
            var bANGIAYContext = _context.Sanphams.Include(s => s.IdHangNavigation);
            return View(await bANGIAYContext.ToListAsync());
        }
        

       
       
    }
}
