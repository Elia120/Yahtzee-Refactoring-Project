using NUnit.Framework;

namespace Yahtzee
{
    [TestFixture]
    public class YahtzeeTest
    {
        [Test]
        public void Chance_scores_sum_of_all_dice()
        {
            int expected = 15;
            int actual = Yahtzee.Chance(2, 3, 4, 5, 1);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(16, Yahtzee.Chance(3, 3, 4, 5, 1));
        }

        [Test]
        public void Yahtzee_scores_50()
        {
            int expected = 50;
            int actual = Yahtzee.yahtzee(4, 4, 4, 4, 4);
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(50, Yahtzee.yahtzee(6, 6, 6, 6, 6));
            Assert.AreEqual(0, Yahtzee.yahtzee(6, 6, 6, 6, 3));
        }

        [Test]
        public void Test_1s()
        {
            Assert.IsTrue(Yahtzee.Nubers(1, 1, 2, 3, 4, 5) == 1);
            Assert.AreEqual(2, Yahtzee.Nubers(1, 1, 2, 1, 4, 5));
            Assert.AreEqual(0, Yahtzee.Nubers(1, 6, 2, 2, 4, 5));
            Assert.AreEqual(4, Yahtzee.Nubers(1, 1, 2, 1, 1, 1));
        }

        [Test]
        public void test_2s()
        {
            Assert.AreEqual(4, Yahtzee.Nubers(2, 1, 2, 3, 2, 6));
            Assert.AreEqual(10, Yahtzee.Nubers(2, 2, 2, 2, 2, 2));
        }

        [Test]
        public void test_3s()
        {
            Assert.AreEqual(6, Yahtzee.Nubers(3, 1, 2, 3, 2, 3));
            Assert.AreEqual(12, Yahtzee.Nubers(3, 2, 3, 3, 3, 3));
        }

        [Test]
        public void test_4s()
        {
            Assert.AreEqual(12, Yahtzee.Nubers(4, 4, 4, 4, 5, 5));
            Assert.AreEqual(8, Yahtzee.Nubers(4, 4, 4, 5, 5, 5));
            Assert.AreEqual(4, Yahtzee.Nubers(4, 4, 5, 5, 5, 5));
        }

        [Test]
        public void test_5s()
        {
            Assert.AreEqual(10, Yahtzee.Nubers(5, 4, 4, 4, 5, 5));
            Assert.AreEqual(15, Yahtzee.Nubers(5, 4, 4, 5, 5, 5));
            Assert.AreEqual(20, Yahtzee.Nubers(5, 4, 5, 5, 5, 5));
        }

        [Test]
        public void test_6s()
        {
            Assert.AreEqual(0, Yahtzee.Nubers(6, 4, 4, 4, 5, 5));
            Assert.AreEqual(6, Yahtzee.Nubers(6, 4, 4, 6, 5, 5));
            Assert.AreEqual(18, Yahtzee.Nubers(6, 6, 5, 6, 6, 5));
        }

        [Test]
        public void three_of_a_kind()
        {
            Assert.AreEqual(18, Yahtzee.Multiples(3, 3, 3, 3, 4, 5));
            Assert.AreEqual(22, Yahtzee.Multiples(3, 5, 3, 5, 4, 5));
            Assert.AreEqual(17, Yahtzee.Multiples(3, 3, 3, 3, 3, 5));
        }

        [Test]
        public void four_of_a_kind()
        {
            Assert.AreEqual(17, Yahtzee.Multiples(4, 3, 3, 3, 3, 5));
            Assert.AreEqual(24, Yahtzee.Multiples(4, 5, 5, 5, 4, 5));
            Assert.AreEqual(15, Yahtzee.Multiples(4, 3, 3, 3, 3, 3));
            Assert.AreEqual(0, Yahtzee.Multiples(4, 1, 2, 3, 3, 3));
        }

        [Test]
        public void smallStraight()
        {
            Assert.AreEqual(30, Yahtzee.Straights(4, 1, 2, 3, 4, 5));
            Assert.AreEqual(30, Yahtzee.Straights(4, 2, 3, 4, 5, 1));
            Assert.AreEqual(0, Yahtzee.Straights(4, 1, 2, 2, 4, 5));
        }

        [Test]
        public void largeStraight()
        {
            Assert.AreEqual(40, Yahtzee.Straights(5, 6, 2, 3, 4, 5));
            Assert.AreEqual(40, Yahtzee.Straights(5, 2, 3, 4, 5, 6));
            Assert.AreEqual(0, Yahtzee.Straights(5, 1, 2, 2, 4, 5));
        }

        [Test]
        public void fullHouse()
        {
            Assert.AreEqual(25, Yahtzee.FullHouse(6, 2, 2, 2, 6));
            Assert.AreEqual(0, Yahtzee.FullHouse(2, 3, 4, 5, 6));
        }
    }
}