
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

using Vidly.Models;

namespace Vidly.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController(){
            _context = new ApplicationDbContext();
}
        // GET api/<controller>
        public IEnumerable<Customer> Get()
        {
            return _context.Customers.ToList();
        }

        // GET api/<controller>/5
        public Customer GetCustomer(int id)
        {
            Customer customer = _context.Customers.SingleOrDefault(c => id == c.Id);
            if (customer == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
                return customer;
        }

        // POST api/<controller>
        [HttpPost]
        public Customer CreateCustomer(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;
        }

        // PUT api/<controller>/5\
        [HttpPut]
        public void UpdateCusomter(int id, Customer customer)
        {
            if (!ModelState.IsValid)
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
            var customerInDb = _context.Customers.SingleOrDefault(c => id == c.Id);
            if (customerInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            customerInDb.Name = customer.Name;
            customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;

            customerInDb.MembershipTypeId = customer.MembershipTypeId;
            customerInDb.Birthdate = customer.Birthdate;
            _context.SaveChanges();
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void DeleteCustomer(int id)
        {
            var customerInDb = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Customers.Remove(customerInDb);
            _context.SaveChanges();
        }
    }
}