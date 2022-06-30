

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        [DataRow("LVIII", 58)]
        [DataRow("MCMXCIV", 1994)]
        [DataRow("MDCCCXCIV", 1894)]
        [DataRow("MMXVIII", 2018)]

        public void TestMethod1(string s, int expected)
        {
            Solution sol = new Solution();
            //int result = sol.RomanToInt(s);
            int result = sol.RomanToInt2(s);

            Assert.AreEqual(expected, result);
            
        }
    }
}