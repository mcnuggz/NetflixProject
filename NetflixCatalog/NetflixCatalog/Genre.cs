using System;
using System.Collections;
using System.Collections.Generic;

namespace NetflixCatalog
{
    public class Genre : IEnumerable
    {
        public string Name;
        public Genre()
        {

        }
        public Genre(string name)
        {
            this.Name = name;
        }
        public static List<Title> titleList = new List<Title>();
        public static List<Title> actionList = new List<Title>() { new Title("Die Hard",10), new Title("Teen Titans", 8) };
        public static List<Title> romanceList = new List<Title>() { new Title("When Harry Met Sally", 7), new Title("Titanic", 8)};
        public static List<Title> comedyList = new List<Title>() { new Title ("Airplane!", 8), new Title("Anchorman: The Legend of Ron Burgundy", 7) };
        public static List<Title> animatedList = new List<Title>() { new Title("Teen Titans", 9), new Title("Attack on Titan", 6) };
        public static List<Title> scifiList = new List<Title>() { new Title("2001: A Space Odyssey", 9), new Title("Inception", 8)};
        public static List<Title> dramaList = new List<Title>() { new Title("The Godfather", 10), new Title("Citizen Kane", 10)};

        public void AddToList(string name, int rating)
        {

            titleList.Add(new Title(name, rating));
        }

        public void AddToList(Title title)
        {
            titleList.Add(title);
        }
        public void PrintList()
        {
            foreach (Title title in titleList)
            {
                Console.WriteLine(title.Name + ": " + title.Rating.ToString() + "/10.");
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < titleList.Count; index++)
            {
                yield return titleList[index];
            }
        }

        public static Genre operator +(Title title, Genre genre)
        {         
            string addedGenre = genre.ToString();
            switch (addedGenre)
            {
                case "Action":
                    AddToActionList(title);
                    break;
                case "Animation":
                    AddToAnimationList(title);
                    break;
                case "Comedy":
                    AddToComedyList(title);
                    break;
                case "Drama":
                    AddToDramaList(title);
                    break;
                case "Romance":
                    AddToRomanceList(title);
                    break;
                case "SciFi":
                    AddToSciFiList(title);
                    break;
                default:
                    break;
            }
            return genre;
        }

        public static void AddToActionList(Title title)
        {
            Console.WriteLine("Action: ");
            if (!actionList.Contains(title))
            {
                actionList.Add(title);
                foreach (Title t in actionList)
                {
                    Console.WriteLine(t.Name + ": " + t.Rating.ToString() + "/10.");
                }
            }
            else
            {
                Console.WriteLine("Already exists in Action list");
            }
        }
        public static void AddToRomanceList(Title title)
        {
            Console.WriteLine("Romance Movies:");
            if (!romanceList.Contains(title))
            {
                romanceList.Add(title);
                foreach (Title t in romanceList)
                {
                    Console.WriteLine(t.Name + ": " + t.Rating.ToString() + "/10.");
                }
            }
            else
            {
                Console.WriteLine("Already exists in Romance list");
            }
        }
        public static void AddToComedyList(Title title)
        {
            Console.WriteLine("Comedy Movies:");
            if (!comedyList.Contains(title))
            {
                comedyList.Add(title);
                foreach (Title t in comedyList)
                {
                    Console.WriteLine(t.Name + ": " + t.Rating.ToString() + "/10.");
                }
            }
            else
            {
                Console.WriteLine("Already exists in Comedy list");
            }
        }
        public static void AddToAnimationList(Title title)
        {
            Console.WriteLine("Animated Movies:");
            if (!animatedList.Contains(title))
            {
                animatedList.Add(title);
                foreach (Title t in animatedList)
                {
                    Console.WriteLine(t.Name + ": " + t.Rating.ToString() + "/10.");
                }
            }
            else
            {
                Console.WriteLine("Already exists in Animation List");
            }
        }
        public static void AddToSciFiList(Title title)
        {
            Console.WriteLine("Sci-Fi Movies:");
            if (!scifiList.Contains(title))
            {
                scifiList.Add(title);
                foreach (Title t in scifiList)
                {
                    Console.WriteLine(t.Name + ": " + t.Rating.ToString() + "/10.");
                }
            }
            else
            {
                Console.WriteLine("Already exists in Sci-Fi list");
            }
        }
        public static void AddToDramaList(Title title)
        {
            Console.WriteLine("Drama Movies:");
            if (!dramaList.Contains(title))
            {
                dramaList.Add(title);
                foreach (Title t in dramaList)
                {
                    Console.WriteLine(t.Name + ": " + t.Rating.ToString() + "/10.");
                }
            }
            else
            {
                Console.WriteLine("Already exists in Drama list");
            }
        }
    }
}
