using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Domains;
using MinimalAPI.Services;
using MongoDB.Driver;

namespace MinimalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IMongoCollection<User> _user;

        public UserController(MongoDbService mongoDbService)
        {
            _user = mongoDbService.GetDatabase.GetCollection<User>("user");
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] User user)
        {
            try
            {
                await _user.InsertOneAsync(user);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }


        [HttpGet]
        public async Task<ActionResult<List<User>>> Get()
        {
            try
            {
                var user = await _user.Find(FilterDefinition<User>.Empty).ToListAsync();

                return Ok(user);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpDelete("_id")]
        public async Task<IActionResult> Delete(string _id)
        {
            try
            {
                var result = await _user.DeleteOneAsync(x => x.Id == _id);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("_id")]
        public async Task<IActionResult> Update(User updatedUser)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq(x => x.Id, updatedUser.Id);

                await _user.ReplaceOneAsync(filter, updatedUser);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("_id")]
        public async Task<ActionResult<List<Product>>> GetById(string _id)
        {
            try
            {
                var user = await _user.Find(x => x.Id == _id).ToListAsync();

                return user is not null ? Ok(user) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
