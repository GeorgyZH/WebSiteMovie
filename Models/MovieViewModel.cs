using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSiteMovie.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        [DisplayName("Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
