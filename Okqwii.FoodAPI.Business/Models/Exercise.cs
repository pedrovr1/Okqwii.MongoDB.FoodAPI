using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okqwii.MongoDB.API.Business.Database.Models
{
    public class Exercise
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ExerciseName { get; set; }
        public string ExerciseCategory { get; set; }
        public string CaloriesBurnedPerMinute { get; set; }
        public string CaloriesBurnedPerHour { get; set; }
    }
}
