using System;
using System.Collections.Generic;




class Program
{
    static void Main(string[] args)
    {

        string[] colors =  { "Red", "Yellow", "Purple", "Pink", "White" };//This is a one dimensional array of strings

        Console.WriteLine("Please input your favorite flower");//The user inputs info
        string flower = Console.ReadLine();

        for ( int i = 0; i < colors.Length; i++)//For Loop that iterates through each string in the array 
        {
        colors[i] = colors[i] + flower;//Adds the users input to the end of each string 
        }
        //for (int i = 0; i - colors.Length < i++; i++)  Created an infinite loop
        //{
            //Console.WriteLine("Whoops!");///The message if you are in an infinite loop
        //}
        foreach (string color in colors)//Loops through string
        {
            Console.WriteLine(color);//Prints the string line by line with the user input added 
        }
        
        Console.ReadLine();


        int[] scores = { 103, 52, 78, 89, 210, 65, 110 };// This is an array of integers 

        for (int i = 0; i  < scores.Length; i++)//This is a for loop 
        {
            if (scores[i] > 70)//This compares the integers in the array to see of they are greater than 70
            {
                Console.WriteLine("You're a top scorer! Great job!: " + scores[i]);//This displays all of the integers in the array that are greater than 70
            }
        }
        Console.ReadLine();

        int[] bankBalance = { 200, 60, 1000, 5000, 700, 100, 85 };// This is an array of integers

        foreach (int balance in bankBalance)//This is a for each loop for the integers in the array
        {
            if (balance <= 300)//This the an if statement that asks if the numbers are less than or equal to 300
            {
                Console.WriteLine("You have no money saved! : " + balance);//This displays all of the integers in the array that are less than or equal to 300
            }
        }
        Console.ReadLine();

        List<string> animals = new List<string>() { "dog", "cat", "pig", "horse", "chicken" };// This is a List of strings
        Console.WriteLine("Please pick an animal from the list: dog, cat, pig, horse, chicken");//This asks the user to chose an animal from the list
        string animalSelected = Console.ReadLine();//This displays users animal picked
        foreach (string animal in animals)//This is a for each loop for an animal in animals list
        {
            if (animalSelected == animal)//The is an if statement that if the animal selected is equal to the animal
            {
                Console.WriteLine("You have chosen " + animalSelected + " which is in index number " + animals.IndexOf(animalSelected));//This displays the animal chosen and also 
                break; //  Stops code from executing once match found                                                                                                                    //shows the index of that animal in the list
            }
            else if (!animals.Contains(animalSelected))// This is an else if statement if the user enters and animal not from the list
            {
                Console.WriteLine( "Sorry, animal chosen not on the list");//This is displayed to the user if they chose an animal not on the list
                break;//Stops code from executing 
            }
            
        }
        Console.ReadLine();

        List<string> sports = new List<string>() { "football", "soccer", "tennis", "baseball", "football", "basketball", "soccer" };//Created a list of strings with two identical strings
        Console.WriteLine("Please select a sport from the list: football, soccer, tennis, baseball, football, basketball, soccer ");//Asking the user to pick a sport from the list
        string selectedSport = Console.ReadLine(); //The users chosen sport displayed

        for (int b = 0; b < sports.Count; b++)//This is a for loop 
        {
            if (sports[b] == selectedSport)// if the users sport equals the selected sport do the following
            {
                Console.WriteLine(b);//This prints the indices of the selected sport

            }
            else if (!sports.Contains(selectedSport))
            {
                Console.WriteLine("You entered a sport not on the list");
            }
        }
        Console.ReadLine();

        List<string> movies = new List<string>() { "Dune", "Old School", "Star Wars", "Avengers", "Dune", "The Matrix" };// This is a list string with two identical strings
        List<string> movies2 = new List<string>();//This is an empty list
        foreach (string movie in movies)//This is a foreach loop
        { 
            Console.WriteLine(movie);

            if (movies2.Contains(movie))
            {
                Console.WriteLine("This is on the list twice");//If a movie appears twice this is the output
            }

            else
            {
                Console.WriteLine("This movie is on the list once");//This is the output if the movie appears only once
                Console.WriteLine();
                movies2.Add(movie);
            }
            
        }
        Console.ReadLine();


        









    }
}

