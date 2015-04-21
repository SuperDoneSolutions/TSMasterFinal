using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TotalSquashNext.Models;
using System.Data.Entity;

namespace TotalSquashNext.Controllers
{
    public class TotalMobileSquashController : ApiController
    {
        private PrimarySquashDBContext db = new PrimarySquashDBContext();

        //public IEnumerable<User> GetUser()
        //{
        //    var users= db.Users.Include(u => u.AccountType).Include(u => u.Country).Include(u => u.Organization).Include(u => u.Province).Include(u => u.Skill).ToList();
        //    return users;
        //}
        public IEnumerable<object> GetUserEmail()
        {
            var users = db.Users.Select(x => new { x.username, x.emailAddress });
            return users;
        }

        public IHttpActionResult GetUser(int id)
        {
            User user = db.Users.Find(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        public IHttpActionResult PostUser(User user)
        {
            if (ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                var uri = new Uri(
                    Url.Link(
                    "DefaultApi",
                    new { id = user.id }));
                return Created(uri, user);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }


    }
}
