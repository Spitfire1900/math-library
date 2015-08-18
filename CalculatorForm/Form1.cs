using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MathLibrary;
using MiscDataLibrary;
using System.Threading.Tasks;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFactor_Click(object sender, EventArgs e)
        {
            Int64 intCheck = 0; if (txtBxIntToFactor.TextLength == (Int64)0 || System.Text.RegularExpressions.Regex.IsMatch(txtBxIntToFactor.Text, @"[\d]") == false || Int64.TryParse(txtBxIntToFactor.Text, out intCheck) == false)
                MessageBox.Show("You must enter an integer to continue");
            else
                writeTxtBxFactors(Int64.Parse(txtBxIntToFactor.Text));

        }

        private void writeTxtBxFactors(Int64 intToFactor)
        {
            PrimeFactorization pF = new PrimeFactorization(intToFactor); List<Int64> li = pF.Factor();

            string f = "";
            foreach (Int64 i in li)
            {
                if (f == "") f = i.ToString();
                else
                    f = f + "*" + i;
            }

            txtBxFactors.Text = f;
        }

        private void btnPrimesStart_Click(object sender, EventArgs e)
        {
            txtBxPrimes.Clear();

            if (chkBxLiveUpdate.Checked != true)
            {
                Task<List<long>> lBuilder = new Task<List<long>>(() =>
                    new PrimesListBuilder((int)numUDNumOfPrimes.Value, (long)numUDMaxTime.Value * 60, (long)numUDStartingValue.Value, (long)numUDMaxValue.Value).FindPrimes());
                lBuilder.Start();
                
                List<long> lPrimes = lBuilder.Result;

                StringBuilder sBU = new StringBuilder(); foreach (long u in lPrimes)
                    if (sBU.Length == 0)
                        sBU.Append(u);
                    else
                        sBU.Append(", " + u);

                txtBxPrimes.Text = sBU.ToString();
            }
            else
            {
                long w;
                var stopwatch = new System.Diagnostics.Stopwatch(); stopwatch.Start();
                long l = (long)numUDStartingValue.Value; for (int i = 1; i <= (int)numUDNumOfPrimes.Value; i++)
                {
                    if (stopwatch.ElapsedMilliseconds >= (long)numUDMaxTime.Value * 60 * 1000)
                        break;

                    Task<List<long>> lBuilder = new Task<List<long>>(() =>
                    new PrimesListBuilder(1, (long)numUDMaxTime.Value * 60, l, (long)numUDMaxValue.Value).FindPrimes());
                    lBuilder.Start();

                    w = lBuilder.Result[0];

                    if (txtBxPrimes.Text == "")
                        txtBxPrimes.Text = w.ToString();
                    else
                        txtBxPrimes.Text = txtBxPrimes.Text + ", " + w.ToString();

                    
                    l = w + 1;
                }
            }
            if (txtBxPrimes.Text == "")
                txtBxPrimes.Text = "No primes were found";
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            CSVListAdapter csv = new CSVListAdapter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Gottfried Studios\MiscDataLibrary\list.csv");
            string[] primes;

                string haystack = txtBxPrimes.Text;
                char needle = ',';
                primes = haystack.Split(new char[] {needle}, haystack.Count(s => s == needle));

            string[,] primesMultiDimensional = new string[1, primes.Length];
            int iT = 0;
            int iC = 0;
            while (iT < primes.Length)
            {
                for (int i = 0; i <= 255; i++)
                {
                    if (!(iT < primes.Length))
                        break;

                    primesMultiDimensional[iC, i] = primes[iT];
                    iT++;
                }
                iC++;
            }

            //for (int i = 0; i < primes.Length; i++)
            //    primesMultiDimensional[0, i] = primes[i];

            csv.Write(primesMultiDimensional);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            CSVListAdapter csv = new CSVListAdapter(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Gottfried Studios\MiscDataLibrary\list.csv");

            string[,] array2d = csv.Read();
            foreach (string s in array2d)
                dataGridView1.Rows.Add(s);
        }
    }
}
