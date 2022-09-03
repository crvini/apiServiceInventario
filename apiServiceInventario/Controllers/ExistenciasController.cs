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
    public class ExistenciasController : ApiController
    {
        private ExistenciaModel db = new ExistenciaModel();

        // GET: api/Existencias
        public IQueryable<Existencia> GetExistencia()
        {
            return db.Existencia;
        }

        // GET: api/Existencias/5
        [ResponseType(typeof(Existencia))]
        public IHttpActionResult GetExistencia(int id)
        {
            Existencia existencia = db.Existencia.Find(id);
            if (existencia == null)
            {
                return NotFound();
            }

            return Ok(existencia);
        }

        // PUT: api/Existencias/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutExistencia(int id, Existencia existencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != existencia.Producto_idProducto)
            {
                return BadRequest();
            }

            db.Entry(existencia).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExistenciaExists(id))
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

        // POST: api/Existencias
        [ResponseType(typeof(Existencia))]
        public IHttpActionResult PostExistencia(Existencia existencia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Existencia.Add(existencia);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ExistenciaExists(existencia.Producto_idProducto))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = existencia.Producto_idProducto }, existencia);
        }

        // DELETE: api/Existencias/5
        [ResponseType(typeof(Existencia))]
        public IHttpActionResult DeleteExistencia(int id)
        {
            Existencia existencia = db.Existencia.Find(id);
            if (existencia == null)
            {
                return NotFound();
            }

            db.Existencia.Remove(existencia);
            db.SaveChanges();

            return Ok(existencia);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ExistenciaExists(int id)
        {
            return db.Existencia.Count(e => e.Producto_idProducto == id) > 0;
        }
    }
}