using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette
{
    class Bin
    {
        public Bin(string number, string color)
        {
            this.Nums = number;
            this.Color = color;
        }
        public string Nums { get; set; }
        public string Color { get; set; }
        public byte Num { get; set; }
    }
}
