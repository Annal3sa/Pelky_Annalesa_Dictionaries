using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Pelky_Annalesa_Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Makes a dictionary that takes int as th key and a string as the value, called topGames
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Sally Face");
            topGames.Add(2, "Resident Evil 7");
            topGames.Add(3, "Mindcraft");
            topGames.Add(4, "Omari");
            topGames.Add(5, "GTA 5");
            topGames.Add(6, "Kindergarten");
            topGames.Add(7, "My Friend Pedro");
            topGames.Add(8, "Slime Rancher");
            topGames.Add(9, "DDLC");
            topGames.Add(10, "The Mortuary Assitant");

            //Loops through the topGames dictionary and prints out each Key/Value pair on a new line
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // if the dictionary contains key one. it will print out "My favorite game is: <topGames[1]>"
            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My faveorite game is: {topGames[1]}");
            }

            //Implements the TryGetValue method on topGames for key 11, sets output to result string.


            string result = "";

            //If it outputs something to result then prints the result to console, else prints, "There is no game in the eleventh position."
            topGames.TryGetValue(11, out result);

            if (result != "") 
            {
                Console.WriteLine(result);
;           }
            else
            { 
                Console.WriteLine("There is no game in the 11th postion.");
            }

            //Switches the dictionary entry object at key 5 with a new game title you also enjoy
            if (topGames.ContainsKey(5))
            {
                topGames[5] = "Spiderman ps4";
            }

            Console.WriteLine(topGames[5]);
            //Creates a new Hashtable and set it equal to topGames.
            Hashtable hashTable = new Hashtable(topGames);

            //Creates a string called favGame.

            string favGame = (string)hashTable[1];
            //Prints favGame to console.
            Console.WriteLine($"Favorite Game: {favGame}");

            //Creates another hashtable using collection-initializer syntax, called capitals.
            Hashtable capitals = new Hashtable() { 

                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Ohio", "Colombus" },
            };
            //Creates another hashtable using collection-initializer syntax, called capitals.
            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Vale}");
            }
            //Clears all elements in the capitals hashtable.

            capitals.Clear();

        }
    }
}