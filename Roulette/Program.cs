using System;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("   :::::::::       ::::::::      :::    :::       :::        ::::::::::   :::::::::::   :::::::::::       ::::::::::  ");
            Console.WriteLine("  :+:    :+:     :+:    :+:     :+:    :+:       :+:        :+:              :+:           :+:           :+:      ");
            Console.WriteLine(" +:+    +:+     +:+    +:+     +:+    +:+       +:+        +:+              +:+           +:+           +:+ ");
            Console.WriteLine(" +#++:++#:      +#+    +:+     +#+    +:+       +#+        +#++:++#         +#+           +#+           +#++:++#  ");
            Console.WriteLine(" +#+    +#+     +#+    +#+     +#+    +#+       +#+        +#+              +#+           +#+           +#+");
            Console.WriteLine(" #+#    #+#     #+#    #+#     #+#    #+#       #+#        #+#              #+#           #+#           #+#   ");
            Console.WriteLine("###    ###      ########       ########        ########## ##########       ###           ###           ##########   ");
            Console.ResetColor();
            Bin bin = Roll.Play();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Bets.BetOne(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Bets.BetTwo(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Bets.BetThree(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Bets.BetFour(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Bets.BetFive(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Bets.BetSix(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Bets.BetSeven(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Bets.BetEight(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Bets.BetNine(bin);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Bets.BetTen(bin);
            Console.ResetColor();


        }
    }
}
        
