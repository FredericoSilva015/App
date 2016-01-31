using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using App.Models;
using App.DAL;

namespace App.Controllers
{
    public class ApidataController : ApiController
    {
        private AppContext db = new AppContext();

        //it exposes the database in the URL with /api/apidata
        public IEnumerable<Details> GetAllDetails()
        {
            var api = db.Details;
            return api;
        }

        public IHttpActionResult GetByID(int id)
        {
            var api = db.Details.FirstOrDefault((s) => s.ID == id);
            if (api == null)
            {
                return NotFound();
            }
            return Ok(api);
        }

        
    }
}
