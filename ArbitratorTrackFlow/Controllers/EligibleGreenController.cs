using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ArbitratorTrackFlow.Models;

namespace ArbitratorTrackFlow.Controllers
{
    public class EligibleGreenController : ApiController
    {
        private ArbitrationTrackFlowEntities db = new ArbitrationTrackFlowEntities();

        // GET: api/EligibleGreen
        public IQueryable<eligible_green> Geteligible_green()
        {
            return db.eligible_green;
        }

        // GET: api/EligibleGreen/5
        [ResponseType(typeof(eligible_green))]
        public IHttpActionResult Geteligible_green(int id)
        {
            eligible_green eligible_green = db.eligible_green.Find(id);
            if (eligible_green == null)
            {
                return NotFound();
            }

            return Ok(eligible_green);
        }

        // PUT: api/EligibleGreen/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Puteligible_green(int id, eligible_green eligible_green)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eligible_green.id)
            {
                return BadRequest();
            }

            db.Entry(eligible_green).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!eligible_greenExists(id))
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

        // POST: api/EligibleGreen
        [ResponseType(typeof(eligible_green))]
        public IHttpActionResult Posteligible_green(eligible_green eligible_green)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.eligible_green.Add(eligible_green);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eligible_green.id }, eligible_green);
        }

        // DELETE: api/EligibleGreen/5
        [ResponseType(typeof(eligible_green))]
        public IHttpActionResult Deleteeligible_green(int id)
        {
            eligible_green eligible_green = db.eligible_green.Find(id);
            if (eligible_green == null)
            {
                return NotFound();
            }

            db.eligible_green.Remove(eligible_green);
            db.SaveChanges();

            return Ok(eligible_green);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool eligible_greenExists(int id)
        {
            return db.eligible_green.Count(e => e.id == id) > 0;
        }
    }
}