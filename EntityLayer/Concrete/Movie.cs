using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public List<string> Actors { get; set; }
        public string Director { get ; set; }
        public int MovieRate { get; set; }
        public string Img { get; set; }
        public string Trailer { get; set; }
        public bool IsStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public ICollection<Comment> Comments { get; set;}
        public ICollection<Favorite> Favorites { get; set;}




    }
}
