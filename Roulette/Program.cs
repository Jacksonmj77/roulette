using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Bin bin = Roll.Play();
           // Console.WriteLine($"{bin.Color} {bin.Nums}"); displays the random number.
            Bets.BetOne(bin);
            Bets.BetTwo(bin);
            Bets.BetThree(bin);
            Bets.BetFour(bin);
            Bets.BetFive(bin);
            Bets.BetSix(bin);
            Bets.BetSeven(bin);
            Bets.BetEight(bin);
            Bets.BetNine(bin);
            Bets.BetTen(bin);

        }
    }
}
        
