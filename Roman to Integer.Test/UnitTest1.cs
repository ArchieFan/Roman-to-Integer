namespace Roman_to_Integer.Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("I", 1)]
        [InlineData("II", 2)]
        [InlineData("III", 3)]
        [InlineData("IV", 4)]
        [InlineData("V", 5)]
        [InlineData("VI", 6)]
        [InlineData("VII", 7)]
        [InlineData("VIII", 8)]
        [InlineData("IX", 9)]
        [InlineData("X", 10)]
        [InlineData("LVIII", 58)]
        [InlineData("MCMXCIV", 1994)]
        [InlineData("MDCCCXCIV", 1894)]
        [InlineData("MMXVIII", 2018)]
        public void XUnitTest(string s, int expected)
        {
            Solution sol = new Solution();
            //int result = sol.RomanToInt(s);
            int result = sol.RomanToInt2(s);

            Assert.Equal(expected, result);
        }
    }
}