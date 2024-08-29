using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using productsAPI.Models;

namespace productsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsDbContext _context = new ProductsDbContext();

        //public ProductsController(ProductsDbContext context)
        //{
        //    _context = context;
        //}

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductsInfo>>> GetProductsInfos()
        {
            return await _context.ProductsInfos.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductsInfo>> GetProductsInfo(int id)
        {
            var productsInfo = await _context.ProductsInfos.FindAsync(id);

            if (productsInfo == null)
            {
                return NotFound();
            }

            return productsInfo;
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductsInfo(int id, ProductsInfo productsInfo)
        {
            if (id != productsInfo.Pid)
            {
                return BadRequest();
            }

            _context.Entry(productsInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductsInfoExists(id))
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

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProductsInfo>> PostProductsInfo(ProductsInfo productsInfo)
        {
            _context.ProductsInfos.Add(productsInfo);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProductsInfoExists(productsInfo.Pid))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProductsInfo", new { id = productsInfo.Pid }, productsInfo);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductsInfo(int id)
        {
            var productsInfo = await _context.ProductsInfos.FindAsync(id);
            if (productsInfo == null)
            {
                return NotFound();
            }

            _context.ProductsInfos.Remove(productsInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductsInfoExists(int id)
        {
            return _context.ProductsInfos.Any(e => e.Pid == id);
        }
    }
}
