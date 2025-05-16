using System.ComponentModel.DataAnnotations;

namespace BandsApp.Web.Models
{
    public class Band
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
