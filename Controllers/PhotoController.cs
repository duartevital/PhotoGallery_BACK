using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PhotoGallery.Models;

namespace PhotoGallery.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PhotoController : ControllerBase   
{
    private readonly DatabaseContext _dbContext;

    public PhotoController (DatabaseContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Photo>>> GetPhotos()
    {
        if (_dbContext == null)
            return NotFound();

        return await _dbContext.Photo.ToListAsync();
    }
}
