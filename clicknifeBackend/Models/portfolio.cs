using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ClicknifeAPI.Models 
{
    public class Portfolio 
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("title")]
        public string Title { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("dateEntered")]
        public BsonDateTime DateEntered { get; set; }

        [BsonElement("displayPosition")]
        public BsonDecimal128 DisplayPosition { get; set; }

        [BsonElement("images")]
        public BsonArray Images { get; set; }

    }
}