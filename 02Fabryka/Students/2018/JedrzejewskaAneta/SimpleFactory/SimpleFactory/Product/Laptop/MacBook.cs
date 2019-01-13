﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Product.Computer
{
    class MacBook : Laptop
    {
        public MacBook()
        {
            brand = "Apple";
            model = "MacBook 12";
            ram = 8;
            diagonal = 12;
        }
    }
}
