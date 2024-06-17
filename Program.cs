using System.Security.Cryptography.X509Certificates;

namespace Assignment_7._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vowelDict = new Dictionary<string, int> { { "a", 1 }, { "e", 2 }, { "i", 3 }, { "o", 4 }, { "u", 5 } };
            

            string s = "intelligent";

            int l = 0;
            int r = s.Length - 1;

            while (l < r) 
            {
                if (vowelDict.ContainsKey(s[l].ToString()) && vowelDict.ContainsKey(s[r].ToString()))
                {
                    char temp = s[l]; // Store the character at index i in a temporary variable
                    s = s.Remove(l, 1).Insert(l, s[r].ToString()); // Remove character at index l and insert the character at index r into index l
                    s = s.Remove(r, 1).Insert(r, temp.ToString()); // Remove character at index r and replace it with temp
                    l++;
                    r--;


                }
                else if (vowelDict.ContainsKey(s[l].ToString()) && !vowelDict.ContainsKey(s[r].ToString()))
                {
                    r--;
                }
                else if (!vowelDict.ContainsKey(s[l].ToString()) && vowelDict.ContainsKey(s[r].ToString()))
                {
                    l++;
                }
                else 
                {
                    l++;
                    r--;
                }


            }
            Console.WriteLine(s);
        }
    }
}
