using boba_API.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace First_API_beta2.Controllers;
[Route("api/User")]
[ApiController]
[Authorize]
public class UserController : Controller
{
    private readonly Dyplom2Context _context;

    public UserController(Dyplom2Context context)
    {
        _context = context;
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