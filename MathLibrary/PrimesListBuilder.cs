using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class PrimesListBuilder
    {
        #region Business Rules

        private long busRuleMaxValue = Int64.MaxValue;
        private long busRuleMaxTime = Int64.MaxValue / 1000;
        private sbyte busRuleStartingValue = 0;

        #endregion

        #region Private Properties

        private List<long> _primesList = new List<long>();

        private int _numOfPrimes = Int32.MaxValue;
        private long _startingValue = 0;
        private long _maxValue = Int64.MaxValue;
        private long _maxTime = 120;

        #endregion

        #region Public Fields

        public List<long> PrimesList
        {
            get { return _primesList; }
            set { _primesList = value; }
        }

        /// <summary>
        /// Gets and Sets a MaxTime interval, as expressed in seconds, for how long the class should spend looking for primes. (Default 120 sec./2 mins.)
        /// </summary>
        public long MaxTime
        {
            get { return _maxTime; }
            set
            {
                if (value <= busRuleMaxTime)
                    _maxTime = value;
                else
                    throw new Exception("The value specified for MaxTime is too large. The maximum value allowed is " + busRuleMaxTime + ".");
            }
        }


        public long StartingValue
        {
            get { return _startingValue; }
            set
            {
                if (value >= busRuleStartingValue)
                    _startingValue = value;
                else
                    throw new Exception("Starting Values may not be a negative number");
            }
        }

        public long MaxValue
        {
            get { return _maxValue; }
            set
            {
                if (value > busRuleMaxValue)
                    throw new Exception("The Maximum Value specified is too large. The maximum allowed value is " + busRuleMaxValue + ".");
                else
                    _maxValue = value;


                if (value <= StartingValue)
                    throw new Exception("The Maximum Value specified is smaller than or equal to the Starting Value. The current Starting Value is " + StartingValue + ".");
            }
        }
        public int NumOfPrimes
        {
            get { return _numOfPrimes; }
            set
            {
                if (value != 0)
                    _numOfPrimes = value;
            }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default Constructor. FindPrimes() will return 2 minutes worth of Primes.
        /// </summary>
        public PrimesListBuilder() { }

        /// <summary>
        /// Overloaded Constructor. FindPrimes() will operate for maximum 2 minutes.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        public PrimesListBuilder(int numOfPrimes)
        { NumOfPrimes = numOfPrimes; }

        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        public PrimesListBuilder(int numOfPrimes, long maxTime)
        { NumOfPrimes = numOfPrimes; MaxTime = maxTime; }

        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        /// <param name="startingValue">Value at which to start looking for primes.</param>
        public PrimesListBuilder(int numOfPrimes, long maxTime, long startingValue)
        { NumOfPrimes = numOfPrimes; MaxTime = maxTime; StartingValue = startingValue; }

        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        /// <param name="startingValue">Value at which to start looking for primes.</param>
        /// <param name="maxValue">Value at which, when reached, to stop looking for primes.</param>
        public PrimesListBuilder(int numOfPrimes, long maxTime, long startingValue, long maxValue)
        { NumOfPrimes = numOfPrimes; MaxTime = maxTime; StartingValue = startingValue; MaxValue = maxValue; }

        #endregion

        #region Methods

        public List<long> FindPrimes()
        {
            List<long> listOfPrimes = new List<long>();
            var stopwatch = new System.Diagnostics.Stopwatch(); stopwatch.Start();

            long w = StartingValue;

            while (w <= MaxValue && listOfPrimes.Count < NumOfPrimes && stopwatch.ElapsedMilliseconds <= MaxTime * 1000)
            {
                long i = 2;
                bool isPrime = true;

                while (i <= System.Math.Sqrt(w))
                {
                    if (stopwatch.ElapsedMilliseconds >= MaxTime * 1000)
                        break;

                    if (w % i == 0)
                    { isPrime = false; break; }
                    i++;
                }
                
                if (isPrime == true)
                    listOfPrimes.Add(w);
                w++;
            }

            return listOfPrimes;
        }

        #endregion
    }
}
