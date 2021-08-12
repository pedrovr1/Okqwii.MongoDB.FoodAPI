using MongoDB.Driver;
using Okqwii.MongoDB.API.Business.Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okqwii.MongoDB.API.Business.Database.Context
{
    public class DatabaseContext
    {

        public readonly IMongoCollection<Food> Foods;
        public readonly IMongoCollection<Exercise> Exercises;

        public DatabaseContext(DatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            Foods = database.GetCollection<Food>(settings.FoodCollectionName);
            Exercises = database.GetCollection<Exercise>(settings.ExerciseCollectionName);
        }
    }
}
