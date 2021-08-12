using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Okqwii.MongoDB.API.Business.Database.Models
{
    public class Food
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string FoodName { get; set; }
        public string FoodCategory { get; set; }
        public string CaloriesPerGrams { get; set; }
        public string CaloriesPerHundredGrams { get; set; }
    }
}
