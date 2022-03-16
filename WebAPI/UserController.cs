using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebAPI.Models;
using System.Web.Http.Cors;

namespace WebAPI.Controllers
{
    [EnableCors(origins: "*", headers : "*", methods: "*")]
    public class UserController : ApiController
    {
        

        private User[] users = new User[]
        {
            new User {Id = 1, Name="Trial One", Email="email1@gmail.com", Phone = "1544345", Role = 1},
            new User {Id = 2, Name="Trial Two", Email="email2@gmail.com", Phone = "1544344", Role = 2},
            new User {Id = 3, Name="Trial Three", Email="email3@gmail.com", Phone = "1544342", Role = 3},
            new User {Id = 4, Name="Trial Four", Email="email4@gmail.com", Phone = "1544341", Role = 4},
            new User {Id = 5, Name="Trial Five", Email="email5@gmail.com", Phone = "1544346", Role = 5},
        };

        public IEnumerable<User> GetUsers()
        {
            return users;
        }

        // GET: api/User Container
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<string> Get(IEnumerable<string> users)
        {
            
            return users;
        }       

        // GET: api/User/5 Person
        
        public IHttpActionResult Get(int Id)
        {
            var product = users.FirstOrDefault((p) => p.Id == Id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/User
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/User/5
        public void Put(int Id, [FromBody]string value)
        {
        }

        // DELETE: api/User/5
        public void Delete(int Id)
        {
        }
    }
}
