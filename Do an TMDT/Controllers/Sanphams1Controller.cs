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
    public class Sanphams1Controller : Controller
    {
        private readonly BANGIAYContext _context;

        public Sanphams1Controller(BANGIAYContext context)
        {
            _context = context;
        }

        // GET: Sanphams1
        public async Task<IActionResult> Chi_tiet(int MaSp)
        {
            var bANGIAYContext = _context.Sanphams.Where(n => n.MaSp == MaSp).FirstOrDefault(); ;
            return View( bANGIAYContext);
        }

       
       

       
    }
}
