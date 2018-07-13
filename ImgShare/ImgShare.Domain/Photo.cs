using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ImgShare.Domain
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhotoHex { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public DateTime InclusionDate { get; set; }
    }
}
