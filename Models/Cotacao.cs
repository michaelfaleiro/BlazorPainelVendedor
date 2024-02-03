using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorPainel.Models
{
    public class Cotacao
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }

    }
}