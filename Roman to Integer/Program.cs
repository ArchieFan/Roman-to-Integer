public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;

        Dictionary<char, int> map = new Dictionary<char, int>();
        map.Add('I', 1);
        map.Add('V', 5);
        map.Add('X', 10);
        map.Add('L', 50);
        map.Add('C', 100);
        map.Add('D', 500);
        map.Add('M', 1000);

        char[] ch = s.Trim().ToCharArray();
        for (int i = 0; i < ch.Length; i++)
        {
            if ((i + 1) == ch.Length)
            {
                result = result + map[ch[i]];
            }
            else if (map[ch[i]] > map[ch[i + 1]])
            {
                result = result + map[ch[i]];
            }
            else if (map[ch[i]] < map[ch[i + 1]])
            {
                result = result + (map[ch[i + 1]] - map[ch[i]]);
                i++;
            }
            else if (map[ch[i]] == map[ch[i + 1]])
            {
                result = result + map[ch[i]];
            }
        }
        return result;
    }

    public int RomanToInt2(string s)
    {
        var dictionary = new Dictionary<char, int>();
        dictionary.Add('I', 1);
        dictionary.Add('V', 5);
        dictionary.Add('X', 10);
        dictionary.Add('L', 50);
        dictionary.Add('C', 100);
        dictionary.Add('D', 500);
        dictionary.Add('M', 1000);

        int solution = 0;

        /*
            They practically solved it, all we had to do was to read the question:
                I can be placed before V (5) and X (10) to make 4 and 9. 
                X can be placed before L (50) and C (100) to make 40 and 90. 
                C can be placed before D (500) and M (1000) to make 400 and 900.
        */
        s = s.Replace("IV", "IIII")
            .Replace("IX", "VIIII")
            .Replace("XL", "XXXX")
            .Replace("XC", "LXXXX")
            .Replace("CD", "CCCC")
            .Replace("CM", "DCCCC");

        foreach (char c in s)
        {
            solution += dictionary[c];
        }

        return solution;
    }

    public int RomanToInt3(string s)
    {
        Dictionary<char, int> roman = new Dictionary<char, int>()
        {
            { 'I', 1 },{ 'V', 5 },{ 'X', 10 },{ 'L', 50 },{ 'C', 100 },{ 'D', 500 },{ 'M', 1000 }
        };
        int res = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // (i + 1) < s.Length to make sure there is value come after the current pointer
            // and check if next roman is greater than current roman 
            if ((i + 1) < s.Length && roman[s[i]] < roman[s[i + 1]]) 
            {
                res -= roman[s[i]];
            } else
            {
                res += roman[s[i]];
            }
        }
        return res;
    }
    static void Main()
    {
        //string s = "I";
        //string s = "II";
        //string s = "III";
        //string s = "LVIII";
        string s = "MCMXCIV";
        Solution sol = new Solution();
        Console.WriteLine(sol.RomanToInt(s));

        Console.WriteLine(sol.RomanToInt2(s));

        Console.WriteLine(sol.RomanToInt3(s));

    }
}

