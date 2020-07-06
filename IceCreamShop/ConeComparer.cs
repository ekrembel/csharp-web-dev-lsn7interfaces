using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IceCreamShop
{
    public class ConeComparer : IComparer<Cone>
    {
        public ConeComparer()
        {
        }

        public int Compare(Cone x, Cone y)
        {

            return string.Compare(x.Cost.ToString(), y.Cost.ToString());
        }
    }
}
