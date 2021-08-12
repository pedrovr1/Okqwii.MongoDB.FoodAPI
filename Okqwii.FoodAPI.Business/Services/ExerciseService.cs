using MongoDB.Driver;
using Okqwii.MongoDB.API.Business.Database.Context;
using Okqwii.MongoDB.API.Business.Database.Models;
using System.Collections.Generic;
using System.Linq;

namespace Okqwii.MongoDB.API.Business.Database.Services
{
    public class ExerciseService
    {
        private readonly DatabaseContext _context;

        public ExerciseService(DatabaseContext context)
        {
            _context = context;
        }

        public List<Exercise> GetExercises()
        {
            return _context.Exercises.Find(_ => true).ToList();
        }

        public Exercise GetExercise(string id)
        {
            return _context.Exercises.Find(exercise => exercise.Id == id).FirstOrDefault();
        }

        public Exercise CreateExercise(Exercise exercise)
        {
            _context.Exercises.InsertOne(exercise);
            return exercise;
        }

        public void UpdateExercise(string id, Exercise newExercise)
        {
            _context.Exercises.ReplaceOne(exercise => exercise.Id == id, newExercise);
        }

        public void RemoveExercise(string id)
        {
            _context.Exercises.DeleteOne(exercise => exercise.Id == id);
        }

        public void RemoveExercise(Exercise exerciseToDelete)
        {
            _context.Exercises.DeleteOne(exercise => exercise.Id == exerciseToDelete.Id);
        }
    }
}
