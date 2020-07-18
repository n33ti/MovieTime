using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTime
{
    public class Review
    {
        public int Id { get; set; }
        public string review { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; } 
    }
}
