using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private uint _threads = 4;

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
        public uint Threads
        {
            get { return _threads; }
            set
            {
                if (value != 0)
                    _threads = value;
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
        /// Overloaded Constructor. FindPrimes() will operate for maximum 2 minutes.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        /// <param name="threads">Number of threads to use to calculate primes</param>
        public PrimesListBuilder(int numOfPrimes, uint threads)
        {
            NumOfPrimes = numOfPrimes;
            Threads = threads;
        }

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
        /// <param name="threads">Number of threads to use to calculate primes</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        public PrimesListBuilder(int numOfPrimes, uint threads, long maxTime)
        { NumOfPrimes = numOfPrimes; Threads = Threads; MaxTime = maxTime; }

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
        /// <param name="threads">Number of threads to use to calculate primes</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        /// <param name="startingValue">Value at which to start looking for primes.</param>
        public PrimesListBuilder(int numOfPrimes, uint threads, long maxTime, long startingValue)
        { NumOfPrimes = numOfPrimes; Threads = threads; MaxTime = maxTime; StartingValue = startingValue; }

        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        /// <param name="startingValue">Value at which to start looking for primes.</param>
        /// <param name="maxValue">Value at which, when reached, to stop looking for primes.</param>
        public PrimesListBuilder(int numOfPrimes, long maxTime, long startingValue, long maxValue)
        { NumOfPrimes = numOfPrimes; MaxTime = maxTime; StartingValue = startingValue; MaxValue = maxValue; }

        /// <summary>
        /// Overloaded Constructor.
        /// </summary>
        /// <param name="numOfPrimes">Number of Primes to return. (0=Inifinte)</param>
        /// <param name="threads">Number of threads to use to calculate primes</param>
        /// <param name="maxTime">Maximum time that FindPrimes() should be permitted to run (in Seconds).</param>
        /// <param name="startingValue">Value at which to start looking for primes.</param>
        /// <param name="maxValue">Value at which, when reached, to stop looking for primes.</param>
        public PrimesListBuilder(int numOfPrimes, uint threads, long maxTime, long startingValue, long maxValue)
        { NumOfPrimes = numOfPrimes; Threads = threads; MaxTime = maxTime; StartingValue = startingValue; MaxValue = maxValue; }

        #endregion

        #region Methods

        public List<long> FindPrimes()
        {
            List<long> listOfPrimes = new List<long>();
            var stopwatch = new System.Diagnostics.Stopwatch(); stopwatch.Start();

            Queue<long> nextPrime = new Queue<long>();

            for (int i = 0; i < Threads; i++)
                {
                nextPrime.Enqueue(StartingValue + i);
            }

            while (nextPrime.ElementAt(0) <= MaxValue && listOfPrimes.Count < NumOfPrimes && stopwatch.ElapsedMilliseconds <= MaxTime * 1000)
            {

                List<long> batch = new List<long>();
                for (int i = 0; i < Threads; i++)
                {
                    batch.Add(nextPrime.Dequeue());
                }

                Task<bool> t1 = new Task<bool>(() => (IsPrime(batch[0])));
                Task<bool> t2 = new Task<bool>(() => (IsPrime(batch[1])));
                Task<bool> t3 = new Task<bool>(() => (IsPrime(batch[2])));
                Task<bool> t4 = new Task<bool>(() => (IsPrime(batch[3])));

                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();

                t1.Wait();
                t2.Wait();
                t3.Wait();
                t4.Wait();

                if (t1.Result == true)
                    listOfPrimes.Add(batch[0]);
                if (t2.Result == true)
                    listOfPrimes.Add(batch[1]);
                if (t3.Result == true)
                    listOfPrimes.Add(batch[2]);
                if (t4.Result == true)
                    listOfPrimes.Add(batch[3]);

                for (int i = 0; i < Threads; i++)
                {
                    nextPrime.Enqueue(batch[3] + i + 1);
                }
            }

            return listOfPrimes;
        }

        private Boolean IsPrime(long number)
        {
            long i = 2;
            Boolean isPrime = true;

            while (i <= System.Math.Sqrt(number))
            {

                if (number % i == 0)
                { isPrime = false; break; }
                i++;
            }

            return isPrime;
        }

        #endregion
    }
}
