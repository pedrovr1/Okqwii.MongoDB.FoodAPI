using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okqwii.MongoDB.API.Business.Database.Models
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string FoodCollectionName { get; set; }
        public string ExerciseCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDatabaseSettings
    {
        public string FoodCollectionName { get; set; }
        public string ExerciseCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
    
}
