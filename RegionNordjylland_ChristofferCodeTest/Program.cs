using System;
using System.Collections.Generic;
using System.IO;

/*
// -------------------------
// --- Foreach Challenge ---
// -------------------------

- Goal
Create a Console app that has a List<string> populated with a set of names. Loop through the names using
the foreach. For every name, print it to the console.

- Bonus
Instead of strings, make a class and create a set of instances of that class instead. The class should store
first and last names. Use those properties when printing out the message on the console. 
 */

namespace ForeachChallenge
{
    class Program {
        static void Main(string[] args) {

            List<Name> names = new List<Name>();
            names = populateNamesList(names);
            printNames(names);
        }

        static private List<Name> populateNamesList(List<Name> names) {
            string filePath = @"..\..\..\random_names.csv";
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string headerLine = file.ReadLine();

            while ((line = file.ReadLine()) != null) {
                line = line.Replace("\"", "");
                string[] firstAndLastName = line.Split(',');
                string firstName = firstAndLastName[0];
                string lastName = firstAndLastName[1];
                Name name = new Name(firstName, lastName);
                names.Add(name);
            }

            file.Close();

            return names;
        }

        static private void printNames(List<Name> names) {
            foreach(Name name in names) {
                System.Console.WriteLine(name.FirstName + ' ' + name.LastName);
            }
        } 
    }
}
