using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class Movie : Title
    {
        public int Duration;
        public override string ToString()
        {
            return base.Name + "- " + this.Duration;
        }
    }
}
