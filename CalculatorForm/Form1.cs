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
            MathLibrary.PrimesListBuilder.finishedFindingPrimes += PrimesListBuilder_finishedFindingPrimes;
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
                Task<List<long>> lBuilder = new Task<List<long>>(() =>
                    new PrimesListBuilder((int)numUDNumOfPrimes.Value, (long)numUDMaxTime.Value * 60, (long)numUDStartingValue.Value, (long)numUDMaxValue.Value).FindPrimes());
                lBuilder.Start();

                txtBxPrimes.Text = "This textbox will be populated shortly, computing primes.";
        }

        private void PrimesListBuilder_finishedFindingPrimes(object sender, PrimesListBuilder.finishedFindingPrimesEventArgs e)
        {

            if (e.listOfPrimes.Count != 0)
            {
                StringBuilder sBU = new StringBuilder();

                foreach (long u in e.listOfPrimes)
                    if (sBU.Length == 0)
                        sBU.Append(u);
                    else
                        sBU.Append(", " + u);
                SetText(sBU.ToString());
            }
            else
                SetText("No primes were found");
            
        }
        private void SetText(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.txtBxPrimes.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.txtBxPrimes.Text = text;
            }
        }

        // This delegate enables asynchronous calls for setting
        // the text property on a TextBox control.
        delegate void SetTextCallback(string text);
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
