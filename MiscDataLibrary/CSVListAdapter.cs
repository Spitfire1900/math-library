using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace MiscDataLibrary
{
    public class CSVListAdapter
    {

        #region Private Properties

        private string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Gottfried Studios\\MiscDataLibrary\\" + "list.csv";

        private string[,] csvTable;

        #endregion

        #region Public Properities

        public string Filepath
        {
            get { return filepath; }
            set
            {
                if (Path.HasExtension(value) && Path.GetFileName(value) != null)
                    filepath = value;
            }
        }

        public string[,] CSVTable
        {
            get { return csvTable; }
            set { csvTable = value; }
        }

        #endregion

        #region Private Methods

        private bool isValidFileName(string filepath)
        {
            bool b = false;

            if (Path.HasExtension(filepath) && Path.GetFileName(filepath) != null)
                b = true;

            return b;
        }

        #endregion

        #region Public Methods

        public void Write(string[,] arrayToWrite)
        {
            if (File.Exists(Filepath) == false)
            { File.Create(Filepath); }

            StreamWriter sW = new StreamWriter(Filepath, false, Encoding.UTF8);

            try
            {
                string[,] array2d = arrayToWrite;
                int array2dColumnPositionFromRight = array2d.GetLength(1);

                foreach (string s in array2d)
                {
                    string sTemp = '\"' + s + '\"';

                    if (array2dColumnPositionFromRight > 1)
                    {
                        sW.Write("{0},", sTemp);
                        array2dColumnPositionFromRight--;
                    }
                    else
                    {
                        sW.WriteLine("{0}", sTemp);
                        array2dColumnPositionFromRight = array2d.GetLength(1);
                    }
                }
            }
            catch (Exception e)
            {
                throw new IOException("An error has occured, the data was not written to the file", e);
            }
            finally
            {
                sW.Close();
            }

        }

        public string[,] Read()
        {
            StreamReader sR = new StreamReader(Filepath, Encoding.UTF8);

            while (sR.Peek() != -1)
            {
                string s = sR.ReadLine();


            }

            string[,] a = { {"Hello"}, {"Bob"} };
            return a;
        }

        #endregion

        #region Constructors

        public CSVListAdapter(string filepath)
        {
            if (isValidFileName(filepath) == false)
                throw new Exception("Please pass in a valid filepath");
        }

        public CSVListAdapter(string filepath, string[,] csvList)
        {
            if (isValidFileName(filepath) == false)
                throw new Exception("Please pass in a valid filepath");
        }

        #endregion
    }
}
