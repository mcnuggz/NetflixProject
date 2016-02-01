using Microsoft.VisualStudio.TestTools.UnitTesting;
using NetflixCatalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixCatalog.Tests
{
    [TestClass()]
    public class GenreTests
    {
        [TestMethod()]
        public void AddToListTest()
        {
            Genre g = new Genre("g");
            g.AddToList("Teen Titans", 9);
            Title expected = new Title("Teen Titans", 9);
            Title actual = Genre.titleList[0];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }

        [TestMethod()]
        public void AddToListTestNoParams()
        {
            Genre g = new Genre("g");
            Title batman = new Title("Batman Beyond", 8);
            g.AddToList(batman);

            Title expected = new Title("Batman Beyond", 8);
            Title actual = Genre.titleList[1];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);

        }

        [TestMethod()]
        public void AddToActionListTest()
        {

            Title madMax = new Title("Mad Max: Fury Road", 9);
            Genre.actionList.Add(madMax);

            Title expected = new Title("Mad Max: Fury Road", 9);
            Title actual = Genre.actionList[2];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }

        [TestMethod()]
        public void AddToRomanceListTest()
        {
            Title casablanca = new Title("Casablanca", 9);
            Genre.romanceList.Add(casablanca);

            Title expected = new Title("Casablanca", 9);
            Title actual = Genre.romanceList[2];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }

        [TestMethod()]
        public void AddToComedyListTest()
        {
            Title montyPython = new Title("Monty Python and The Holy Grail", 9);
            Genre.comedyList.Add(montyPython);

            Title expected = new Title("Monty Python and The Holy Grail", 9);
            Title actual = Genre.comedyList[2];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }

        [TestMethod()]
        public void AddToAnimationListTest()
        {
            Title nightmare = new Title("The Nightmare Before Christmas", 9);
            Genre.animatedList.Add(nightmare);

            Title expected = new Title("The Nightmare Before Christmas", 9);
            Title actual = Genre.animatedList[2];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }

        [TestMethod()]
        public void AddToSciFiListTest()
        {
            Title terminator = new Title("The Terminator", 9);
            Genre.scifiList.Add(terminator);

            Title expected = new Title("The Terminator", 9);
            Title actual = Genre.scifiList[2];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }

        [TestMethod()]
        public void AddToDramaListTest()
        {
            Title gravity = new Title("Gravity", 9);
            Genre.dramaList.Add(gravity);

            Title expected = new Title("Gravity", 9);
            Title actual = Genre.dramaList[2];

            Assert.AreEqual(expected.Name, actual.Name);
            Assert.AreEqual(expected.Rating, actual.Rating);
        }
        [TestMethod()]
        public void TestOverride()
        {
            Genre comedy = new Genre("Comedy");
            Title title2 = new Title("Chef", 9);
            Genre comedy2 = title2 + comedy;

            Assert.AreEqual(comedy, comedy2);
        }
  
    }
}