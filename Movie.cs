using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTime
{
    public class Movie
    {
        public int Id { get; set; }
        public string movieName {get; set;}

        public int LanguageId { get; set; }

        public Language Language { get; set; }

        public List <Review> reviews { get; set; }
    }
}
