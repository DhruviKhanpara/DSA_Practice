using System;

namespace DSA_Practice.Basics
{
    public static class Patterns
    {
        public static void Pattern1(int n)
        {
            // Input: 3
            // * * *
            // * * *
            // * * *

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern2(int n)
        {
            // Input: 3
            // * 
            // * *
            // * * *

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern3(int n)
        {
            // Input: 3
            // 1
            // 1 2
            // 1 2 3

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((j + 1) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern4(int n)
        {
            // Input: 3
            // 1
            // 2 2
            // 3 3 3

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((i + 1) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern5(int n)
        {
            // Input: 3
            // * * *
            // * *
            // *

            // Method 1

            for (int i = n; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Method 2

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Method 3

            for (int i = 0; i < n; i++)
            {
                for (int j = n; j > i; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern6(int n)
        {
            // Input: 3
            // 1 2 3
            // 1 2
            // 1

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < (n - i); j++)
                {
                    Console.Write((j + 1) + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern7(int n)
        {
            // Input: 3
            //   *  
            //  ***
            // *****

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }

        public static void Pattern8(int n)
        {
            // Input: 3
            // *****  
            //  ***
            //   *

            for (int i = n; i > 0; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }

        public static void Pattern9(int n)
        {
            // Input: 3
            //   *  
            //  ***
            // *****
            // *****
            //  ***
            //   *

            // Upper half including the middle row
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }

            // Lower half
            for (int i = n; i >= 1; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(new string('*', 2 * i - 1));
            }
        }

        public static void Pattern10(int n)
        {
            // Input: 3
            // *  
            // **
            // ***
            // **
            // *

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*', i + 1));
            }

            for (int i = n - 1; i > 0; i--)
            {
                Console.WriteLine(new string('*', i));
            }
        }

        public static void Pattern11(int n)
        {
            // Input: 3
            // 1
            // 01
            // 101

            for (int i = 0; i < n; i++)
            {
                int start = (i + 1) % 2 == 0 ? 0 : 1;

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(start);
                    start = 1 - start;
                }
                Console.WriteLine();
            }
        }

        public static void Pattern12(int n)
        {
            // Input: 3
            // 1    1
            // 12  21
            // 123321

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1);
                }

                Console.Write(new string(' ', 2 * (n - i - 1)));

                for (int j = i; j >= 0; j--)
                {
                    Console.Write(j + 1);
                }

                Console.WriteLine();
            }
        }

        public static void Pattern13(int n)
        {
            // Input: 3
            // 1
            // 2 3
            // 4 5 6

            int count = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(count + " ");
                    count++;
                }
                Console.WriteLine();
            }
        }

        public static void Pattern14(int n)
        {
            // Input: 3
            // A
            // A B
            // A B C

            for (int i = 0; i < n; i++)
            {
                for (char j = 'A'; j <= 'A' + i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern15(int n)
        {
            // Input: 3
            // A B C
            // A B
            // A

            for (int i = 0; i < n; i++)
            {
                for (char j = 'A'; j < 'A' + (n - i); j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern16(int n)
        {
            // Input: 3
            // A
            // B B
            // C C C

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write((char)('A' + i));
                }
                Console.WriteLine();
            }
        }

        public static void Pattern17(int n)
        {
            // Input: 3
            //   A  
            //  ABA
            // ABCBA

            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(' ', n - i - 1));

                char latter = 'A';
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write(latter);
                    if (j < (2 * i + 1) / 2)
                        latter++; 
                    else latter--;
                }
                Console.WriteLine();
            }
        }

        public static void Pattern18(int n)
        {
            // Input: 3
            // C
            // B C
            // A B C

            for (int i = 0; i < n; i++)
            {
                for (char j = (char)('A' + n - 1 - i); j <= (char)('A' + n - 1); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

        public static void Pattern19(int n)
        {
            // Input: 3
            // ******
            // **  **
            // *    *
            // *    *
            // **  **
            // ******

            for (int i = 0; i < 2 * n; i++)
            {
                int space = i < n ? 2 * i : (2 * n - i - 1) * 2;
                int check = (2 * n - space) / 2 - 1; 
                // (2 * n - space) means number of space have *, divide it by 2 because we want half before space and half after, and -1 because we need index and it's 0 based

                for (int j = 0; j < 2 * n; j++)
                {
                    if (j > check && space > 0)
                    {
                        Console.Write(" ");
                        space--;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern20(int n)
        {
            // Input: 3
            // *    *
            // **  **
            // ******
            // **  **
            // *    *

            for (int i = 0; i < 2 * n; i++)
            {
                int space = i < n ? 2 * (n - i - 1) : 2 * (i - n);
                int check = (2 * n - space) / 2 - 1;

                for (int j = 0; j < 2 * n; j++)
                {
                    if (j > check && space > 0)
                    {
                        Console.Write(" ");
                        space--;
                    }
                    else
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void Pattern21(int n)
        {
            // Input: 3
            // ***
            // * *
            // ***

            for (int i = 0; i < n; i++)
            {
                if (i == 0 || i == n - 1)
                    Console.WriteLine(new string('*', n));
                else
                {
                    Console.Write("*");
                    Console.Write(new string(' ', n - 2));
                    Console.WriteLine("*");
                }
            }
        }

        public static void Pattern22(int n)
        {
            // Input: 3
            // 3 3 3 3 3 
            // 3 2 2 2 3
            // 3 2 1 2 3
            // 3 2 2 2 3
            // 3 3 3 3 3

            for (int i = 0; i < 2 * n - 1; i++)
            {
                for (int j = 0; j < 2 * n - 1; j++)
                {
                    int top = i;
                    int bottom = (2 * n - 2) - i;
                    int left = j;
                    int right = (2 * n - 2) - j;

                    Console.Write(n - Math.Min(Math.Min(top, bottom), Math.Min(left, right)) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}