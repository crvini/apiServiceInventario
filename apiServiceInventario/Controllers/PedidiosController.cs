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
using apiServiceInventario.Models;

namespace apiServiceInventario.Controllers
{
    public class PedidiosController : ApiController
    {
        private PedidoModel db = new PedidoModel();

        // GET: api/Pedidios
        public IQueryable<Pedidio> GetPedidio()
        {
            return db.Pedidio;
        }

        // GET: api/Pedidios/5
        [ResponseType(typeof(Pedidio))]
        public IHttpActionResult GetPedidio(int id)
        {
            Pedidio pedidio = db.Pedidio.Find(id);
            if (pedidio == null)
            {
                return NotFound();
            }

            return Ok(pedidio);
        }

        // PUT: api/Pedidios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPedidio(int id, Pedidio pedidio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != pedidio.idPedidio)
            {
                return BadRequest();
            }

            db.Entry(pedidio).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PedidioExists(id))
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

        // POST: api/Pedidios
        [ResponseType(typeof(Pedidio))]
        public IHttpActionResult PostPedidio(Pedidio pedidio)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Pedidio.Add(pedidio);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = pedidio.idPedidio }, pedidio);
        }

        // DELETE: api/Pedidios/5
        [ResponseType(typeof(Pedidio))]
        public IHttpActionResult DeletePedidio(int id)
        {
            Pedidio pedidio = db.Pedidio.Find(id);
            if (pedidio == null)
            {
                return NotFound();
            }

            db.Pedidio.Remove(pedidio);
            db.SaveChanges();

            return Ok(pedidio);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PedidioExists(int id)
        {
            return db.Pedidio.Count(e => e.idPedidio == id) > 0;
        }
    }
}