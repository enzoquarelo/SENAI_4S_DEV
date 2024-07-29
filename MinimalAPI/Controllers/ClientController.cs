using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Domains;
using MinimalAPI.Services;
using MongoDB.Driver;

namespace MinimalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {

        private readonly IMongoCollection<Client> _client;

        public ClientController(MongoDbService mongoDbService)
        {
            _client = mongoDbService.GetDatabase.GetCollection<Client>("client");
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var product = await _client.Find(FilterDefinition<Client>.Empty).ToListAsync();

                return Ok(product);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Client client)
        {
            try
            {
                await _client.InsertOneAsync(client);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("_id")]
        public async Task<IActionResult> Delete(string _id)
        {
            try
            {
                var result = await _client.DeleteOneAsync(x => x.Id == _id);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("_id")]
        public async Task<ActionResult<List<Client>>> GetById(string _id)
        {
            try
            {
                var client = await _client.Find(x => x.Id == _id).ToListAsync();

                return client is not null ? Ok(client) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut("_id")]
        public async Task<IActionResult> Update(Client updatedClient)
        {
            try
            {
                var filter = Builders<Client>.Filter.Eq(x => x.Id, updatedClient.Id);

                await _client.ReplaceOneAsync(filter, updatedClient);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
