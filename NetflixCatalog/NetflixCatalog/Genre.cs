using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public enum MovieGenre
    {
        All,
        Romance,
        Action,
        Comedy,
        Drama,
        Fantasy,
        SciFi,
        RomanticComedy
    }
    public class Genre : IEnumerable
    {
        public List<Title> titleList = new List<Title>();

        public IEnumerator GetEnumerator()
        {
            foreach (Title title in titleList)
            {
                yield return title;
            }
        }

        public static string operator + (Genre genre1, Genre genre2)
        {
            string combinedGenre = genre1 + ", " + genre2;
            return combinedGenre;
        }

        public static string operator + (Title title, Genre genre)
        {
            return title + "- " + genre;
        }
    }
}
