using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a version of a popular MadLibs, short stories where the user is prompted to answer few silly questions only for the answers to be added to a story
      Author: Me, Maya
      */


      // Let the user know that the program is starting:
      Console.WriteLine("Are you ready? Because MadLibs is about to be written...");

      // Give the Mad Lib a title:
      string title = "Title: Čovječanstvo";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Hi, what is your name?");
      Console.Write("Enter name here: ");
      string name = Console.ReadLine();

      // Ask user for three adjectives:
      Console.WriteLine("Time to write your story " + name + ".");
      Console.WriteLine("We need three adjectives for the first part.\nAn adjective is a word that describes a noun, like a color or feeling or texture.");

      Console.Write("Enter first adjective here: ");
      string firstAdjective = Console.ReadLine();

      Console.Write("Enter second adjective here: ");
      string secondAdjective = Console.ReadLine();

      Console.Write("Enter third adjective here: ");
      string thirdAdjective = Console.ReadLine();

      // Ask user for one verb:
      Console.WriteLine("Nicely done. This time we need one verb.\nA verb is a word that represents an action, for example 'sit' or 'sleep'.");
      Console.Write("Enter your choice of a verb here: ");
      string oneVerb = Console.ReadLine();

      // Ask user for two nouns:
      Console.WriteLine("Now we need two nouns for our story. A noun is a person, place or thing.");
      Console.Write("Enter first noun here: ");
      string firstNoun = Console.ReadLine();

      Console.Write("Enter second noun here: ");
      string secondNoun = Console.ReadLine();

      // Ask user to enter: an animal, a food, a fruit, a superhero, a counrty, a dessert and a year
      Console.WriteLine("This is where the story gets really interesting. Lets add some fun to our plot.");

      // Animal
      Console.Write("Enter an animal here: ");
      string animal = Console.ReadLine();
      // Food
      Console.Write("Enter a food here: ");
      string food = Console.ReadLine();
      // Fruit
      Console.Write("Enter a fruit here: ");
      string fruit = Console.ReadLine();
      // Superhero
      Console.Write("Enter a superhero here: ");
      string superhero = Console.ReadLine();
      // Country
      Console.Write("Enter a country here: ");
      string country = Console.ReadLine();
      // Dessert
      Console.Write("Enter a dessert here: ");
      string dessert = Console.ReadLine();
      // year
      Console.Write("Enter a year here: ");
      string year = Console.ReadLine();



      // The template for the story:

      string story = $"This morning {name} woke up feeling {firstAdjective}. 'It is going to be a {secondAdjective} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {oneVerb} to the rhythm of the {firstNoun}, which made all the {fruit}s very {thirdAdjective}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {secondNoun}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);
    }
  }
}
