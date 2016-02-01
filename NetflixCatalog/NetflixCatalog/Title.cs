using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {
        public string Name { get; set; }
        public int? Rating { get; set; }

        public Title(string name, int rating)
        {
            this.Name = name;
            this.Rating = rating;
        }
        public Title()
        {
            this.Name = null;
            this.Rating = null;
        }
        
    }
}
