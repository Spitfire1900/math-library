//Copyright © 2015 Kyle Gottfried. All Rights Reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using m = System.Math;

namespace MathLibrary
{
    public class PrimeFactorization
    {
        #region Business Rules



        #endregion

        #region Private Properties

        private Int64 _intToFactor;

        #endregion

        #region Public Fields

        public Int64 IntToFactor
        {
            get { return _intToFactor; }
            set { _intToFactor = value; }
        }

        #endregion

        #region Constructors

        public PrimeFactorization(Int64 intToFactor)
        {
            IntToFactor = intToFactor;
        }

        #endregion

        #region Methods

        public List<Int64> Factor()
        {
            List<Int64> Li = new List<Int64>();

            Int64 d = 2;
            Int64 w = IntToFactor; //Working number

            while (d <= IntToFactor / 2)
            {
                if (w % d == 0)
                {
                    w = w / d;
                    Li.Add(d);
                    d = 2;
                }
                else
                    d++;
            }

            if (Li.Count == 0) { Li.Add(1); Li.Add(IntToFactor); }

            return Li;
        }

        #endregion
    }
}
