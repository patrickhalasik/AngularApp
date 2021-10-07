using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppUsersController : ControllerBase
    {
        private readonly DataContext _context;
        public AppUsersController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetAppUsers()
        {
            return await _context.Users.ToListAsync();
        }

        [HttpGet("{Id}")]
          public async Task<ActionResult<AppUser>> GetAppUser(int id)
        {
            return await _context.Users.FindAsync(id);
        }
    }
}