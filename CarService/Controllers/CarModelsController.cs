using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarService.Models;

namespace CarService.Controllers
{
    public class CarModelsController : ApiController
    {
        private CarServiceContext db = new CarServiceContext();

        // GET: api/CarModels
        public IQueryable<CarModelDTO> GetCarModels()
        {
            var carModellen = db.CarModels.ProjectTo<CarModelDTO>();
            return carModellen;
        }

        // GET: api/CarModels/5
        [ResponseType(typeof(CarModelDetailDTO))]
        public async Task<IHttpActionResult> GetCarModel(int id)
        {
            var carModel = await db.CarModels
                                    .ProjectTo<CarModelDetailDTO>()
                                    .SingleOrDefaultAsync(cM => cM.Id == id);

           
            if (carModel == null)
            {
                return NotFound();
            }

            return Ok(carModel);
        }

        // PUT: api/CarModels/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutCarModel(int id, CarModelDetailDTO carModelDetailDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CarModel carModel = Mapper.Map<CarModel>(carModelDetailDTO);
            db.Set<CarModel>().Attach(carModel); // voor update
            db.Entry(carModel).State = EntityState.Modified;
            await db.SaveChangesAsync();

            return Ok(carModelDetailDTO);

        }

        // POST: api/CarModels
        [ResponseType(typeof(CarModelDetailDTO))]
        public async Task<IHttpActionResult> PostCarModel(CarModelDetailDTO carModelDetailDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            CarModel carModel = Mapper.Map<CarModel>(carModelDetailDTO);
            db.CarModels.Add(carModel);
            await db.SaveChangesAsync();

            //Id naar DTO wegschrijven
            carModelDetailDTO.Id = carModel.Id;

            return Ok(carModelDetailDTO);
        }

        // DELETE: api/CarModels/5
        [ResponseType(typeof(CarModel))]
        public async Task<IHttpActionResult> DeleteCarModel(int id)
        {
            CarModel carModel = await db.CarModels.FindAsync(id);
            if (carModel == null)
            {
                return NotFound();
            }

            db.CarModels.Remove(carModel);
            await db.SaveChangesAsync();

            return Ok(carModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarModelExists(int id)
        {
            return db.CarModels.Count(e => e.Id == id) > 0;
        }
    }
}