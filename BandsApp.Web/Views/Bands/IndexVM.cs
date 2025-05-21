namespace BandsApp.Web.Views.Bands
{
    public class IndexVM
    {
        public required BandItemVM[] Bands { get; set; }
        public class BandItemVM
        {
            public required string Name { get; set; }
        }
    }
}
