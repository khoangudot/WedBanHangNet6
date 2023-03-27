using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WedBanHangNet6.Models;

namespace WedBanHangNet6.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class ManageRolesController : Controller
    {
        public  PRN_ASMContext context = new PRN_ASMContext();
       
        //Get list roles
        public async Task<IActionResult> Index()
        {
          return  View(await context.Roles.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var role =  await context.Roles.FirstOrDefaultAsync(r => r.RoleId == id );
            if(role == null)
            {
                return NotFound();
            }
            return View(role);
        }
    }

    
}
