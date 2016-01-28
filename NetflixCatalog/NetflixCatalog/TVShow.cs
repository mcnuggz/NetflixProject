using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    public class TVShow : Title
    {
        public List<Episode> episodes = new List<Episode>();
        int totalRating;
        public override string ToString()
        {
            return base.Name + "- " + episodes.Count + " episodes.";
        }
        public int AverageRating()
        {
            foreach (Episode episode in episodes)
            {
                totalRating += episode.rating;
            }

            return Convert.ToInt32(Rating = totalRating / episodes.Count);
        }

    }
}
