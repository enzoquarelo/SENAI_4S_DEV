using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MinimalAPI.Domains;
using MinimalAPI.Services;
using minimalAPIMongo.ViewModels;
using MongoDB.Driver;

namespace MinimalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMongoCollection<Order> _order;
        private readonly IMongoCollection<Client> _client;
        private readonly IMongoCollection<Product> _product;

        public OrderController(MongoDbService mongoDbService)
        {
            _order = mongoDbService.GetDatabase.GetCollection<Order>("order");
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var orders = await _order.Find(FilterDefinition<Order>.Empty).ToListAsync();

                foreach (var order in orders)
                {
                    var filter = Builders<Product>.Filter.In(p => p.Id, order.ProductId);

                    order.Products = await _product.Find(filter).ToListAsync();

                    if (order.ClientId != null)
                    {
                        order.Client = await _client.Find(x => x.Id == order.ClientId).FirstOrDefaultAsync();
                    }
                }

                return Ok(orders);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpPost]
        public async Task<IActionResult> Post(OrderViewModel newOrder)
        {
            try
            {
                Order order = new Order();
                order.Id = newOrder.Id;
                order.Date = newOrder.Date;
                order.Status = newOrder.Status;
                order.ProductId = newOrder.ProductId;
                order.ClientId = newOrder.ClientId;

                var clientOwner = _client.Find(c => c.Id == newOrder.ClientId).FirstOrDefaultAsync();

                if (clientOwner is not null)
                {
                    order.Client = await clientOwner;
                }
                else
                {
                    return NotFound("Cliente não encontrado");
                }

                var lista = new List<Product>();

                foreach (var productId in newOrder.ProductId!)
                 {
                    var item = _product.Find(p => p.Id == productId).FirstOrDefault();

                    if (item is not null)
                    {
                        lista.Add(item);
                    }
                }

                order.Products = lista;

                await _order.InsertOneAsync(order);
                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest("catch:" + e.Message);
            }
        }

        [HttpDelete("_id")]
        public async Task<IActionResult> Delete(string _id)
        {
            try
            {
                await _order.DeleteOneAsync(x => x.Id == _id);

                return StatusCode(204);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("_id")]
        public async Task<ActionResult<Order>> GetById(string _id)
        {
            try
            {

                var order = await _order.Aggregate()
                    .Match(x => x.Id == _id) 
                    .Lookup("Client", "ClientId", "Id", "Client") 
                    .Lookup("Product", "ProductId", "Id", "Product")
                    .ToListAsync();

                return order is not null ? Ok(order) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut("_id")]
        public async Task<IActionResult> Update(Order updatedOrder)
        {
            try
            {
                var filter = Builders<Order>.Filter.Eq(x => x.Id, updatedOrder.Id);

                await _order.ReplaceOneAsync(filter, updatedOrder);

                return StatusCode(201);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
