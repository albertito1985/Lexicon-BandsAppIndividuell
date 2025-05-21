using System.ComponentModel.DataAnnotations;

namespace BandsApp.Web.Views.Bands
{
    public class AddBandVM
    {
        [Required]
        public required string Name { get; set; }
    }
}
