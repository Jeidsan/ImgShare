using System;

namespace ImgShare.Domain
{
    public class User
    {  
        public int Id { get; set; }
 
        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime InclusionDate { get; set; }
    }
}
