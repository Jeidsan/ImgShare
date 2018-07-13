using System;

namespace ImgShare.Domain
{
    public class Photo
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhotoHex { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public DateTime InclusionDate { get; set; }
    }
}
