using System.Security.Claims;
using boba_API.Models;
using boba_API.Models.Dto;
using First_API_beta2.Mapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace First_API_beta2.Controllers;
[Route("api/[controller]")]
[ApiController]
// [Authorize(Roles = "Admin")]
[Authorize]
public class UserController : Controller
{
    private readonly Dyplom2Context _context;
    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public UserController(Dyplom2Context context, SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _context = context;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [HttpGet("current users")]
    public async Task<IActionResult> GetInformation()
    {
        var roles = ((ClaimsIdentity)User.Identity).Claims
            .Where(c => c.Type == ClaimTypes.Role)
            .Select(c => c.Value);

        var user = await _userManager.GetUserAsync(User);
        return Ok(new
        {
            User = user,
            Roles = roles
        });
    }

    //----------------------GET----------------------
    [HttpGet("DTO's version")]

    public IActionResult GetAllUsers()
    {
        var users = _context.Users.ToList()
            .Select(s => s.ToUserDto());
        return Ok(users);
    }


    [HttpGet]
    public async Task<IActionResult> GetAllUsersFull()
    {
        var users = await _context.Users.ToListAsync();
        var usersDtoWithRoles = new List<AdvancedUserDTO>();

        foreach (var user in users)
        {
            var roles = await _userManager.GetRolesAsync(user);
            var userDtoWithRoles = AdvancedUserMappers.ToAdvancedUserDTO(user, roles);
            usersDtoWithRoles.Add(userDtoWithRoles);
        }

        return Ok(usersDtoWithRoles);
    }

    //----------------------GET{id}----------------------

    [HttpGet("{id}")]
    public IActionResult GetUser([FromRoute] string id)
    {
        var user = _context.Users.Find(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    

    [HttpPatch("{id}")]
    public IActionResult PatchUserById([FromRoute] string email, [FromBody] UserDTO userDTO)
    {
        var edit_user = _context.Users.FirstOrDefault(x => x.Email == email);

        if (edit_user == null)
        {
            return NotFound();
        }

        edit_user.FirstName = userDTO.FirstName;

        edit_user.LastName = userDTO.LastName;

        edit_user.Email = userDTO.Email;

        // Збереження змін
        _context.SaveChanges();

        return Ok(edit_user.ToUserDto());
    }
    public IActionResult PatchAdvancedUser([FromRoute] string id, [FromBody] UserDTO userDTO)
    {
        var edit_user = _context.Users.FirstOrDefault(x => x.Id == id);

        if (edit_user == null)
        {
            return NotFound();
        }

        edit_user.FirstName = userDTO.FirstName;

        edit_user.LastName = userDTO.LastName;

        edit_user.Email = userDTO.Email;

        // Збереження змін
        _context.SaveChanges();

        return Ok(edit_user.ToUserDto());
    }
    

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteUser([FromRoute] string id)
    {
        var user = await _userManager.FindByIdAsync(id);

        if (user == null)
        {
            return NotFound();
        }

        // Виведення користувача із системи
        await _signInManager.SignOutAsync();

        // Видалення кукі
        Response.Cookies.Delete(".AspNetCore.Identity.Application");

        // Видалення користувача з бази даних
        var result = await _userManager.DeleteAsync(user);

        if (!result.Succeeded)
        {
            return BadRequest(result.Errors);
        }

        return NoContent();
    }
}




