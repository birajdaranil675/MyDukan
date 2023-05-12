﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyDukan.Data;
using MyDukan.Models;

namespace MyDukan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        private readonly MyDukanDBContex _context;

        public MedicinesController(MyDukanDBContex context)
        {
            _context = context;
        }

        // GET: api/Medicines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medicines>>> GetMedicines()
        {
          if (_context.Medicines == null)
          {
              return NotFound();
          }
            return await _context.Medicines.ToListAsync();
        }

        // GET: api/Medicines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medicines>> GetMedicines(int id)
        {
          if (_context.Medicines == null)
          {
              return NotFound();
          }
            var medicines = await _context.Medicines.FindAsync(id);

            if (medicines == null)
            {
                return NotFound();
            }

            return medicines;
        }

        // PUT: api/Medicines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicines(int id, Medicines medicines)
        {
            if (id != medicines.ID)
            {
                return BadRequest();
            }

            _context.Entry(medicines).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicinesExists(id))
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

        // POST: api/Medicines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Medicines>> PostMedicines(Medicines medicines)
        {
          if (_context.Medicines == null)
          {
              return Problem("Entity set 'MyDukanDBContex.Medicines'  is null.");
          }
            _context.Medicines.Add(medicines);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedicines", new { id = medicines.ID }, medicines);
        }

        // DELETE: api/Medicines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicines(int id)
        {
            if (_context.Medicines == null)
            {
                return NotFound();
            }
            var medicines = await _context.Medicines.FindAsync(id);
            if (medicines == null)
            {
                return NotFound();
            }

            _context.Medicines.Remove(medicines);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MedicinesExists(int id)
        {
            return (_context.Medicines?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
