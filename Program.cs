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
      Console.WriteLine("We need three adjectives for the first part. \nAn adjective is a word that describes a noun, like a color or feeling or texture.");

      Console.Write("Enter first adjective here: ");
      string firstAdjective = Console.ReadLine();

      Console.Write("Enter second adjective here: ");
      string secondAdjective = Console.ReadLine();

      Console.Write("Enter third adjective here: ");
      string thirdAdjective = Console.ReadLine();

      // Ask user for one verb:


      // The template for the story:

      string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


      // Print the story:

    }
  }
}
