namespace MethodsPractice;

public static class ClairesCookies
{
    /*
     * Claire's cookies cost $12.95 a dozen.
     *
     * A customer orders a number of dozens. Return the price
     * of the order before tax.
     *
     * CalculateSubtotal(1) -> 12.95
     * CalculateSubtotal(2) -> 25.90
     * CalculateSubtotal(5) -> 64.75
     */
    public static decimal CalculateSubtotal(int dozens)
    {
        return 0;
    }

    /*
     * Claire must charge 5.75% sales tax on every order.
     *
     * Return the price of an order of $12.95-a-dozen cookies
     * AFTER tax is added. Round the tax to the nearest cent
     * before you add it.
     *
     * CalculateTotal(1) -> 13.69
     * CalculateTotal(2) -> 27.39
     * CalculateTotal(5) -> 68.47
     */
    public static decimal CalculateTotal(int dozens)
    {
        return 0;
    }

    /*
     * Claire's three most popular cookies have their own prices:
     *
     * Snickerdoodle            $12.95 a dozen
     * Chocolate Chip           $13.95 a dozen
     * Frosted Chocolate Chip   $15.95 a dozen
     *
     * Return the price of one dozen of the cookie named.
     * Return 0 for any other name. (A switch works well here.)
     *
     * GetPricePerDozen("Snickerdoodle") -> 12.95
     * GetPricePerDozen("Chocolate Chip") -> 13.95
     * GetPricePerDozen("Frosted Chocolate Chip") -> 15.95
     * GetPricePerDozen("Oatmeal") -> 0
     */
    public static decimal GetPricePerDozen(string cookieName)
    {
        return 0;
    }

    /*
     * A quick order is a number of dozens of each popular cookie.
     * Return the price of the order, with tax (5.75%, the tax
     * rounded to the nearest cent).
     *
     * CalculateQuickOrder(1, 1, 1) -> 45.31
     * CalculateQuickOrder(0, 3, 2) -> 77.99
     * CalculateQuickOrder(3, 1, 0) -> 55.84
     * CalculateQuickOrder(2, 0, 2) -> 61.12
     */
    public static decimal CalculateQuickOrder(int snickerdoodleDozens, int chocolateChipDozens, int frostedDozens)
    {
        return 0;
    }

    /*
     * Customers can also customize the $12.95-a-dozen cookie:
     *
     * chocolate chips   add $1.00 a dozen
     * frosting          adds $2.00 a dozen
     *
     * Return the price of the order, with tax (5.75%, the tax
     * rounded to the nearest cent).
     *
     * CalculateCustomOrder(1, true, true) -> 16.87
     * CalculateCustomOrder(2, true, false) -> 29.50
     * CalculateCustomOrder(3, false, true) -> 47.43
     * CalculateCustomOrder(5, true, false) -> 73.76
     */
    public static decimal CalculateCustomOrder(int dozens, bool hasChocolateChips, bool hasFrosting)
    {
        return 0;
    }
}
