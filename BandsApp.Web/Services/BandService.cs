using BandsApp.Web.Models;

namespace BandsApp.Web.Services
{
    public class BandService
    {
        private List<Band> bands = [
            new Band {
                Id=123,
                Name = "Radiohead"
            },
            new Band {
                Id=462,
                Name = "The Smiths"
            },
            new Band {
                Id=55,
                Name = "Los Pericos"
            }
           ];

        public Band[] GetAll() => bands.ToArray();

        public void AddBand(Band band)
        {
            band.Id = bands.Count == 0 ? 1 : bands.Max(b => b.Id)+1;
            bands.Add(band);
        }
    }
}
