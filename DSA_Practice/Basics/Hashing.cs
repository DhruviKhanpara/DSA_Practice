namespace DSA_Practice.Basics
{
    public class Hashing
    {
        // Find out how many times the number appears in the array

        public static void BruteForce(int[] a, int n)
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                    count++;
            }
            Console.WriteLine(count);
        }

        // Using Hashing
        public static void HashForFrequency(int[] a, int[] q)
        {
            int[] frq = new int[a.Max()];
            for (int i = 0; i < a.Length; i++)
            {
                frq[a[i] - 1]++;
            }

            for (int i = 0; i < q.Length; i++)
            {
                if (q[i] > a.Max())
                    Console.Write(0 + " ");
                else
                    Console.WriteLine(frq[q[i] - 1] + " ");
            }
        }

        // Given the string: “abcdabefc” we are given some queries: [a, c, z]. For each query, we need to find out how many times the character appears in the string

        public static void BruteForceCount(string s, char n)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == n)
                    count++;
            }
            Console.WriteLine(count);
        }

        // Using Hashing

        // string is in lower
        public static void HashForLowerCharFrequency(string s, char[] q)
        {
            int[] frq = new int[26];
            s = s.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                frq[s[i] - 'a']++;
            }

            for (int i = 0; i < q.Length; i++)
            {
                Console.WriteLine(frq[q[i] - 'a'] + " ");
            }
        }

        // string is in lower + upper
        public static void HashForCharFrequency(string s, char[] q)
        {
            int[] frq = new int[256];

            for (int i = 0; i < s.Length; i++)
            {
                frq[s[i]]++;
            }

            for (int i = 0; i < q.Length; i++)
            {
                Console.WriteLine(frq[q[i]] + " ");
            }
        }

        // Using Dictionary
        public static void UsingDictionary(int[] a, int[] q)
        {
            Dictionary<int, int> frq = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                int key = a[i];
                if (frq.ContainsKey(key)) frq[key]++;
                else frq.Add(key, 1);
            }

            for (int i = 0; i < q.Length; i++)
            {
                Console.WriteLine(frq[q[i]] + " ");
            }
        }
    }
}
