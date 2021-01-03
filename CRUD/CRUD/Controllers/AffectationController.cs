﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AffectationController : ControllerBase
    {
        private readonly ProjectDBContext _context;

        public AffectationController(ProjectDBContext context)
        {
            _context = context;
        }

        // GET: api/Affectation
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Affectation>>> GetAffectations()
        {
            return await _context.Affectations.ToListAsync();
        }

        // GET: api/Affectation/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Affectation>> GetAffectation(int id)
        {
            var affectation = await _context.Affectations.FindAsync(id);

            if (affectation == null)
            {
                return NotFound();
            }

            return affectation;
        }

        // PUT: api/Affectation/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAffectation(int id, Affectation affectation)
        {
            if (id != affectation.AffectationId)
            {
                return BadRequest();
            }

            _context.Entry(affectation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AffectationExists(id))
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

        // POST: api/Affectation
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Affectation>> PostAffectation(Affectation affectation)
        {
            _context.Affectations.Add(affectation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAffectation", new { id = affectation.AffectationId }, affectation);
        }

        // DELETE: api/Affectation/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Affectation>> DeleteAffectation(int id)
        {
            var affectation = await _context.Affectations.FindAsync(id);
            if (affectation == null)
            {
                return NotFound();
            }

            _context.Affectations.Remove(affectation);
            await _context.SaveChangesAsync();

            return affectation;
        }

        private bool AffectationExists(int id)
        {
            return _context.Affectations.Any(e => e.AffectationId == id);
        }
    }
}
