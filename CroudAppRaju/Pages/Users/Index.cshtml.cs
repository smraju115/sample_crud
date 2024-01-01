using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CroudAppRaju.Data;
using CroudAppRaju.Model;

namespace CroudAppRaju.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CroudAppRaju.Data.CroudAppRajuContext _context;

        public IndexModel(CroudAppRaju.Data.CroudAppRajuContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
