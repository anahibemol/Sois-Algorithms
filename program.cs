using System;
using System.Linq;
using System.Collections;

namespace SoisAlgorithms
{
    public static class Program
    {
        public static class Algorithms
        {
            public static void FizzBuzz()
            {
                Console.WriteLine("Problem extracted from this video https://www.youtube.com/watch?v=1t1_a1BZ04o ");

                Console.WriteLine(@"
                Problem:
                For 1 to 100
                
                print 'Fizz'     if a number is divisible by 3
                print 'Buzz'     if a number is divisible by 5
                print 'FizzBuzz' if a number is divisible by both
                print 'Bazz'     if a number is divisible by 7
                print the number if it is anything else");
                
                for (int i = 1;i < 100; i++)
                {
                    Console.WriteLine();
                         if (i % 3 == 0) { Console.Write("Fizz"); }
                         if (i % 5 == 0) { Console.Write("Buzz"); }
                         if (i % 7 == 0) { Console.Write("Bazz"); }
                    else if (i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                                         { Console.Write(i); }
                    
                }
            }

            public static void TwoSum()
            {
                Console.WriteLine("Problem extracted from this site https://www.shorturl.at/uvX38 ");

                Console.WriteLine(@"
                Problem:
                
                Find all the pairs of two integers in an unsorted array that sum up to a given S");

                Console.WriteLine(@"For this problem, we will use Lists instead of arrays since they
                work much better for C# and make the problem more customizable");

                List<int> initialList = new List<int>{};

                Console.WriteLine("How many elements will your two sum List have ?");
                int limiter = Convert.ToInt32(Console.ReadLine());
                
                for (int i = 1; limiter+1 > i; i++)
                {
                    Console.WriteLine($"({limiter - i} remaining!) Write the next number");
                    int a = Convert.ToInt32(Console.ReadLine());
                    initialList.Add(a);
                }

                Console.WriteLine("Now write the S (value that will be the result of the sum)");
                int S = Convert.ToInt32(Console.ReadLine());

                List<string> sumList = new List<string>{};
                for (int i = 0; limiter > i; i++)
                {
                    if (initialList[i] + initialList[^(1+i)] == S)
                    {
                    string match = $"{initialList[i]} + {initialList[^(i+1)]} is equal to {S}";
                    sumList.Add(match);
                    }
                }
                Console.WriteLine("The inputted array (list):");
                Console.WriteLine(string.Join(" ", initialList));

                Console.WriteLine("The sums that give the result:");
                Console.WriteLine(string.Join("\n", sumList));
            }
        
            public static void Extense()
            {
                /*
                Console.WriteLine("Problem taken from this tweet https://twitter.com/MyNickIsNick_/status/1554513876284313601?t=enAJiS9_TporKHyUocsXhw&s=19");
                Console.WriteLine("For now, it only works from 1 to 20");

                Console.WriteLine(@"
                Problem:
                For 1 to ?? (still undefined)
                
                print number in extense by algorithm");
                */
                Console.WriteLine("WIP");
                
            }
        
            public static void Roman()
            {
                Console.WriteLine("Problem extracted from this site https://leetcode.com/problems/roman-to-integer/ ");

                Console.WriteLine(@"
                Problem:
                
                Given a roman numeral, convert it to an integer.");

                Console.WriteLine("Write your Roman Numeral");

                string roman = Console.ReadLine() ?? "UNSET";
                int Number = 0;
                int Number2 = 0;
                int size = roman.Length;
                roman = roman.ToUpper();
                if (roman != "UNSET")             
                {
                    char[] characters = roman.ToCharArray();
                    Console.WriteLine(characters);
                    foreach(char c in roman)
                    {
                        Console.WriteLine(c);
                        if (c=='I')
                        {
                            Number = Number+1;
                            Number2 = Number+1;
                        }
                        if (c=='V')
                        {
                            Number = Number+5;
                            if (Number2 == Number) //knowing the number is read from left to right, it will discover it beforehand.
                            {
                                Number = Number-2;
                            }
                            Number2 = Number;
                            
                        }
                        if (c=='X')
                        {
                            Number = Number+10;
                            if (Number2 == Number) //knowing the number is read from left to right, it will discover it beforehand.
                            {
                                Number = Number-2;
                            }
                            Number2 = Number;
                        }
                        if (c=='L')
                        {
                            Number = Number+50;
                            if (Number2 == Number) //knowing the number is read from left to right, it will discover it beforehand.
                            {
                                Number = Number-20;
                            }
                            Number2 = Number;
                        }
                        if (c=='C')
                        {
                            Number = Number+100;
                            if (Number2 == Number) //knowing the number is read from left to right, it will discover it beforehand.
                            {
                                Number = Number-20;
                            }
                            Number2 = Number;
                        }
                        if (c=='D')
                        {
                            Number = Number+500;
                            if (Number2 == Number) //knowing the number is read from left to right, it will discover it beforehand.
                            {
                                Number = Number-200;
                            }
                            Number2 = Number;
                        }
                        if (c=='M')
                        {
                            Number = Number+1000;
                            if (Number2 == Number) //knowing the number is read from left to right, it will discover it beforehand.
                            {
                                Number = Number-200;
                            }
                            Number2 = Number;
                        }
                    }

                    Console.WriteLine(Number);
                }
                else
                {
                    Console.WriteLine("Please write something");
                }
                
            }

            public static void Palindrome()
            {
                Console.WriteLine("Problem extracted from this site https://leetcode.com/problems/palindrome-number/ ");

                Console.WriteLine(@"
                Problem:
                
                Given an integer x, return true if x is palindrome integer.");

                Console.WriteLine("Write your number");
               string xStr = Console.ReadLine() ?? "1";

               List<char> Nlist = new List<char>{};
               List<char> Rlist = new List<char>{};

               foreach(char c in xStr)
               {
                Nlist.Add(c);
               }
               foreach(char c in xStr.Reverse())
               {
                Rlist.Add(c);
               }

            if (string.Join(" ", Nlist) != string.Join(" ", Rlist))
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }

                
            }

            public static void LastWordLength()
            {
                Console.WriteLine("Problem extracted from this site https://leetcode.com/problems/length-of-last-word/ ");

                Console.WriteLine(@"
                Problem:
                
                Given a string s consisting of words and spaces, return the length of the last word in the string.");

                Console.WriteLine("Write your text");
                string s = Console.ReadLine() ?? "No Text was Imputted";
                List<string>Words = new List<string>{};
                 var results = s.Split(' ').Where(x => x.Length > 3)
                 /**/              .GroupBy(x => x)
                 /**/              .Select(x => new { Count = x.Count(), Word = x.Key })
                 /**/              .OrderByDescending(x => x.Count);
                 foreach (var item in results)
                 {
                        Words.Add(item.Word);
                 }
                string LastWord  = Words[^1];
                int LastWordC = LastWord.Length; 
                 Console.WriteLine(LastWord);
                 Console.WriteLine(LastWordC);

            }

            public static void OnedSum()
            {
                Console.WriteLine("Problem extracted from this site https://leetcode.com/problems/running-sum-of-1d-array/ ");

                Console.WriteLine(@"
                Problem:
                
                Given an array nums. We define a running sum of an array as runningSum[i] = sum(nums[0]…nums[i]).
                Return the running sum of nums.");

                Console.WriteLine("How many elements will your List have");
                int i1 = Convert.ToInt32(Console.ReadLine());
                List<int> I_List = new List<int>{};
                List<int> O_List = new List<int>{};
                while (i1 > 0)
                {
                    Console.WriteLine($"({i1} Remaining!) Write your number");

                    int Number = Convert.ToInt32(Console.ReadLine());
                    I_List.Add(Number);
                    i1--;

                }

                for(int i = 0; i < I_List.Count(); i++)
                {
                    if(i == 0)
                    {
                        O_List.Add(I_List[i]);
                    }
                    else
                    {
                        O_List.Add(I_List[i]+I_List[i-1]);
                    }
                }
        
            Console.WriteLine("Input:");
            Console.WriteLine(string.Join(" ", I_List));
            Console.WriteLine();
            Console.WriteLine("Output:");
            Console.WriteLine(string.Join(" ", O_List));
            
            }

            public static void PrimeCheck()
            {
                Console.WriteLine("Write your number");
                int num = Convert.ToInt32(Console.ReadLine() ?? "2");
                int prime = 0;
                for(int n = 2; n <= num; n++)
                {                
                    int primecheck = 0;
                    for(int i = 1; i < n; i++)
                    {
                        if(n % i == 0) {primecheck = primecheck+1; }
                    }
                    if (primecheck > 1) {Console.WriteLine($"{n} is not prime"); }
                    else                {Console.WriteLine($"{n} is prime"); prime = prime+1;}
                }

            }

            public static void EvenFibonacci()
            {
                List<long> Fibonacci = new List<long>{};
                long i1 = 1;
                Fibonacci.Add(i1);
                long i2 = 1;
                long i3 = 0;
                while (i3 <= 4000000)
                {
                    i3 = i1 + i2;
                    Fibonacci.Add(i2);
                    i1 = i2;
                    i2 = i3;                 
                }
                long Sum = Fibonacci.Where(x => x % 2 == 0).Sum();

                Console.WriteLine($"The sum is: {Sum}");
            }
        }


        static void LeetCode()
        {
            bool whiler = true;

            while (whiler is true)
            {
             Console.WriteLine(@"
             Write the following commands for the wanted algorithm.
             |1 or TWOSUM     - Two Sum.
             |2 or ROMAN      - Roman Numerals.
             |3 or PALINDROME - Palindrome.
             |4 or LASTWORD   - Lenght of the Last Word.
             |5 or ONEDSUM    - Running Sum of 1d Array.
             |9 or EXIT       - Exits the program.
             |_____________________________________________________________
            ");
                string MS = Console.ReadLine() ?? "BLANK";
                
                if (MS == "1") { MS = "TWOSUM"; }
                if (MS == "2") { MS = "ROMAN"; }
                if (MS == "3") { MS = "PALINDROME"; }
                if (MS == "4") { MS = "LASTWORD"; }
                if (MS == "5") { MS = "ONEDSUM"; }
                if (MS == "9") { MS = "EXIT";    }
                MS = MS.ToUpper();
                switch (MS)
                {

                    case "TWOSUM":
                        Algorithms.TwoSum();
                    break;

                    case "ROMAN":
                        Algorithms.Roman();
                    break;
                    
                    case "PALINDROME":
                        Algorithms.Palindrome();
                    break;

                    case "LASTWORD":
                        Algorithms.LastWordLength();
                    break;

                    case "ONEDSUM":
                        Algorithms.OnedSum();
                    break;

                    case "EXIT":
                        Program.MainMenu();
                    break;

                    default:
                        Console.WriteLine("Invalid Command");
                    break;
            }
         }
    }

        static void Other()
        {
            bool whiler = true;

            while (whiler is true)
            {
             Console.WriteLine(@"
             Write the following commands for the wanted algorithm.
             |1 or FIZZ       - FizzBuzz.
             |2 or EXTENSE    - Text in Extense.
             |3 or PRIME      - Checks if a range of numebrs are prime.
             |4 or FIBO       - Even Fibonacci Sum.
             |9 or EXIT       - Exits the program.
             |_____________________________________________________________
            ");
                string MS = Console.ReadLine() ?? "BLANK";
                
                if (MS == "1") { MS = "FIZZ"; }
                if (MS == "2") { MS = "EXTENSE"; }
                if (MS == "3") { MS = "PRIME"; }
                if (MS == "4") { MS = "FIBO"; }
                if (MS == "9") { MS = "EXIT";    }
                MS = MS.ToUpper();
                switch (MS)
                {

                    case "FIZZ":
                        Algorithms.FizzBuzz();
                    break;

                    case "EXTENSE":
                        Algorithms.Extense();
                    break;

                    case "PRIME":
                        Algorithms.PrimeCheck();
                    break;
                    
                    case "FIBO":
                        Algorithms.EvenFibonacci();
                    break;

                    case "EXIT":
                        Program.MainMenu();
                    break;

                    default:
                        Console.WriteLine("Invalid Command");
                    break;
                }
            }
        }

        static void MainMenu()
        {
            bool whiler = true;

            while (whiler is true)
            {
             Console.WriteLine(@"
             Write the following commands for the wanted algorithm.

             |1 or LEETCODE   - Problems Taken from Leetcode
             |2 or OTHER      - Problems Taken from other source
             |9 or EXIT       - Exits the program.
             |_____________________________________________________________
            ");
                string MS = Console.ReadLine() ?? "BLANK";
                
                if (MS == "1") { MS = "LEETCODE";    }
                if (MS == "2") { MS = "OTHER"; }
                if (MS == "9") { MS = "EXIT";    }
                MS = MS.ToUpper();
                switch (MS)
                {
                    case "LEETCODE":
                        Program.LeetCode();
                    break;

                    case "OTHER":
                        Program.Other();
                    break;

                    case "EXIT":
                        whiler = false;
                    break;

                    default:
                        Console.WriteLine("Invalid Command");
                    break;
                }
                            
            }
        }
        
        static void Main(string[] args)
        {
            Program.MainMenu();
        }
    }
}
    

