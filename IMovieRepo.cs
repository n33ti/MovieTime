using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTime
{
    interface IMovieRepo
    {
        public List<Language> GetLanguages();

         bool Addreview(AddReview data);

        public List<Movie> GetMovies(int LanguageId);

        public List<Review> GetReviews(int MovieId);

        

       
    }
}
