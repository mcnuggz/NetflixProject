using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            View view = new View();
            
            Genre action = new Genre("Action");
            Genre animation = new Genre("Animation");
            Genre comedy = new Genre("Comedy");
            Genre drama = new Genre("Drama");
            Genre romance = new Genre("Romance");
            Genre scifi = new Genre("Sci-Fi");

            Title title1 = new Title("Toy Story", 9);
            Title ToyStory = title1;

            Title title2 = new Title("Sunset Boulevard", 9);
            Title sunsetBlvd = title2;


            drama = title2 + drama;
            animation = title1 + animation;

            Genre.AddToAnimationList(title1);
            Console.WriteLine("");
            Genre.AddToDramaList(title2);
            Console.ReadLine();
        }
    }
}
