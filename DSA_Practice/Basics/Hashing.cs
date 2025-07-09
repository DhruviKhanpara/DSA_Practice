using System;

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

        // --------------------------------------------------------------------------------------------------------------------------
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

        // --------------------------------------------------------------------------------------------------------------------------
        // Given an array of size N. Find the highest and lowest frequency element.
        public static void BruteForceFrequency(int[] a)
        {
            int min = 0, max = a.Length, minEle = 0, maxEle = 0;
            bool[] tracking = new bool[a.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (tracking[i] == true)
                    continue;

                int count = 0;
                for (int j = i; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        tracking[j] = true;
                        count++;
                    }
                }

                if (count > max)
                {
                    max = count;
                    maxEle = i;
                }
                if (count < min)
                {
                    min = count;
                    minEle = i;
                }
            }

            Console.WriteLine("Max element: " + maxEle + " count: " + max);
            Console.WriteLine("Min element: " + minEle + " count: " + min);
        }

        // Using Dictionary
        public static void UsingDictionaryFrequency(int[] a)
        {
            Dictionary<int, int> frq = new Dictionary<int, int>();
            for (int i = 0; i < a.Length; i++)
            {
                int key = a[i];
                if (frq.ContainsKey(key)) frq[key]++;
                else frq.Add(key, 1);
            }

            var max = new KeyValuePair<int, int>();
            var min = new KeyValuePair<int, int>();
            foreach (var item in frq)
            {
                if (item.Value > max.Value)
                    max = item;
                if (item.Value < min.Value)
                    min = item;
            }
            Console.WriteLine("Max element: " + max.Key + " count: " + max.Value);
            Console.WriteLine("Min element: " + min.Key + " count: " + min.Value);
        }

        // You are given an integer array nums and an integer k. In one operation, you can choose an index of nums and increment the element at that index by 1.
        public static void MaxFrequencySlidingWindow(int[] a, int k)
        {
            Array.Sort(a);
            int left = 0;
            int max = 0;
            long curr = 0;

            for (int right = 0; right < a.Length; right++)
            {
                long target = a[right];
                curr += target;

                while ((right - left + 1) * target - curr > k)
                {
                    curr -= a[left];
                    left++;
                }

                max = Math.Max(max, right - left + 1);
            }

            Console.WriteLine(max);
        }
    }
}
