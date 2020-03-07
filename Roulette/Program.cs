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
        
