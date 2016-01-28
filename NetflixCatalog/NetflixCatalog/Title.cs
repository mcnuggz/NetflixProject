using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Title
    {

        protected int? Rating { get; set; }
        protected string Name { get; private set; }


        public Title()
        {
            this.Name = null;
            this.Rating = null;
        }

        public Title(string name, int rating)
        {
            this.Name = name;
            this.Rating = rating;
        }


    }
}
