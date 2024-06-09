using boba_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace First_API_beta2.Controllers;
[Route("api/User")]
[ApiController]
// [Authorize(Roles = "Admin")]
[Authorize]
public class UserController : Controller
{
    private readonly Dyplom2Context _context;
    private readonly UserManager<User> _userManager;

    public UserController(Dyplom2Context context, UserManager<User> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    [HttpGet("information")]
    public async Task<IActionResult> GetInformation()
    {
        var user = await _userManager.GetUserAsync(User);
        return Ok(user);
    }
    //----------------------GET----------------------
    [HttpGet]

    public IActionResult GetAllUsers()
    {
        var users = _context.Users.ToList();
        return Ok(users);
    }

    //----------------------GET{id}----------------------

    [HttpGet("Id")]
    [AllowAnonymous]
    public IActionResult GetUser([FromRoute] int Id)
    {
        var user = _context.Users.Find(Id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }
}
