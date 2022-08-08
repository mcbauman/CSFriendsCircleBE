using CSFriendsCircleBE.Data;
using CSFriendsCircleBE.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CSFriendsCircleBE.Controllers;
[ApiController]
[Route("/[Controller]")]
public class UserController : ControllerBase
{
    private readonly ApplicationDbContext _context;
    
    public UserController(ApplicationDbContext context)
    {
        _context = context;
    }
//GET /user
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_context.User);
    }

//POST /user
    [HttpPost]
    public async Task<IActionResult> Post([FromBody] User reqBody)
    {
        _context.User.Add(reqBody);
        await _context.SaveChangesAsync();
        return Ok(_context.User);
    }
}