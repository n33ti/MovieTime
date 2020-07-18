using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTime
{
    public class MovieRepo : IMovieRepo
    {
        public List<Language> GetLanguages()
        {
             DbContextApp db = new DbContextApp();



            return db.Languages.ToList();

            
        }

        public bool Addreview(AddReview data)
        {
            if (data != null)
            {
                Review rev = new Review();
                rev.MovieId = data.MovieId;
                rev.review = data.review;
                DbContextApp db = new DbContextApp();
                db.Reviews.Add(rev);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Movie> GetMovies(int LanguageId = 0)
        {
            DbContextApp db = new DbContextApp();
            return db.Movies.Where(a => a.LanguageId == LanguageId).ToList();
        }

        public List<Review> GetReviews(int MovieId)
        {
            DbContextApp db = new DbContextApp();
            return db.Reviews.Where(a => a.MovieId == MovieId).ToList();
        }
    }
}
