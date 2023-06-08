using Microsoft.AspNetCore.Mvc.Rendering;
using WebSiteMovie.Models;

namespace WebSiteMovie.Models
{
    public class MovieGenreViewModel
    {
        public List<MovieViewModel>? Movies { get; set; }
        public SelectList? Genres { get; set; }
        public string? MovieGenre { get; set; }
        public string? SearchString { get; set; }
    }
}
