using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Roll
    {
        
        
            
        public string[] Nums { get;}
        public string[] Color { get; }
        public static Bin Play( )
        {
            string[] Color = new string[] { "Red", "Black", "Green" };
            Random random = new Random();
            string playnums = Convert.ToString(random.Next(36));
             string playcolor = "";
            switch (playnums)
            {
                case "0":
                    playcolor = Color[2];
                    return new Bin( playnums,playcolor);
                    
                case "1":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "2":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "3":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "4":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "5":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "6":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor); 
                case "7":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "8":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "9":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "10":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "11":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "12":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "13":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "14":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "15":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "16":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "17":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "18":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "19":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "20":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "21":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "22":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "23":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "24":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "25":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "26":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "27":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "28":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "29":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "30":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "31":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "32":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "33":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "34":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "35":
                    playcolor = Color[1];
                    return new Bin(playnums, playcolor);
                case "36":
                    playcolor = Color[0];
                    return new Bin(playnums, playcolor);
                case "00":
                    playcolor = Color[2];

                    return new Bin(playnums, playcolor); 
                default:
                    break;

            }
            return new Bin(playnums, playcolor);

        }
    }
}
