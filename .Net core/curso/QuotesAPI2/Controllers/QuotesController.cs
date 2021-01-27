using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;
using QuotesAPI2.Data;
using System.Collections.Generic;

namespace QuotesAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuotesController : ControllerBase
    {
        private QuotesDbContext _quotesDbContext;

        public QuotesController(QuotesDbContext quotesDbContext)
        {
            _quotesDbContext = quotesDbContext;
        }

        // GET: api/<QuotesController>
        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotesDbContext.Quotes;
        }

        // GET api/<QuotesController>/5
        [HttpGet("{id}")]
        public Quote Get(int id)
        {
            // Procura um item através dos ID
            var quote = _quotesDbContext.Quotes.Find(id);
            return quote;
        }

        // POST api/<QuotesController>
        [HttpPost]
        public void Post([FromBody] Quote value)
        {
            _quotesDbContext.Quotes.Add(value);
            _quotesDbContext.SaveChanges();
        }

        // PUT api/<QuotesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Quote value)
        {
            var entity = _quotesDbContext.Quotes.Find(id);
            entity.Title = value.Title;
            entity.Author = value.Author;
            entity.Description = value.Description;
            _quotesDbContext.SaveChanges();
        }

        // DELETE api/<QuotesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var quote = _quotesDbContext.Quotes.Find(id);
            _quotesDbContext.Quotes.Remove(quote);
            _quotesDbContext.SaveChanges();
        }
    }
}
