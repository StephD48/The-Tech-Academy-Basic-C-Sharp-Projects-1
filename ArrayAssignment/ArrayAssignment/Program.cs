using System;
using System.Collections.Generic;



class Program
{
     static void Main()
     {
        string[] carArray = { "Toyota", "Nissan", "Subaru", "Volvo", "Honda" };//This is a string array of types of cars
        Console.WriteLine("Please choose a number  between 0 and 4");//This asks the User to pick a number between 0 and 4
        int carIndex = Convert.ToInt32(Console.ReadLine());
        if (carIndex >= 0 && carIndex <= 4) //If statement if the user chooses a number between 0 and 4 then print to console
        {
            Console.WriteLine("You chose the car type " + carArray[carIndex]);//The index content of the number the user chose
        }
        else
        {
            Console.WriteLine("You did not choose a number between 0 and 4 ");//This is diplayed to the user if they chose a number that was not between 0 and 4
        }
        Console.ReadLine();


        int[] intArray = { 30, 60, 90, 300, 700, 1000, 5000 };//This is a array of integers
        Console.WriteLine("Please choose an number between 0 and 6");//This asks the user to choose a number between 0 and 6
        int intIndex = Convert.ToInt32(Console.ReadLine());
        if (intIndex >= 0 && intIndex <= 6)//IF the User chooses a number between 0 and 6 then print to console
        {
            Console.WriteLine("You chose the number " + intArray[intIndex]);//The index content of the number the user chose
        }
        else
        {
            Console.WriteLine("You did not choose a number between 0 and 5 ");//This displays to the user that they chose a number not between the numbers 0 and 6
        }
        Console.ReadLine();


        List<string> intList = new List<string>();// This is a list of different animals in a string
        intList.Add("Dog");
        intList.Add("Cat");
        intList.Add("Horse");
        intList.Add("Chicken");
        intList.Add("Bird");
        intList.Add("Pig");

        Console.WriteLine("Please choose a number between 0 and 5");// This asks the user to choose a number between 0 and 5
        int listIndex = Convert.ToInt32(Console.ReadLine());
        if (listIndex >= 0 && listIndex <= 5)//IF the user chooses a number between 0 and 5 then print to the console
        {
            Console.WriteLine("You chose the animal " + intList[listIndex]);//This is the index content from the number the user chose
        }
        else
        {
            Console.WriteLine("You did not choose a number between 0 and 5");//This is displayed to the user if they chose a number that is not between 0 and 5
        }
        Console.ReadLine();



    }
}

