﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            Card cardOne = new Card();
            cardOne.Face = "Queen";
            cardOne.Suit = "Spades";

            Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            Console.ReadLine();
        }
    }
}