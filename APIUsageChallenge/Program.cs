using System;
using RestSharp;

/* ---------------------------
// --- API Usage Challenge ---
// ---------------------------

 -Goal
Create a Console app that will look up people in the SWAPI (https://swapi.dev/) based upon their ID
number. Handle missing IDs/errors and load all the data for successful entries.

- Bonus
Cache requests in memory. If you call the same call again, have it pull from the cache instead of from the
API.

- Hint
Use RestSharp to consume the API
*/

namespace APIUsageChallenge {
    class Program {

        static void Main(string[] args) {
            Console.WriteLine(" ------------------------------------------------------ ");
            Console.WriteLine(" --- Console App for looking up poeple in the SWAPI --- ");
            Console.WriteLine(" ------------------------------------------------------ ");
            SwapiApiConsumer swapiApiConsumer = new SwapiApiConsumer();

            bool isContinued = true;
            while (isContinued) {
                //isContinued = IsUserContinuing();
                int id = getPersonIdFromUser();
                string res = swapiApiConsumer.GetPerson(id);
                Console.WriteLine(res);
            }
        }

        private static int getPersonIdFromUser() {
            Console.WriteLine(" Type in id to look up a Person ");
            int id = 0;
            int maxTries = 5;

            while (id <= 0 && maxTries > 0) {
                Console.WriteLine("maxTries " + maxTries);
                if (maxTries == 5) {
                    Console.WriteLine("Please type in a valid id");
                } else {
                    Console.WriteLine("Not a valid id, please try again");
                }
                if (maxTries == 1) { Console.WriteLine("Last Try to type in a valid id"); }
                string str = Console.ReadLine();
                int.TryParse(str, out id);
                maxTries--;
            }
            if (id <= 0) { Environment.Exit(0); }
            return id;
        }

        private static bool IsUserContinuing() {
            Console.WriteLine(" Do you want to continue? type y or n");
            int maxTries = 5;
            while (maxTries > 0) {
                string str = Console.ReadLine();

                switch (str) {
                    case "y":
                        return true;
                    case "n":
                        return false;
                    default:
                        maxTries--;
                        Console.WriteLine("Please enter y or n");
                        break;
                }
            }
            return false;
        }
    }
}
