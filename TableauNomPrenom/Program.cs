using System;
using System.Collections.Generic;
using System.IO;

namespace TableauNomPrenom
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<string> listePrenom = new List<string>();
            StreamReader nameFile = new StreamReader("/Users/necatihan/RiderProjects/TableauNomPrenom/Name");
            string line;
            while ((line = nameFile.ReadLine()) != null)
            {
                
                listePrenom.Add(line);
            }

            foreach (string name in listePrenom)
            {
                Console.WriteLine(name);
            }
        }
    }
}