﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KnapsackGen
{
    public class Mendel
    {

        public static ICaprazlamaStratejisi caprazlamaStratejisiUret(long strateji)
        {
            switch (strateji)
            {
                case 0:
                    return new TekNoktaCaprazlama();
                default:
                    return null;
            }
        }
    }
}