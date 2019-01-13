﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory.Product
{
    public abstract class Televisor
    {
        protected string brand;
        protected string model;
        protected double diagonal;

        public string GetBrand()
        {
            return brand;
        }

        public string GetModel()
        {
            return model;
        }

        public double GetDiagonal()
        {
            return diagonal;
        }
    }
}
