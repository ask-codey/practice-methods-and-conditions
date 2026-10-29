using MethodsPractice;

namespace MethodsPractice.Tests;

// Each test calls one of your methods with the values in a DataRow
// and checks what it returns. You don't need to change this file.
// (Attributes can't hold decimal values, so money is written as a
// double here and turned into a decimal before it's compared.)

[TestClass]
public class BackyardBasketballTests
{
    [TestMethod]
    [DataRow(7, 3, 70)]
    [DataRow(5, 5, 50)]
    [DataRow(5, 10, 33)]
    public void CalculateWinningPercentage(int gamesWon, int gamesLost, int expected)
    {
        int actual = BackyardBasketball.CalculateWinningPercentage(gamesWon, gamesLost);

        Assert.AreEqual(expected, actual, $"A team with {gamesWon} wins and {gamesLost} losses has won {expected}% of its games.");
    }

    [TestMethod]
    [DataRow(70, 10, false, 14)]
    [DataRow(70, 10, true, 21)]
    [DataRow(67, 15, false, 20)]
    public void CalculatePointsScored(int shotPercentage, int shotsTaken, bool isThree, int expected)
    {
        int actual = BackyardBasketball.CalculatePointsScored(shotPercentage, shotsTaken, isThree);

        Assert.AreEqual(expected, actual, $"Making {shotPercentage}% of {shotsTaken} shots (three-pointers: {isThree}) scores {expected} points.");
    }

    [TestMethod]
    [DataRow(50, 10, false, 10)]
    [DataRow(50, 10, true, 8)]
    [DataRow(75, 15, true, 7)]
    [DataRow(80, 18, true, 8)]
    [DataRow(67, 24, false, 18)]
    public void CalculateShotsRequired(int shotPercentage, int desiredScore, bool isThree, int expected)
    {
        int actual = BackyardBasketball.CalculateShotsRequired(shotPercentage, desiredScore, isThree);

        Assert.AreEqual(expected, actual, $"To score {desiredScore} points making {shotPercentage}% of shots (three-pointers: {isThree}), a player needs {expected} shots.");
    }
}

[TestClass]
public class ClairesCookiesTests
{
    [TestMethod]
    [DataRow(1, 12.95)]
    [DataRow(2, 25.90)]
    [DataRow(5, 64.75)]
    public void CalculateSubtotal(int dozens, double expected)
    {
        decimal actual = ClairesCookies.CalculateSubtotal(dozens);

        Assert.AreEqual((decimal)expected, actual, $"{dozens} dozen cookies cost ${expected} before tax.");
    }

    [TestMethod]
    [DataRow(1, 13.69)]
    [DataRow(2, 27.39)]
    [DataRow(5, 68.47)]
    public void CalculateTotal(int dozens, double expected)
    {
        decimal actual = ClairesCookies.CalculateTotal(dozens);

        Assert.AreEqual((decimal)expected, actual, $"{dozens} dozen cookies cost ${expected} with tax.");
    }

    [TestMethod]
    [DataRow("Snickerdoodle", 12.95)]
    [DataRow("Chocolate Chip", 13.95)]
    [DataRow("Frosted Chocolate Chip", 15.95)]
    [DataRow("Oatmeal", 0.0)]
    public void GetPricePerDozen(string cookieName, double expected)
    {
        decimal actual = ClairesCookies.GetPricePerDozen(cookieName);

        Assert.AreEqual((decimal)expected, actual, $"A dozen {cookieName} cookies cost ${expected}.");
    }

    [TestMethod]
    [DataRow(1, 1, 1, 45.31)]
    [DataRow(0, 3, 2, 77.99)]
    [DataRow(3, 1, 0, 55.84)]
    [DataRow(2, 0, 2, 61.12)]
    public void CalculateQuickOrder(int snickerdoodleDozens, int chocolateChipDozens, int frostedDozens, double expected)
    {
        decimal actual = ClairesCookies.CalculateQuickOrder(snickerdoodleDozens, chocolateChipDozens, frostedDozens);

        Assert.AreEqual((decimal)expected, actual, $"{snickerdoodleDozens} Snickerdoodle, {chocolateChipDozens} Chocolate Chip and {frostedDozens} Frosted Chocolate Chip dozens cost ${expected} with tax.");
    }

    [TestMethod]
    [DataRow(1, true, true, 16.87)]
    [DataRow(2, true, false, 29.50)]
    [DataRow(3, false, true, 47.43)]
    [DataRow(5, true, false, 73.76)]
    public void CalculateCustomOrder(int dozens, bool hasChocolateChips, bool hasFrosting, double expected)
    {
        decimal actual = ClairesCookies.CalculateCustomOrder(dozens, hasChocolateChips, hasFrosting);

        Assert.AreEqual((decimal)expected, actual, $"{dozens} dozen (chocolate chips: {hasChocolateChips}, frosting: {hasFrosting}) cost ${expected} with tax.");
    }
}

[TestClass]
public class ElliotsYardCareTests
{
    [TestMethod]
    [DataRow(100, 50, false, 12.50)]
    [DataRow(100, 50, true, 15.00)]
    [DataRow(75, 75, true, 16.88)]
    public void CalculateCost(int width, int length, bool isTrimming, double expected)
    {
        decimal actual = ElliotsYardCare.CalculateCost(width, length, isTrimming);

        Assert.AreEqual((decimal)expected, actual, $"A {width} x {length} yard (trimming: {isTrimming}) costs Elliot ${expected}.");
    }

    [TestMethod]
    [DataRow(100, 50, false, 50, 37.50)]
    [DataRow(100, 50, true, 50, 35.00)]
    [DataRow(75, 75, true, 50, 33.12)]
    [DataRow(150, 100, true, 75, 30.00)]
    public void CalculateProfit(int width, int length, bool isTrimming, int amountCharged, double expected)
    {
        decimal actual = ElliotsYardCare.CalculateProfit(width, length, isTrimming, amountCharged);

        Assert.AreEqual((decimal)expected, actual, $"Charging ${amountCharged} for a {width} x {length} yard (trimming: {isTrimming}) makes a profit of ${expected}.");
    }

    [TestMethod]
    [DataRow(100, 50, false, 2.5)]
    [DataRow(100, 50, true, 3.75)]
    [DataRow(75, 75, true, 4.22)]
    [DataRow(100, 80, true, 6.0)]
    public void CalculateTime(int width, int length, bool isTrimming, double expected)
    {
        double actual = ElliotsYardCare.CalculateTime(width, length, isTrimming);

        Assert.AreEqual(expected, actual, $"A {width} x {length} yard (trimming: {isTrimming}) takes {expected} hours.");
    }

    [TestMethod]
    [DataRow(50, 80, "small")]
    [DataRow(100, 50, "medium")]
    [DataRow(100, 99, "medium")]
    [DataRow(100, 100, "large")]
    public void GetYardSize(int width, int length, string expected)
    {
        string actual = ElliotsYardCare.GetYardSize(width, length);

        Assert.AreEqual(expected, actual, $"A {width} x {length} yard is {expected}.");
    }

    [TestMethod]
    [DataRow(100, 50, false, 50)]
    [DataRow(100, 50, true, 75)]
    [DataRow(75, 75, true, 75)]
    [DataRow(100, 75, true, 100)]
    [DataRow(10, 10, false, 25)]
    public void CalculatePrice(int width, int length, bool isTrimming, int expected)
    {
        decimal actual = ElliotsYardCare.CalculatePrice(width, length, isTrimming);

        Assert.AreEqual((decimal)expected, actual, $"Elliot charges ${expected} for a {width} x {length} yard (trimming: {isTrimming}).");
    }
}
