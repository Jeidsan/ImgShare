using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImgShareWebServices.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public User IdUser { get; set; }
        public string Name { get; set; }
        public string PhotoHex { get; set; }
        public string Locality { get; set; }
        public DateTime InclusionDate { get; set; }
    }
}
