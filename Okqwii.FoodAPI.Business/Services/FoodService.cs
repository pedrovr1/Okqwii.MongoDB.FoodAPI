using MongoDB.Driver;
using Okqwii.MongoDB.API.Business.Database.Context;
using Okqwii.MongoDB.API.Business.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace Okqwii.MongoDB.API.Business.Database.Services
{
    public class FoodService
    {
        private readonly DatabaseContext _context;

        public FoodService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Food> GetBooks()
        {
            return _context.Foods.Find(_ => true).ToList();
        }

        public Food GetFood(string id)
        {
            return _context.Foods.Find(food => food.Id == id).FirstOrDefault();
        }

        public Food CreateFood(Food newFood)
        {
            _context.Foods.InsertOne(newFood);
            return newFood;
        }

        public void UpdateFood(string id, Food newFood)
        {
            _context.Foods.ReplaceOne(food => food.Id == id, newFood);
        }

        public void RemoveFood(string id)
        {
            _context.Foods.DeleteOne(food => food.Id == id);
        }

        public void RemoveFood(Food foodToDelete)
        {
            _context.Foods.DeleteOne(food => food.Id == foodToDelete.Id);
        }
    }
}
