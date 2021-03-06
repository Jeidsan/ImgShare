﻿using ImgShare.Domain;
using ImgShare.Service.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImgShare.Service.Controllers
{
    [Produces("application/json")]
    [Route("api/Photos")]
    [Authorize("Bearer")]
    public class PhotosController : Controller
    {
        private readonly ImgShareContext _context;

        public PhotosController(ImgShareContext context)
        {
            _context = context;
        }

        // GET: api/Photos
        [HttpGet]
        public IEnumerable<Photo> GetPhoto()
        {
            return _context.Photo;
        }

        // GET: api/Photos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPhoto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var photo = await _context.Photo.SingleOrDefaultAsync(m => m.Id == id);

            if (photo == null)
            {
                return NotFound();
            }

            return Ok(photo);
        }

        // PUT: api/Photos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhoto([FromRoute] int id, [FromBody] Photo photo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != photo.Id)
            {
                return BadRequest();
            }

            _context.Entry(photo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhotoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Photos
        [HttpPost]
        public async Task<IActionResult> PostPhoto([FromBody] Photo photo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Photo.Add(photo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhoto", new { id = photo.Id }, photo);
        }

        // DELETE: api/Photos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhoto([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var photo = await _context.Photo.SingleOrDefaultAsync(m => m.Id == id);
            if (photo == null)
            {
                return NotFound();
            }

            _context.Photo.Remove(photo);
            await _context.SaveChangesAsync();

            return Ok(photo);
        }

        private bool PhotoExists(int id)
        {
            return _context.Photo.Any(e => e.Id == id);
        }
    }
}