using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper.QueryableExtensions;
using CarService.Models;

namespace CarService.Controllers
{
    public class MerkenController : ApiController
    {
        private CarServiceContext db = new CarServiceContext();

        // GET: api/Merken
        public IQueryable<MerkDTO> GetMerks()
        {
            return db.Merken.ProjectTo<MerkDTO>();
        }

        // GET: api/Merken/5
        [ResponseType(typeof(Merk))]
        public async Task<IHttpActionResult> GetMerk(int id)
        {
            Merk merk = await db.Merken.FindAsync(id);
            if (merk == null)
            {
                return NotFound();
            }

            return Ok(merk);
        }

        // PUT: api/Merken/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutMerk(int id, Merk merk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != merk.Id)
            {
                return BadRequest();
            }

            db.Entry(merk).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MerkExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Merken
        [ResponseType(typeof(Merk))]
        public async Task<IHttpActionResult> PostMerk(Merk merk)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Merken.Add(merk);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = merk.Id }, merk);
        }

        // DELETE: api/Merken/5
        [ResponseType(typeof(Merk))]
        public async Task<IHttpActionResult> DeleteMerk(int id)
        {
            Merk merk = await db.Merken.FindAsync(id);
            if (merk == null)
            {
                return NotFound();
            }

            db.Merken.Remove(merk);
            await db.SaveChangesAsync();

            return Ok(merk);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MerkExists(int id)
        {
            return db.Merken.Count(e => e.Id == id) > 0;
        }
    }
}