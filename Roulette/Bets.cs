using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Bets
    {
        
        public static String[] Values = new String[38] { "0", "00", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", };



        public static void BetOne(Bin bin)
        {

            Console.WriteLine($"This is the winning number {bin.Nums}.");

        }
        public static void BetTwo(Bin bin)
        {

            if (bin.Nums == "0" || bin.Nums == "00")
            {
                Console.WriteLine($"{bin.Nums} It is not even or odd.");
            }
            if ((int.Parse(bin.Nums) % 2) == 0)
            {
                Console.WriteLine("The winning number is even.");
            }
            else
            {
                Console.WriteLine("The winning number is odd.");
            }

        }
        public static void BetThree(Bin bin)
        {
            if (bin.Color == "Red")
            {
                Console.WriteLine($"The winning color is {bin.Color}");
            }
            if (bin.Color == "Black")
            {
                Console.WriteLine($"The winning color is {bin.Color}");
            }
            if (bin.Color == "Green")
            {
                Console.WriteLine($"The winning color is {bin.Color}");
            }

        }
        public static void BetFour(Bin bin)
        {
            if (int.Parse(bin.Nums) <= 18 && int.Parse(bin.Nums) >= 1)
            {
                Console.WriteLine("The winning number is a Low number");
            }
            else
            {
                Console.WriteLine("The winning number is a High number");
            }


        }
        public static void BetFive(Bin bin)
        {
            if (int.Parse(bin.Nums) <= 12 && int.Parse(bin.Nums) >= 1)
            {
                Console.WriteLine("The 1st thirds is the winning colum");
            }
            if (int.Parse(bin.Nums) <= 24 && int.Parse(bin.Nums) >= 13)
            {
                Console.WriteLine("The 2nd thirds is the winning colum");
            }
            if (int.Parse(bin.Nums) <= 36 && int.Parse(bin.Nums) >= 25)
            {
                Console.WriteLine("The 3rd thirds is the winning colum");
            }
        }
        public static void BetSix(Bin bin)
        {
            for (int i = 2, j = 3, k = 4; i < Values.Length; i += 3, j += 3, k += 3)
            {
                if (bin.Nums == Values[i])
                {
                    Console.WriteLine("The bottom column wins");
                }
                if (bin.Nums == Values[j])
                {
                    Console.WriteLine("The Middle column wins");
                }
                if (bin.Nums == Values[k])
                {
                    Console.WriteLine("The Top column wins");
                }
                if (bin.Nums == "0" || bin.Nums == "00")
                {
                    Console.WriteLine($" The ball lands on {bin.Nums} there are no winning columns.");
                }
            }

        }
        public static void BetSeven(Bin bin)
        {
            for (int i = 2; i < Values.Length; i += 3)
            {
                if (bin.Nums == "0" || bin.Nums == "00")
                {
                    Console.WriteLine($"There are no winning rows. The number lands on {bin.Nums}");
                }
                if (bin.Nums == Values[i] || bin.Nums == Values[i + 1] || bin.Nums == Values[i + 2])
                {
                    Console.WriteLine($"The winning street numbers are {Values[i]},{Values[i + 1]},{Values[i + 2]} ");
                }

            }
        }
        public static void BetEight(Bin bin)
        {
            for (int i = 2; i < Values.Length; i += 6)
            {
                if (bin.Nums == "0" || bin.Nums == "00")
                {
                    Console.WriteLine($"There are no winning rows. The number lands on {bin.Nums}");
                }
                if (bin.Nums == Values[i] || bin.Nums == Values[i +1] || bin.Nums == Values[i + 2] || bin.Nums == Values[i+3] || bin.Nums == Values[i+4] || bin.Nums == Values[i + 5])
                {
                    Console.WriteLine($"The winning double row numbers are {Values[i]},{Values[i +1]},{Values[i + 2]},{Values[i + 3]},{Values[i + 4]},{Values[i + 5]} ");
                }

            }

        }
        public static void BetNine(Bin bin)
        {
            for (int i = 6, j=5, k=7; i < 32; i+=3,k+=3,j+=3)
            {
                if(bin.Nums == "0" || bin.Nums == "00")
                {
                    Console.WriteLine("There are no winning splits");
                }
                if(bin.Nums == Values[i] )
                {
                    Console.WriteLine($"The winning split is  {Values[i]},{Values[i + 1]},{Values[i - 1]},{Values[i + 3]},{Values[i - 3]}");
                }
                if(bin.Nums==Values[k] )
                {
                    Console.WriteLine($"The winning split is  {Values[k]},{Values[k - 1]},{Values[k - 3]},{Values[k + 3]}");
                }
                if (bin.Nums == Values[j] )
                {
                    Console.WriteLine($"The winning split is  {Values[j]},{Values[j + 1]},{Values[j - 3]},{Values[j + 3]}");
                }
                
            }
            if (bin.Nums == "1")
            {
                Console.WriteLine($"The winning split is  {Values[2]},{Values[3]},{Values[5]}");
            }
            if (bin.Nums == "2")
            {
                Console.WriteLine($"The winning split is  {Values[2]},{Values[3]},{Values[4]},{Values[6]}");
            }
            if (bin.Nums == "3")
            {
                Console.WriteLine($"The winning split is  {Values[4]},{Values[3]},{Values[7]}");
            }
            if (bin.Nums == "34")
            {
                Console.WriteLine($"The winning split is  {Values[36]},{Values[32]},{Values[35]}");
            }
            if (bin.Nums == "35")
            {
                Console.WriteLine($"The winning split is  {Values[36]},{Values[35]},{Values[33]},{Values[37]}");
            }
            if (bin.Nums == "36")
            {
                Console.WriteLine($"The winning split is  {Values[37]},{Values[36]},{Values[37]}");
            }
        }
        public static void BetTen(Bin bin)
        {
            for (int i = 6, j = 5, k = 7; i < 32; i += 3, k += 3, j += 3)
            {
                if (bin.Nums == "0" || bin.Nums == "00")
                {
                    Console.WriteLine("There are no betting corners");
                }
                if (bin.Nums == Values[i])
                {
                    Console.WriteLine($"Your winning corners are  {Values[i]},{Values[i -4]},{Values[i - 1]},{Values[i - 3]}");
                    Console.WriteLine($"{Values[i-3]},{Values[i -2]},{Values[i]},{Values[i + 1]}");
                    Console.WriteLine($"{Values[i]},{Values[i + 1]},{Values[i + 3]},{Values[i +4]}");
                    Console.WriteLine($"{Values[i-1]},{Values[i]},{Values[i +2]},{Values[i + 3]}");
                }
                if (bin.Nums == Values[k])
                {
                    Console.WriteLine($"Your winning corners are  {Values[k-4]},{Values[k-3]},{Values[k-1]},{Values[k]}");
                    Console.WriteLine($"{Values[k-1]},{Values[k]},{Values[k+2]},{Values[k + 3]}");
                }
                if (bin.Nums == Values[j])
                {
                    Console.WriteLine($"Your winning corners are  {Values[j - 3]},{Values[j - 2]},{Values[j]},{Values[j+1]}");
                    Console.WriteLine($" {Values[j]},{Values[j+1]},{Values[j + 3]},{Values[j + 4]}");
                }

            }
            if (bin.Nums == "1")
            {
                Console.WriteLine($"The winning corner is 1,2,4,5");
            }
            if (bin.Nums == "2")
            {
                Console.WriteLine($"The winning corner  is 1,2,4,5 and 2,3,5,6");
            }
            if (bin.Nums == "3")
            {
                Console.WriteLine($"The winning corner is 2,3,5,6");
            }
            if (bin.Nums == "34")
            {
                Console.WriteLine($"The winning corner  is  31,32,34,35");
            }
            if (bin.Nums == "35")
            {
                Console.WriteLine($"The winning corner  is 31,32,34,35 and 32,32,35,36 ");
            }
            if (bin.Nums == "36")
            {
                Console.WriteLine($"The winning corner  is 32,32,35,36");
            }
        }
    }
}
