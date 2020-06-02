using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

/* Formirati datoteku “upis.txt” u direktorijumu Debug koja u sebi sadrži redove teksta.
Napisati funkciju koja čita datoteku i vraća string string je MALI zapis.
U ovom zadatku je potrebno koristiti komandu Substring ili Split.
*/

namespace CS322_DZ02
{
    class Program
    {
        public static void Main()
        {
            string read_words = "";
            string path = "..\\..\\Debug\\upis.txt";

            // dir debug print
            string curr_dir = Directory.GetCurrentDirectory();
            Console.WriteLine("The current directory is {0}", curr_dir);


            if (!File.Exists(path))
            {
                //if the file doesn't exist, create it
                try
                {
                    using (StreamWriter sw = File.CreateText(path))
                    {
                        sw.WriteLine("Hello,");
                        sw.WriteLine("Here,");
                        sw.WriteLine("Are,");
                        sw.WriteLine("Some,");
                        sw.WriteLine("Words");
                    }
                }
                catch (Exception e) { }
            }

            //read from the file
            try
            {
                using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    read_words += s;
                }
            }
            }
            catch (Exception e) { }
            List<String> listStrLineElements = read_words.Split(",").ToList();
            listStrLineElements.Add("JE MALI ZAPIS");

            foreach (string s in listStrLineElements)
            {
                Console.Write(s + "\n\r");
            }
            
        }
    }
}
