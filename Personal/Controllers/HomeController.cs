using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personal.Data;
using Personal.Models;

namespace Personal.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _appDbContext;

    public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
    {
        _logger = logger;
        _appDbContext = appDbContext;
    }

    public async Task<IActionResult> Index()
    {
        var exercises = await _appDbContext.Exercises.ToListAsync();
        return View("Index", exercises);
    }
    public async Task<IActionResult> Exercise(int? id)
    {
        if (id == null || _appDbContext.Exercises == null)
        {
            return NotFound();
        }
        var exercise = await _appDbContext.Exercises
            .Where(e => e.Id == id)
            .SingleOrDefaultAsync();
        if (exercise == null)
        {
            return NotFound();
        }
        return View("Exercise", exercise);
    }

    [HttpPost]
    public async Task<IActionResult> AddExercise(Exercise exercise)
    {
        _appDbContext.Exercises.Add(exercise);
        await _appDbContext.SaveChangesAsync();

        return Ok(exercise);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
