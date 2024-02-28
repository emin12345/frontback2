using frontback.Contexts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace frontback.Areas.Admin.Controllers;

[Area("Admin")]

public class SliderController : Controller
{

    private readonly PronioDbContext _context;

    public SliderController(PronioDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {

        var sliders = await _context.Sliders.ToListAsync();
        return View(sliders);
    }
}
