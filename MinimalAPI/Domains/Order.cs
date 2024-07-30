using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace MinimalAPI.Domains
{
    public class Order
    {
        [BsonId]
        public string? Id { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        public string? Status { get; set; }


        [BsonElement("clientId")]
        [JsonIgnore]
        public string? ClientId { get; set; } //responsável pelo cadastro do cliente que fez o pedido pelo seu id
        public Client? Client { get; set; } //responsavél por trazer os dados do cliente que fez o pedido


        [BsonElement("productId")]
        [JsonIgnore]
        public List<string> ProductIds { get; set; } //responsável pelo cadastro dos produtos no pedido apartir do seu id
        public List<Product> Products { get; set; } //responsável para trazer todos os dados dos produtos listados no pedido


        public Dictionary<string, string> AdditionalAtribucts { get; set; }

        public Order()
        {
            AdditionalAtribucts = new Dictionary<string, string>();
        }
    }
}
