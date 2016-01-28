using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class View
    {
        Genre genre;
        public void PrintCatalog()
        {
            foreach (Title title in genre.titleList)
            {
                Console.WriteLine(title.ToString());
            }
        }

    }
}
