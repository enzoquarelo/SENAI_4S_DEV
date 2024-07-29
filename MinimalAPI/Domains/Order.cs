using MongoDB.Bson.Serialization.Attributes;

namespace MinimalAPI.Domains
{
    public class Order
    {
        [BsonId]
        public string? Id { get; set; }

        [BsonElement("date")]
        public string? Date { get; set; }

        [BsonElement("status")]
        public string? Status { get; set; }

        [BsonElement("clientId")]
        public string ClientId { get; set; } 

        [BsonElement("productIds")]
        public List<string> ProductIds { get; set; }

        public Dictionary<string, string> AdditionalAtribucts { get; set; }

        /// <summary>
        /// Ao ser instaciado um objeto da classe Prodcut, o atributo AdditionalAtribucts já irá com um novo dicionário, portanto habilitado para adicionar mais atributos
        /// </summary>
        public Order()
        {
            AdditionalAtribucts = new Dictionary<string, string>();
        }
    }
}
