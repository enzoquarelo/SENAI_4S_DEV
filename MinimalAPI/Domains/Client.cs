using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalAPI.Domains
{
    public class Client
    {
        [BsonId]

        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("cpf")]
        public string? CPF { get; set; }

        [BsonElement("phone")]
        public string? Phone { get; set; }

        [BsonElement("address")]
        public string? Address { get; set; }

        [BsonElement("userId")]
        public string? UserId { get; set; }

        public Dictionary<string, string> AdditionalAtribucts { get; set; }

        /// <summary>
        /// Ao ser instaciado um objeto da classe Prodcut, o atributo AdditionalAtribucts já irá com um novo dicionário, portanto habilitado para adicionar mais atributos
        /// </summary>
        public Client()
        {
            AdditionalAtribucts = new Dictionary<string, string>();
        }
    }
}