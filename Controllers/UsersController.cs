using DatingAppProj.Data;
using DatingAppProj.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DatingAppProj.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(DataContext context) :ControllerBase
    {

        [HttpGet]        //api/users/
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            var Users = await context.Users.ToListAsync();

            return Users;
        }


        [HttpGet("{id}")] // api/users/1
        public async Task<ActionResult<AppUser>> GetUsers(int id)
        {
            var User = await context.Users.FindAsync(id);

            if (User == null) return NotFound();
            
            return User;
        }


    }
}
