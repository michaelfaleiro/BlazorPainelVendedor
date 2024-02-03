using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BlazorPainel.Models
{
    public class Orcamento
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        [Required(ErrorMessage = "Informe o Cliente")]
        public string Cliente { get; set; } = null!;
        [Required(ErrorMessage = "Informe o Telefone")]
        public string Telefone { get; set; } = null!;
        [Required(ErrorMessage = "Informe o Carro")]
        public string Carro { get; set; } = null!;
        public string? Placa { get; set; }
        public string? Chassis { get; set; }
        [BsonElement("produtos")]
        [JsonPropertyName("produtos")]
        public List<Produto>? Produtos { get; set; } = [];
        public double Total { get; set; }

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("updatedAt")]
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
    }
}