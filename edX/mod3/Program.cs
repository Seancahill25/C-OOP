using System;
using System.Globalization;
using System.IO;



namespace Mod3_Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader streamReaderObject = null;

            try
            {
                streamReaderObject = new StreamReader("file1.txt");

                String contents = streamReaderObject.ReadToEnd();

                streamReaderObject.Close();

                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found.");
            }
        }
    }
}
