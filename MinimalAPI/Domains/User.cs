using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MinimalAPI.Domains
{
    public class User
    {
        [BsonId]

        [BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

        [BsonElement("name")]
        public string? Name { get; set; }

        [BsonElement("email")]
        public string? Email { get; set; }

        [BsonElement("password")]
        public string? Password { get; set; }

        public Dictionary<string, string> AdditionalAtribucts { get; set; }

        /// <summary>
        /// Ao ser instaciado um objeto da classe Prodcut, o atributo AdditionalAtribucts já irá com um novo dicionário, portanto habilitado para adicionar mais atributos
        /// </summary>
        public User()
        {
            AdditionalAtribucts = new Dictionary<string, string>();
        }
    }
}
