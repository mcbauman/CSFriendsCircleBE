using CSFriendsCircleBE.Data;
using Microsoft.AspNetCore.Mvc;

namespace CSFriendsCircleBE.Controllers;
[ApiController]
[Route("api/[Controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.User);
    }
}