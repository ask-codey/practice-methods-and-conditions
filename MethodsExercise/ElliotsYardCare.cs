namespace MethodsExercise;

public static class ElliotsYardCare
{
    /*
     * Elliot mows lawns. His gas and supplies cost him money for
     * every 1,000 square feet he mows:
     *
     * mowing only           $2.50 per 1,000 sq ft
     * mowing and trimming   $3.00 per 1,000 sq ft
     *
     * A yard's area is its width times its length, in feet.
     * Return Elliot's cost for a job, rounded to the nearest cent.
     *
     * CalculateCost(100, 50, false) -> 12.50
     * CalculateCost(100, 50, true) -> 15.00
     * CalculateCost(75, 75, true) -> 16.88
     */
    public static decimal CalculateCost(int width, int length, bool isTrimming)
    {
        return 0;
    }

    /*
     * Elliot wants to know his profit on a job: what he charged,
     * minus his cost.
     *
     * CalculateProfit(100, 50, false, 50) -> 37.50
     * CalculateProfit(100, 50, true, 50) -> 35.00
     * CalculateProfit(75, 75, true, 50) -> 33.12
     * CalculateProfit(150, 100, true, 75) -> 30.00
     */
    public static decimal CalculateProfit(int width, int length, bool isTrimming, int amountCharged)
    {
        return 0;
    }

    /*
     * Mowing takes Elliot 30 minutes per 1,000 sq ft. Mowing and
     * trimming takes 45 minutes per 1,000 sq ft.
     *
     * Return how many hours a job takes, rounded to 2 decimal places.
     *
     * CalculateTime(100, 50, false) -> 2.5
     * CalculateTime(100, 50, true) -> 3.75
     * CalculateTime(75, 75, true) -> 4.22
     * CalculateTime(100, 80, true) -> 6
     */
    public static double CalculateTime(int width, int length, bool isTrimming)
    {
        return 0;
    }

    /*
     * Elliot describes a yard by its area:
     *
     * under 5,000 sq ft            "small"
     * 5,000 up to 10,000 sq ft     "medium"
     * 10,000 sq ft or more         "large"
     *
     * GetYardSize(50, 80) -> "small"
     * GetYardSize(100, 50) -> "medium"
     * GetYardSize(100, 99) -> "medium"
     * GetYardSize(100, 100) -> "large"
     */
    public static string GetYardSize(int width, int length)
    {
        return "";
    }

    /*
     * Elliot doesn't charge by the hour. He charges by the job, in
     * steps of $25: $25, $50, $75 and so on. The smallest price is $25.
     *
     * A job's price must cover his cost AND pay him at least $10
     * for every hour the job takes. Add those two together, then
     * round up to the next $25 step.
     *
     * Example: a 100 x 50 yard, mowing only, costs $12.50 and takes
     * 2.5 hours, so he needs at least 12.50 + 25.00 = 37.50. The next
     * $25 step is $50.
     *
     * CalculatePrice(100, 50, false) -> 50
     * CalculatePrice(100, 50, true) -> 75
     * CalculatePrice(75, 75, true) -> 75
     * CalculatePrice(100, 75, true) -> 100
     * CalculatePrice(10, 10, false) -> 25
     */
    public static decimal CalculatePrice(int width, int length, bool isTrimming)
    {
        return 0;
    }
}
