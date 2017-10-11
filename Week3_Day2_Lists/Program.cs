using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> testScores = new List<int>() { 98, 100, 76, 84, 93 };
            testScores.Add(80);
            testScores.Add(99);


            List<int> luckyNumbers = new List<int>();
            luckyNumbers.Add(2);
            luckyNumbers.Add(3);
            luckyNumbers.Add(5);
            luckyNumbers.Add(7);
            luckyNumbers.Add(1);
            Console.WriteLine(luckyNumbers.Count);


            List<string> faveFoods = new List<string>() { "steak", "chicken", "fish", "ice cream", "pierogi", "ribs", "hummus" };
            //Check your list by printing each element individually
            Console.WriteLine(faveFoods[0]);
            Console.WriteLine(faveFoods[1]);
            Console.WriteLine(faveFoods[4]);
            Console.WriteLine(faveFoods[5]);
            Console.WriteLine(faveFoods[6]);


            List<string> leastFaveFoods = new List<string>();
            leastFaveFoods.Add("pickles");
            leastFaveFoods.Add("yellow mustard");
            leastFaveFoods.Add("cucumbers");
            leastFaveFoods.Add("dill");
            Console.WriteLine(leastFaveFoods[0]);

            leastFaveFoods[0] = "cilantro";
            Console.WriteLine(leastFaveFoods[0]);

            Console.WriteLine();

            List<string> faveFilms = new List<string>() { "LOTR", "The Meteor Man", "Pride of the Yankees", "A Fish Called Wanda", "Young Frankenstein" };

            for(int i = 0; i < faveFilms.Count; i++)
            {
                Console.WriteLine(faveFilms[i]);
            }

            faveFilms.Insert(0, "Charlie and the Chocolate Factory");
            faveFilms.Insert(1, "Ferris Bueller's Day Off");
            faveFilms.Insert(2, "Damn Yankees");
            Console.WriteLine();

            foreach(string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            faveFilms.Remove("The Meteor Man");
            faveFilms.Remove("LOTR");
            Console.WriteLine();
            
            foreach(string film in faveFilms)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine();


            List<string> animals = new List<string>();
            animals.Add("elephant");
            animals.Add("dog");
            animals.Add("walrus");
            animals.Add("platypus");
            animals.Add("shark");

            foreach (string animal in animals)
            {
                Console.WriteLine(animal);
            }
            Console.WriteLine();
            
            //List boolList = new List() { true,false, false, true, false};
            //Loop through each value
            //If the value is true print: "Better bring an umbrella"
            //If the value is false print: "No rain today, enjoy the sun!"

            List<bool> boolList = new List<bool>() { true, false, false, true, false };
            for (int i = 0; i < boolList.Count; i++)
            {
                if(boolList[i] == true)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else
                {
                    Console.WriteLine("No rain today, enjoy the sun!");
                }
            }
            Console.WriteLine();


            //Create a list with the following numbers: 1, 23, 9, 77, 922, 6, 32, 63,14, 5
            //Use the .Contains() method and print the results of the method to console with the following values 23, 77, 15
            //Remove the 4 elements 27, 77, 32 and 6
            //Use the .Contains() method and print the results of the method to the console with the following values 23, 77, 15

            List<int> numbers = new List<int>() { 1, 23, 9, 77, 922, 6, 32, 63, 14, 5 };
            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));

            Console.WriteLine();

            numbers.Remove(27);
            numbers.Remove(77);
            numbers.Remove(32);
            numbers.Remove(6);

            Console.WriteLine(numbers.Contains(23));
            Console.WriteLine(numbers.Contains(77));
            Console.WriteLine(numbers.Contains(15));
            Console.WriteLine();


            //HOMEWORK
            //Come up with an example for how to use each of the methods / properties listed in the Common Properties & Methods section.
            //Count
            //Clear
            //Add
            //Remove
            //Sort
            //IndexOf
            //Contains
            //RemoveAt
            //Insert

            List<string> nhlTeams = new List<string>() { "Canadiens", "Maple Leafs", "Bruins", "Rangers", "Red Wings", "Blackhawks" };

            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("The number of teams on this list is " + nhlTeams.Count + ".");
            Console.WriteLine();

            Console.WriteLine("Clear this list.");
            nhlTeams.Clear();
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("Add some teams to the list.");
            nhlTeams.Add("Blue Jackets");
            nhlTeams.Add("Penguins");
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("Remove a team from the list.");
            nhlTeams.Remove("Penguins");
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("Add more teams to the list, and then sort the list.");
            nhlTeams.Add("Senators");
            nhlTeams.Add("Ducks");
            nhlTeams.Add("Devils");
            nhlTeams.Add("Hurricanes");
            nhlTeams.Add("Lightning");
            nhlTeams.Add("Canucks");
            nhlTeams.Sort();
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("The index of the Lightning is " + nhlTeams.IndexOf("Lightning") + ".");
            Console.WriteLine();

            Console.WriteLine("See if the Stars are on this list.");
            Console.WriteLine(nhlTeams.Contains("Stars"));
            Console.WriteLine();

            Console.WriteLine("Remove the team at the fourth index.");
            nhlTeams.RemoveAt(4);
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("Insert the Avalanche at the beginning of the list.");
            nhlTeams.Insert(0, "Avalanche");
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("Insert the Capitals in the fourth position.");
            nhlTeams.Insert(3, "Capitals");
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

            Console.WriteLine("Finally, insert the Wild at the end of the list.");
            nhlTeams.Insert(nhlTeams.Count, "Wild");
            foreach (string team in nhlTeams)
            {
                Console.WriteLine(team);
            }
            Console.WriteLine();

        }
    }
}
